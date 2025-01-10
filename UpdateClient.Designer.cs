namespace Sql_Interactor
{
    partial class UpdateClient
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
            textBox_Client_Id_Number = new TextBox();
            label3 = new Label();
            textBox_First_Name = new TextBox();
            label4 = new Label();
            textBox_Last_Name = new TextBox();
            comboBox_Country = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            textBox_Income = new TextBox();
            label7 = new Label();
            comboBox_Postal_Code = new ComboBox();
            button_Search = new Button();
            button_Save = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 37);
            label1.Name = "label1";
            label1.Size = new Size(366, 48);
            label1.TabIndex = 0;
            label1.Text = "Update customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 170);
            label2.Name = "label2";
            label2.Size = new Size(181, 14);
            label2.TabIndex = 1;
            label2.Text = "Customer Identification Number";
            // 
            // textBox_Client_Id_Number
            // 
            textBox_Client_Id_Number.Location = new Point(214, 167);
            textBox_Client_Id_Number.Name = "textBox_Client_Id_Number";
            textBox_Client_Id_Number.Size = new Size(125, 21);
            textBox_Client_Id_Number.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 222);
            label3.Name = "label3";
            label3.Size = new Size(64, 14);
            label3.TabIndex = 3;
            label3.Text = "First Name";
            // 
            // textBox_First_Name
            // 
            textBox_First_Name.Location = new Point(214, 222);
            textBox_First_Name.Name = "textBox_First_Name";
            textBox_First_Name.Size = new Size(125, 21);
            textBox_First_Name.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 259);
            label4.Name = "label4";
            label4.Size = new Size(64, 14);
            label4.TabIndex = 5;
            label4.Text = "Last Name";
            // 
            // textBox_Last_Name
            // 
            textBox_Last_Name.Location = new Point(214, 259);
            textBox_Last_Name.Name = "textBox_Last_Name";
            textBox_Last_Name.Size = new Size(125, 21);
            textBox_Last_Name.TabIndex = 6;
            // 
            // comboBox_Country
            // 
            comboBox_Country.FormattingEnabled = true;
            comboBox_Country.Location = new Point(542, 160);
            comboBox_Country.Name = "comboBox_Country";
            comboBox_Country.Size = new Size(151, 21);
            comboBox_Country.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 163);
            label5.Name = "label5";
            label5.Size = new Size(50, 14);
            label5.TabIndex = 8;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(465, 222);
            label6.Name = "label6";
            label6.Size = new Size(71, 14);
            label6.TabIndex = 9;
            label6.Text = "Postal Code";
            // 
            // textBox_Income
            // 
            textBox_Income.Location = new Point(214, 297);
            textBox_Income.Name = "textBox_Income";
            textBox_Income.Size = new Size(125, 21);
            textBox_Income.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(145, 300);
            label7.Name = "label7";
            label7.Size = new Size(48, 14);
            label7.TabIndex = 11;
            label7.Text = "Income";
            // 
            // comboBox_Postal_Code
            // 
            comboBox_Postal_Code.FormattingEnabled = true;
            comboBox_Postal_Code.Location = new Point(542, 222);
            comboBox_Postal_Code.Name = "comboBox_Postal_Code";
            comboBox_Postal_Code.Size = new Size(151, 21);
            comboBox_Postal_Code.TabIndex = 12;
            // 
            // button_Search
            // 
            button_Search.Location = new Point(358, 163);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(94, 29);
            button_Search.TabIndex = 13;
            button_Search.Text = "Search";
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // button_Save
            // 
            button_Save.Location = new Point(358, 354);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(94, 29);
            button_Save.TabIndex = 14;
            button_Save.Text = "Save";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // UpdateClient
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Save);
            Controls.Add(button_Search);
            Controls.Add(comboBox_Postal_Code);
            Controls.Add(label7);
            Controls.Add(textBox_Income);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox_Country);
            Controls.Add(textBox_Last_Name);
            Controls.Add(label4);
            Controls.Add(textBox_First_Name);
            Controls.Add(label3);
            Controls.Add(textBox_Client_Id_Number);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateClient";
            Text = "Sql Interactor 2000 - Update Client";
            Load += UpdateClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_Client_Id_Number;
        private Label label3;
        private TextBox textBox_First_Name;
        private Label label4;
        private TextBox textBox_Last_Name;
        private ComboBox comboBox_Country;
        private Label label5;
        private Label label6;
        private TextBox textBox_Income;
        private Label label7;
        private ComboBox comboBox_Postal_Code;
        private Button button_Search;
        private Button button_Save;
    }
}