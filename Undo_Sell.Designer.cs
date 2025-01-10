namespace Sql_Interactor
{
    partial class Undo_Sell
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(70, 151);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 1;
            label1.Text = "Sell ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(70, 237);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 2;
            label2.Text = "CarPlate";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 237);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 27);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(498, 156);
            label4.Name = "label4";
            label4.Size = new Size(69, 32);
            label4.TabIndex = 6;
            label4.Text = "Store";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(598, 160);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 28);
            comboBox1.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(598, 238);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(163, 27);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(407, 232);
            label5.Name = "label5";
            label5.Size = new Size(160, 32);
            label5.TabIndex = 9;
            label5.Text = "Costumer NIF";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(441, 338);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(163, 27);
            textBox5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(299, 333);
            label6.Name = "label6";
            label6.Size = new Size(83, 32);
            label6.TabIndex = 11;
            label6.Text = "Dealer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(329, 39);
            label7.Name = "label7";
            label7.Size = new Size(202, 54);
            label7.TabIndex = 12;
            label7.Text = "Undo Sell";
            // 
            // button1
            // 
            button1.Location = new Point(713, 466);
            button1.Name = "button1";
            button1.Size = new Size(165, 46);
            button1.TabIndex = 13;
            button1.Text = "Undo Sell";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Undo_Sell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 524);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Undo_Sell";
            Text = "Undo_Sell";
            Load += Undo_Sell_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}