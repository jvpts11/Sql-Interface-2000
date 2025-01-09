namespace Sql_Interactor
{
    partial class Add_Client
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
            label2 = new Label();
            label3 = new Label();
            textBox_Client_First_Name = new TextBox();
            label4 = new Label();
            textBox_Client_Last_Name = new TextBox();
            textBox_Client_Id_Number = new TextBox();
            textBox_Declared_Income = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox_Postal_Code = new TextBox();
            button_See_Registered_Postal_Codes = new Button();
            button_Add_Client = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 29);
            label1.Name = "label1";
            label1.Size = new Size(249, 53);
            label1.TabIndex = 0;
            label1.Text = "Add Client";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 118);
            label2.Name = "label2";
            label2.Size = new Size(64, 14);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 170);
            label3.Name = "label3";
            label3.Size = new Size(159, 14);
            label3.TabIndex = 2;
            label3.Text = "Client Identification Number";
            // 
            // textBox_Client_First_Name
            // 
            textBox_Client_First_Name.Location = new Point(228, 118);
            textBox_Client_First_Name.Name = "textBox_Client_First_Name";
            textBox_Client_First_Name.Size = new Size(186, 21);
            textBox_Client_First_Name.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 121);
            label4.Name = "label4";
            label4.Size = new Size(64, 14);
            label4.TabIndex = 4;
            label4.Text = "Last Name";
            // 
            // textBox_Client_Last_Name
            // 
            textBox_Client_Last_Name.Location = new Point(503, 118);
            textBox_Client_Last_Name.Name = "textBox_Client_Last_Name";
            textBox_Client_Last_Name.Size = new Size(206, 21);
            textBox_Client_Last_Name.TabIndex = 5;
            // 
            // textBox_Client_Id_Number
            // 
            textBox_Client_Id_Number.Location = new Point(228, 167);
            textBox_Client_Id_Number.Name = "textBox_Client_Id_Number";
            textBox_Client_Id_Number.Size = new Size(132, 21);
            textBox_Client_Id_Number.TabIndex = 6;
            // 
            // textBox_Declared_Income
            // 
            textBox_Declared_Income.Location = new Point(481, 167);
            textBox_Declared_Income.Name = "textBox_Declared_Income";
            textBox_Declared_Income.Size = new Size(77, 21);
            textBox_Declared_Income.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(376, 170);
            label5.Name = "label5";
            label5.Size = new Size(99, 14);
            label5.TabIndex = 8;
            label5.Text = "Declared Income";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(151, 224);
            label6.Name = "label6";
            label6.Size = new Size(71, 14);
            label6.TabIndex = 9;
            label6.Text = "Postal Code";
            // 
            // textBox_Postal_Code
            // 
            textBox_Postal_Code.Location = new Point(228, 221);
            textBox_Postal_Code.Name = "textBox_Postal_Code";
            textBox_Postal_Code.Size = new Size(132, 21);
            textBox_Postal_Code.TabIndex = 10;
            // 
            // button_See_Registered_Postal_Codes
            // 
            button_See_Registered_Postal_Codes.Location = new Point(381, 216);
            button_See_Registered_Postal_Codes.Name = "button_See_Registered_Postal_Codes";
            button_See_Registered_Postal_Codes.Size = new Size(328, 29);
            button_See_Registered_Postal_Codes.TabIndex = 11;
            button_See_Registered_Postal_Codes.Text = "See Registered Postal Codes";
            button_See_Registered_Postal_Codes.UseVisualStyleBackColor = true;
            button_See_Registered_Postal_Codes.Click += button_See_Registered_Postal_Codes_Click;
            // 
            // button_Add_Client
            // 
            button_Add_Client.Location = new Point(354, 273);
            button_Add_Client.Name = "button_Add_Client";
            button_Add_Client.Size = new Size(94, 29);
            button_Add_Client.TabIndex = 12;
            button_Add_Client.Text = "Add client";
            button_Add_Client.UseVisualStyleBackColor = true;
            button_Add_Client.Click += button_Add_Client_Click;
            // 
            // Add_Client
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Add_Client);
            Controls.Add(button_See_Registered_Postal_Codes);
            Controls.Add(textBox_Postal_Code);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox_Declared_Income);
            Controls.Add(textBox_Client_Id_Number);
            Controls.Add(textBox_Client_Last_Name);
            Controls.Add(label4);
            Controls.Add(textBox_Client_First_Name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Add_Client";
            Text = "Add Client";
            Load += Add_Client_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_Client_First_Name;
        private Label label4;
        private TextBox textBox_Client_Last_Name;
        private TextBox textBox_Client_Id_Number;
        private TextBox textBox_Declared_Income;
        private Label label5;
        private Label label6;
        private TextBox textBox_Postal_Code;
        private Button button_See_Registered_Postal_Codes;
        private Button button_Add_Client;
    }
}