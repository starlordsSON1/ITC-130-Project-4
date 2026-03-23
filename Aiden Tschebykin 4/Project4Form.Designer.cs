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
            listBoxDrinkType.Items.AddRange(new object[] { "Brewed", "Cappuccino", "Latte" });
            listBoxDrinkType.Location = new Point(230, 32);
            listBoxDrinkType.Name = "listBoxDrinkType";
            listBoxDrinkType.Size = new Size(120, 64);
            listBoxDrinkType.TabIndex = 3;
            // 
            // labelDrinkType
            // 
            labelDrinkType.AutoSize = true;
            labelDrinkType.Location = new Point(230, 12);
            labelDrinkType.Name = "labelDrinkType";
            labelDrinkType.Size = new Size(66, 15);
            labelDrinkType.TabIndex = 10;
            labelDrinkType.Text = "Drink Type:";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(12, 125);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(56, 15);
            labelQuantity.TabIndex = 11;
            labelQuantity.Text = "&Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(72, 122);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 4;
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Location = new Point(12, 160);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(97, 15);
            labelCustomerName.TabIndex = 13;
            labelCustomerName.Text = "&Customer Name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(117, 157);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(233, 23);
            txtCustomerName.TabIndex = 5;
            // 
            // chkEmployee
            // 
            chkEmployee.AutoSize = true;
            chkEmployee.Location = new Point(12, 196);
            chkEmployee.Name = "chkEmployee";
            chkEmployee.Size = new Size(83, 19);
            chkEmployee.TabIndex = 6;
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
            groupBoxOrderTotal.Location = new Point(12, 230);
            groupBoxOrderTotal.Name = "groupBoxOrderTotal";
            groupBoxOrderTotal.Size = new Size(338, 110);
            groupBoxOrderTotal.TabIndex = 7;
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
            btnCalculate.Location = new Point(370, 230);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 30);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "C&alculate Order Amount";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.Location = new Point(370, 266);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(120, 30);
            btnNewCustomer.TabIndex = 9;
            btnNewCustomer.Text = "&New Customer";
            btnNewCustomer.UseVisualStyleBackColor = true;
            btnNewCustomer.Click += btnNewCustomer_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(370, 302);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 30);
            btnExit.TabIndex = 10;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 360);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ReadOnly = true;
            txtMessage.Size = new Size(478, 78);
            txtMessage.TabIndex = 11;
            txtMessage.TabStop = false;
            // 
            // Project4Form
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnNewCustomer;
            ClientSize = new Size(512, 450);
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
            Controls.Add(listBoxDrinkType);
            Controls.Add(groupBoxSize);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Project4Form";
            Text = "Aiden Tschebykin";
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
