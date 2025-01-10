namespace Sql_Interactor
{
    partial class Regist_Car_Model
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
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            Add_Car_Model_Button = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(255, 66);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(272, 42);
            label2.TabIndex = 4;
            label2.Text = "Add Car Model";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(303, 214);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 23);
            comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 217);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 6;
            label3.Text = "Manufactor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 155);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 9;
            label1.Text = "Model Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(303, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 23);
            textBox1.TabIndex = 8;
            // 
            // Add_Car_Model_Button
            // 
            Add_Car_Model_Button.Location = new Point(619, 383);
            Add_Car_Model_Button.Name = "Add_Car_Model_Button";
            Add_Car_Model_Button.Size = new Size(141, 36);
            Add_Car_Model_Button.TabIndex = 10;
            Add_Car_Model_Button.Text = "Add Car Model";
            Add_Car_Model_Button.UseVisualStyleBackColor = true;
            Add_Car_Model_Button.Click += Add_Car_Model_Button_Click;
            // 
            // Regist_Car_Model
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Add_Car_Model_Button);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Regist_Car_Model";
            Text = "Regist_Car_Model";
            Load += Regist_Car_Model_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label1;
        private TextBox textBox1;
        private Button Add_Car_Model_Button;
    }
}