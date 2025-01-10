namespace Sql_Interactor
{
    partial class CustomerSearchBy
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
            button_Search_By = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox_Customer_Id = new TextBox();
            label3 = new Label();
            textBox_First_Name = new TextBox();
            label4 = new Label();
            textBox_Last_Name = new TextBox();
            checkBox_First_Name_Has = new CheckBox();
            checkBox_Last_Name_Has = new CheckBox();
            comboBox_Country_Options = new ComboBox();
            label5 = new Label();
            comboBox_Postal_Code = new ComboBox();
            Postal = new Label();
            SuspendLayout();
            // 
            // button_Search_By
            // 
            button_Search_By.Location = new Point(357, 392);
            button_Search_By.Name = "button_Search_By";
            button_Search_By.Size = new Size(75, 23);
            button_Search_By.TabIndex = 0;
            button_Search_By.Text = "Search";
            button_Search_By.UseVisualStyleBackColor = true;
            button_Search_By.Click += button_Search_By_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 32);
            label1.Name = "label1";
            label1.Size = new Size(272, 45);
            label1.TabIndex = 1;
            label1.Text = "Search Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 146);
            label2.Name = "label2";
            label2.Size = new Size(179, 15);
            label2.TabIndex = 2;
            label2.Text = "Customer Identification Number";
            // 
            // textBox_Customer_Id
            // 
            textBox_Customer_Id.Location = new Point(222, 143);
            textBox_Customer_Id.Name = "textBox_Customer_Id";
            textBox_Customer_Id.Size = new Size(178, 23);
            textBox_Customer_Id.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 211);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 4;
            label3.Text = "First Name";
            // 
            // textBox_First_Name
            // 
            textBox_First_Name.Location = new Point(222, 208);
            textBox_First_Name.Name = "textBox_First_Name";
            textBox_First_Name.Size = new Size(178, 23);
            textBox_First_Name.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 249);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 6;
            label4.Text = "Last Name";
            // 
            // textBox_Last_Name
            // 
            textBox_Last_Name.Location = new Point(222, 246);
            textBox_Last_Name.Name = "textBox_Last_Name";
            textBox_Last_Name.Size = new Size(178, 23);
            textBox_Last_Name.TabIndex = 7;
            // 
            // checkBox_First_Name_Has
            // 
            checkBox_First_Name_Has.AutoSize = true;
            checkBox_First_Name_Has.Location = new Point(423, 210);
            checkBox_First_Name_Has.Name = "checkBox_First_Name_Has";
            checkBox_First_Name_Has.Size = new Size(106, 19);
            checkBox_First_Name_Has.TabIndex = 8;
            checkBox_First_Name_Has.Text = "First Name Has";
            checkBox_First_Name_Has.UseVisualStyleBackColor = true;
            // 
            // checkBox_Last_Name_Has
            // 
            checkBox_Last_Name_Has.AutoSize = true;
            checkBox_Last_Name_Has.Location = new Point(423, 245);
            checkBox_Last_Name_Has.Name = "checkBox_Last_Name_Has";
            checkBox_Last_Name_Has.Size = new Size(105, 19);
            checkBox_Last_Name_Has.TabIndex = 9;
            checkBox_Last_Name_Has.Text = "Last Name Has";
            checkBox_Last_Name_Has.UseVisualStyleBackColor = true;
            // 
            // comboBox_Country_Options
            // 
            comboBox_Country_Options.FormattingEnabled = true;
            comboBox_Country_Options.Location = new Point(578, 138);
            comboBox_Country_Options.Name = "comboBox_Country_Options";
            comboBox_Country_Options.Size = new Size(121, 23);
            comboBox_Country_Options.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(512, 143);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 11;
            label5.Text = "Country";
            // 
            // comboBox_Postal_Code
            // 
            comboBox_Postal_Code.FormattingEnabled = true;
            comboBox_Postal_Code.Location = new Point(578, 177);
            comboBox_Postal_Code.Name = "comboBox_Postal_Code";
            comboBox_Postal_Code.Size = new Size(121, 23);
            comboBox_Postal_Code.TabIndex = 12;
            // 
            // Postal
            // 
            Postal.AutoSize = true;
            Postal.Location = new Point(492, 180);
            Postal.Name = "Postal";
            Postal.Size = new Size(70, 15);
            Postal.TabIndex = 13;
            Postal.Text = "Postal Code";
            // 
            // CustomerSearchBy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Postal);
            Controls.Add(comboBox_Postal_Code);
            Controls.Add(label5);
            Controls.Add(comboBox_Country_Options);
            Controls.Add(checkBox_Last_Name_Has);
            Controls.Add(checkBox_First_Name_Has);
            Controls.Add(textBox_Last_Name);
            Controls.Add(label4);
            Controls.Add(textBox_First_Name);
            Controls.Add(label3);
            Controls.Add(textBox_Customer_Id);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Search_By);
            Name = "CustomerSearchBy";
            Text = "Sql Interactor 2000 - Search Customer";
            Load += CustomerSearchBy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Search_By;
        private Label label1;
        private Label label2;
        private TextBox textBox_Customer_Id;
        private Label label3;
        private TextBox textBox_First_Name;
        private Label label4;
        private TextBox textBox_Last_Name;
        private CheckBox checkBox_First_Name_Has;
        private CheckBox checkBox_Last_Name_Has;
        private ComboBox comboBox_Country_Options;
        private Label label5;
        private ComboBox comboBox_Postal_Code;
        private Label Postal;
    }
}