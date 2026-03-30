namespace Aiden_Tschebykin_4
{
    partial class Project4Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        // UI controls
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.RadioButton rdoLarge;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.ListBox listBoxDrinkType;
        private System.Windows.Forms.Label labelDrinkType;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.CheckBox chkEmployee;
        private System.Windows.Forms.GroupBox groupBoxOrderTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtOrderAmount;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelOrderAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ComboBox comboCoffeeFlavor;
        private System.Windows.Forms.Label labelCoffeeFlavor;
        private System.Windows.Forms.Button btnAddCoffee;
        private System.Windows.Forms.Button btnClearDrinkTypes;
        private System.Windows.Forms.ToolTip toolTip1;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxSize = new GroupBox();
            rdoLarge = new RadioButton();
            rdoMedium = new RadioButton();
            rdoSmall = new RadioButton();
            listBoxDrinkType = new ListBox();
            labelDrinkType = new Label();
            labelQuantity = new Label();
            txtQuantity = new TextBox();
            labelCustomerName = new Label();
            txtCustomerName = new TextBox();
            chkEmployee = new CheckBox();
            groupBoxOrderTotal = new GroupBox();
            txtTotal = new TextBox();
            txtDiscount = new TextBox();
            txtOrderAmount = new TextBox();
            labelTotal = new Label();
            labelDiscount = new Label();
            labelOrderAmount = new Label();
            btnCalculate = new Button();
            btnNewCustomer = new Button();
            btnExit = new Button();
            txtMessage = new TextBox();
            groupBoxSize.SuspendLayout();
            groupBoxOrderTotal.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxSize
            // 
            groupBoxSize.Controls.Add(rdoLarge);
            groupBoxSize.Controls.Add(rdoMedium);
            groupBoxSize.Controls.Add(rdoSmall);
            groupBoxSize.Location = new Point(12, 12);
            groupBoxSize.Name = "groupBoxSize";
            groupBoxSize.Size = new Size(200, 100);
            groupBoxSize.TabIndex = 0;
            groupBoxSize.TabStop = false;
            groupBoxSize.Text = "Size:";
            // 
            // rdoLarge
            // 
            rdoLarge.AutoSize = true;
            rdoLarge.Location = new Point(7, 68);
            rdoLarge.Name = "rdoLarge";
            rdoLarge.Size = new Size(54, 19);
            rdoLarge.TabIndex = 2;
            rdoLarge.TabStop = true;
            rdoLarge.Text = "&Large";
            rdoLarge.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            rdoMedium.AutoSize = true;
            rdoMedium.Location = new Point(7, 44);
            rdoMedium.Name = "rdoMedium";
            rdoMedium.Size = new Size(70, 19);
            rdoMedium.TabIndex = 1;
            rdoMedium.TabStop = true;
            rdoMedium.Text = "&Medium";
            rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoSmall
            // 
            rdoSmall.AutoSize = true;
            rdoSmall.Location = new Point(7, 20);
            rdoSmall.Name = "rdoSmall";
            rdoSmall.Size = new Size(54, 19);
            rdoSmall.TabIndex = 0;
            rdoSmall.TabStop = true;
            rdoSmall.Text = "&Small";
            rdoSmall.UseVisualStyleBackColor = true;
            // 
            // listBoxDrinkType
            // 
            listBoxDrinkType.FormattingEnabled = true;
            listBoxDrinkType.Location = new Point(230, 62);
            listBoxDrinkType.Name = "listBoxDrinkType";
            listBoxDrinkType.Size = new Size(160, 100);
            listBoxDrinkType.TabIndex = 2;
            listBoxDrinkType.Sorted = true;
            // 
            // labelDrinkType
            // 
            labelDrinkType.AutoSize = true;
            labelDrinkType.Location = new Point(230, 42);
            labelDrinkType.Name = "labelDrinkType";
            labelDrinkType.Size = new Size(66, 15);
            labelDrinkType.TabIndex = 10;
            labelDrinkType.Text = "Drink Type:";
            // 
            // labelCoffeeFlavor
            // 
            labelCoffeeFlavor = new Label();
            labelCoffeeFlavor.AutoSize = true;
            labelCoffeeFlavor.Location = new Point(230, 12);
            labelCoffeeFlavor.Name = "labelCoffeeFlavor";
            labelCoffeeFlavor.Size = new Size(82, 15);
            labelCoffeeFlavor.TabIndex = 9;
            labelCoffeeFlavor.Text = "Coffee Flavor:";
            // 
            // comboCoffeeFlavor
            // 
            comboCoffeeFlavor = new ComboBox();
            comboCoffeeFlavor.Location = new Point(318, 8);
            comboCoffeeFlavor.Name = "comboCoffeeFlavor";
            comboCoffeeFlavor.Size = new Size(160, 23);
            comboCoffeeFlavor.TabIndex = 1;
            comboCoffeeFlavor.DropDownStyle = ComboBoxStyle.DropDown;
            comboCoffeeFlavor.Sorted = true;
            comboCoffeeFlavor.Items.AddRange(new object[] { "Chocolate Almond", "French Roast", "Kona Blend", "Regular Decaf", "Regular Roast", "Vanilla Nut" });
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(12, 175);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(56, 15);
            labelQuantity.TabIndex = 4;
            labelQuantity.Text = "&Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(72, 172);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 5;
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Location = new Point(12, 210);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(97, 15);
            labelCustomerName.TabIndex = 6;
            labelCustomerName.Text = "&Customer Name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(117, 207);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(233, 23);
            txtCustomerName.TabIndex = 7;
            // 
            // chkEmployee
            // 
            chkEmployee.AutoSize = true;
            chkEmployee.Location = new Point(12, 240);
            chkEmployee.Name = "chkEmployee";
            chkEmployee.Size = new Size(83, 19);
            chkEmployee.TabIndex = 8;
            chkEmployee.Text = "Employee?";
            chkEmployee.UseVisualStyleBackColor = true;
            // 
            // groupBoxOrderTotal
            // 
            groupBoxOrderTotal.Controls.Add(txtTotal);
            groupBoxOrderTotal.Controls.Add(txtDiscount);
            groupBoxOrderTotal.Controls.Add(txtOrderAmount);
            groupBoxOrderTotal.Controls.Add(labelTotal);
            groupBoxOrderTotal.Controls.Add(labelDiscount);
            groupBoxOrderTotal.Controls.Add(labelOrderAmount);
            groupBoxOrderTotal.Location = new Point(12, 270);
            groupBoxOrderTotal.Name = "groupBoxOrderTotal";
            groupBoxOrderTotal.Size = new Size(338, 110);
            groupBoxOrderTotal.TabIndex = 9;
            groupBoxOrderTotal.TabStop = false;
            groupBoxOrderTotal.Text = "Order Total:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(100, 74);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(200, 23);
            txtTotal.TabIndex = 2;
            txtTotal.TabStop = false;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(100, 45);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(200, 23);
            txtDiscount.TabIndex = 1;
            txtDiscount.TabStop = false;
            // 
            // txtOrderAmount
            // 
            txtOrderAmount.Location = new Point(100, 16);
            txtOrderAmount.Name = "txtOrderAmount";
            txtOrderAmount.ReadOnly = true;
            txtOrderAmount.Size = new Size(200, 23);
            txtOrderAmount.TabIndex = 0;
            txtOrderAmount.TabStop = false;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(6, 77);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(36, 15);
            labelTotal.TabIndex = 2;
            labelTotal.Text = "Total:";
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(6, 48);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(57, 15);
            labelDiscount.TabIndex = 1;
            labelDiscount.Text = "Discount:";
            // 
            // labelOrderAmount
            // 
            labelOrderAmount.AutoSize = true;
            labelOrderAmount.Location = new Point(6, 19);
            labelOrderAmount.Name = "labelOrderAmount";
            labelOrderAmount.Size = new Size(87, 15);
            labelOrderAmount.TabIndex = 0;
            labelOrderAmount.Text = "Order Amount:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(370, 300);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 30);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "C&alculate Order Amount";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.Location = new Point(370, 336);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(120, 30);
            btnNewCustomer.TabIndex = 11;
            btnNewCustomer.Text = "&New Customer";
            btnNewCustomer.UseVisualStyleBackColor = true;
            btnNewCustomer.Click += btnNewCustomer_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(370, 372);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 30);
            btnExit.TabIndex = 12;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAddCoffee
            // 
            btnAddCoffee = new Button();
            btnAddCoffee.Location = new Point(490, 6);
            btnAddCoffee.Name = "btnAddCoffee";
            btnAddCoffee.Size = new Size(100, 26);
            btnAddCoffee.TabIndex = 13;
            btnAddCoffee.Text = "Add Coffee";
            btnAddCoffee.UseVisualStyleBackColor = true;
            btnAddCoffee.Click += btnAddCoffee_Click;
            // 
            // btnClearDrinkTypes
            // 
            btnClearDrinkTypes = new Button();
            btnClearDrinkTypes.Location = new Point(400, 62);
            btnClearDrinkTypes.Name = "btnClearDrinkTypes";
            btnClearDrinkTypes.Size = new Size(120, 26);
            btnClearDrinkTypes.TabIndex = 14;
            btnClearDrinkTypes.Text = "Clear Drink Types";
            btnClearDrinkTypes.UseVisualStyleBackColor = true;
            btnClearDrinkTypes.Click += btnClearDrinkTypes_Click;
            // 
            // toolTip1
            // 
            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(txtQuantity, "Enter quantity (numeric)");
            toolTip1.SetToolTip(txtCustomerName, "Enter customer name");
            toolTip1.SetToolTip(btnCalculate, "Calculate order amount");
            toolTip1.SetToolTip(btnNewCustomer, "Clear form for new customer");
            toolTip1.SetToolTip(btnExit, "Exit application");
            toolTip1.SetToolTip(btnAddCoffee, "Add the flavor in the combo box to the list of flavors");
            toolTip1.SetToolTip(btnClearDrinkTypes, "Clear all drink types from the list box");
            toolTip1.SetToolTip(comboCoffeeFlavor, "Select or type a coffee flavor");
            toolTip1.SetToolTip(listBoxDrinkType, "Select a drink type");
            toolTip1.SetToolTip(txtMessage, "Messages will display here");
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 400);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ReadOnly = true;
            txtMessage.Size = new Size(616, 68);
            txtMessage.TabIndex = 11;
            txtMessage.TabStop = false;
            // 
            // Project4Form
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnNewCustomer;
            ClientSize = new Size(640, 480);
            Controls.Add(txtMessage);
            Controls.Add(btnExit);
            Controls.Add(btnNewCustomer);
            Controls.Add(btnCalculate);
            Controls.Add(groupBoxOrderTotal);
            Controls.Add(chkEmployee);
            Controls.Add(txtCustomerName);
            Controls.Add(labelCustomerName);
            Controls.Add(txtQuantity);
            Controls.Add(labelQuantity);
            Controls.Add(labelDrinkType);
            Controls.Add(comboCoffeeFlavor);
            Controls.Add(labelCoffeeFlavor);
            Controls.Add(btnAddCoffee);
            Controls.Add(btnClearDrinkTypes);
            Controls.Add(listBoxDrinkType);
            Controls.Add(groupBoxSize);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Project4Form";
            Text = "Aiden Tschebykin";
            Load += Project4Form_Load;
            groupBoxSize.ResumeLayout(false);
            groupBoxSize.PerformLayout();
            groupBoxOrderTotal.ResumeLayout(false);
            groupBoxOrderTotal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
