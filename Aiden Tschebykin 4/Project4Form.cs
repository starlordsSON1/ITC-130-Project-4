namespace Aiden_Tschebykin_4
{
    public partial class Project4Form : Form
    {
        public Project4Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form load: welcome message and load drink types from file.
        /// </summary>
        private void Project4Form_Load(object? sender, EventArgs e)
        {
            MessageBox.Show("Welcome to our ordering application!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Attempt to load drink types from drinktypes.txt located next to executable
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "drinktypes.txt");
                if (File.Exists(path))
                {
                    listBoxDrinkType.Items.Clear();
                    using (var sr = new StreamReader(path))
                    {
                        string? line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(line))
                                listBoxDrinkType.Items.Add(line.Trim());
                        }
                    }
                    listBoxDrinkType.Sorted = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load drink types: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculate_Click(object? sender, EventArgs e)
        {
            // Clear message box
            txtMessage.Text = string.Empty;

            // Check customer name entered
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Must enter a Customer Name before placing an order.", "Missing Customer Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return;
            }

            // Validate quantity
            if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a numeric quantity", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            // Ensure drink type selected
            string drinkType = string.Empty;
            if (listBoxDrinkType.SelectedItem != null)
            {
                drinkType = listBoxDrinkType.SelectedItem.ToString() ?? string.Empty;
            }

            // Calculate Order Amount based on size
            decimal unitPrice = 0m;
            if (rdoSmall.Checked)
                unitPrice = 2.00m;
            else if (rdoMedium.Checked)
                unitPrice = 3.00m;
            else if (rdoLarge.Checked)
                unitPrice = 4.00m;

            decimal orderAmount = unitPrice * quantity;

            // Calculate discount (nested if)
            decimal discount = 0m;
            if (chkEmployee.Checked && quantity > 2)
            {
                discount = 0.10m * orderAmount; // employee and more than 2
            }
            else if (chkEmployee.Checked && quantity <= 2)
            {
                discount = 0.08m * orderAmount; // employee and 2 or less
            }
            else if (!chkEmployee.Checked && quantity > 4)
            {
                discount = 0.05m * orderAmount; // non-employee and more than 4
            }

            // Calculate total
            decimal total = orderAmount - discount;

            // Display in currency format
            txtOrderAmount.Text = orderAmount.ToString("C");
            txtDiscount.Text = discount.ToString("C");
            txtTotal.Text = total.ToString("C");

            // Add code to generate a lucky number between 1 and 50
            var rand = new Random();
            int lucky = rand.Next(1, 51);

            // Display message using switch on quantity
            string qtyMessage;
            switch (quantity)
            {
                case 0:
                    qtyMessage = "You ordered nothing.";
                    break;
                case 1:
                    qtyMessage = "Thank you for ordering 1 item.";
                    break;
                case 2:
                    qtyMessage = "Nice, 2 items ordered.";
                    break;
                default:
                    qtyMessage = "Great! You ordered multiple items.";
                    break;
            }

            string customer = txtCustomerName.Text.Trim();
            string size = rdoSmall.Checked ? "Small" : rdoMedium.Checked ? "Medium" : rdoLarge.Checked ? "Large" : "(no size)";
            string drinkDisplay = string.IsNullOrEmpty(drinkType) ? "(no drink selected)" : drinkType;

            MessageBox.Show($"{qtyMessage}\nCustomer: {customer}\nDrink: {drinkDisplay}\nSize: {size}\nYour lucky number is {lucky}.", "Order Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnNewCustomer_Click(object? sender, EventArgs e)
        {
            // Clear textboxes
            txtQuantity.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtOrderAmount.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtMessage.Text = string.Empty;

            // Default small radio
            rdoSmall.Checked = true;

            // No selection in drink list
            listBoxDrinkType.ClearSelected();
            comboCoffeeFlavor.Text = string.Empty;

            // Uncheck employee
            chkEmployee.Checked = false;

            txtQuantity.Focus();
        }
        /// <summary>
        /// Add coffee flavor from combo box to drink types list box.
        /// </summary>
        private void btnAddCoffee_Click(object? sender, EventArgs e)
        {
            string flavor = comboCoffeeFlavor.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(flavor))
            {
                MessageBox.Show("Please enter a coffee flavor to add.", "Missing Flavor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboCoffeeFlavor.Focus();
                return;
            }

            listBoxDrinkType.Items.Add(flavor);
            listBoxDrinkType.Sorted = true;
            comboCoffeeFlavor.Text = string.Empty;
        }

        /// <summary>
        /// Clear all drink types from the list box.
        /// </summary>
        private void btnClearDrinkTypes_Click(object? sender, EventArgs e)
        {
            listBoxDrinkType.Items.Clear();
        }
        private void btnExit_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
