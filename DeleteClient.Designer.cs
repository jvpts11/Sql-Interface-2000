namespace Sql_Interactor
{
    partial class DeleteClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox_Customer_Id_Number = new TextBox();
            label2 = new Label();
            button_See_Customers = new Button();
            button_Search_Customer = new Button();
            button_Delete_Customer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(298, 37);
            label1.Name = "label1";
            label1.Size = new Size(269, 45);
            label1.TabIndex = 0;
            label1.Text = "Delete Customer";
            // 
            // textBox_Customer_Id_Number
            // 
            textBox_Customer_Id_Number.Location = new Point(241, 152);
            textBox_Customer_Id_Number.Name = "textBox_Customer_Id_Number";
            textBox_Customer_Id_Number.Size = new Size(241, 23);
            textBox_Customer_Id_Number.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 155);
            label2.Name = "label2";
            label2.Size = new Size(179, 15);
            label2.TabIndex = 2;
            label2.Text = "Customer Identification Number";
            // 
            // button_See_Customers
            // 
            button_See_Customers.Location = new Point(546, 151);
            button_See_Customers.Name = "button_See_Customers";
            button_See_Customers.Size = new Size(203, 23);
            button_See_Customers.TabIndex = 3;
            button_See_Customers.Text = "Update Customer List";
            button_See_Customers.UseVisualStyleBackColor = true;
            button_See_Customers.Click += button_See_Customers_Click;
            // 
            // button_Search_Customer
            // 
            button_Search_Customer.Location = new Point(546, 247);
            button_Search_Customer.Name = "button_Search_Customer";
            button_Search_Customer.Size = new Size(203, 23);
            button_Search_Customer.TabIndex = 4;
            button_Search_Customer.Text = "Search for a Customer";
            button_Search_Customer.UseVisualStyleBackColor = true;
            button_Search_Customer.Click += button_Search_Customer_Click;
            // 
            // button_Delete_Customer
            // 
            button_Delete_Customer.Location = new Point(298, 247);
            button_Delete_Customer.Name = "button_Delete_Customer";
            button_Delete_Customer.Size = new Size(184, 23);
            button_Delete_Customer.TabIndex = 5;
            button_Delete_Customer.Text = "Delete Customer";
            button_Delete_Customer.UseVisualStyleBackColor = true;
            button_Delete_Customer.Click += button_Delete_Customer_Click;
            // 
            // DeleteClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Delete_Customer);
            Controls.Add(button_Search_Customer);
            Controls.Add(button_See_Customers);
            Controls.Add(label2);
            Controls.Add(textBox_Customer_Id_Number);
            Controls.Add(label1);
            Name = "DeleteClient";
            Text = "Sql Interactor 2000 - Delete Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_Customer_Id_Number;
        private Label label2;
        private Button button_See_Customers;
        private Button button_Search_Customer;
        private Button button_Delete_Customer;
    }
}