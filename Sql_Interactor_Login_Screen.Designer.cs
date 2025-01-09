namespace Sql_Interactor
{
    partial class Sql_Interactor_Login_Screen
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
            button_Login = new Button();
            button_Clear_Text = new Button();
            textBox_Password = new TextBox();
            textBox_User_Id = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button_Login
            // 
            button_Login.Location = new Point(411, 251);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(75, 23);
            button_Login.TabIndex = 0;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // button_Clear_Text
            // 
            button_Clear_Text.Location = new Point(330, 251);
            button_Clear_Text.Name = "button_Clear_Text";
            button_Clear_Text.Size = new Size(75, 23);
            button_Clear_Text.TabIndex = 1;
            button_Clear_Text.Text = "Clear";
            button_Clear_Text.UseVisualStyleBackColor = true;
            button_Clear_Text.Click += button_Clear_Text_Click;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(330, 206);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(156, 23);
            textBox_Password.TabIndex = 2;
            // 
            // textBox_User_Id
            // 
            textBox_User_Id.Location = new Point(330, 177);
            textBox_User_Id.Name = "textBox_User_Id";
            textBox_User_Id.Size = new Size(156, 23);
            textBox_User_Id.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(328, 97);
            label1.Name = "label1";
            label1.Size = new Size(158, 45);
            label1.TabIndex = 4;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 180);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "User Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 209);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // Sql_Interactor_Login_Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_User_Id);
            Controls.Add(textBox_Password);
            Controls.Add(button_Clear_Text);
            Controls.Add(button_Login);
            Name = "Sql_Interactor_Login_Screen";
            Text = "Sql Interactor 2000";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Login;
        private Button button_Clear_Text;
        private TextBox textBox_Password;
        private TextBox textBox_User_Id;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}