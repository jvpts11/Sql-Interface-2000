namespace Sql_Interactor
{
    partial class SearchSell
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
            label4 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(86, 164);
            label1.Name = "label1";
            label1.Size = new Size(101, 32);
            label1.TabIndex = 0;
            label1.Text = "CarPlate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(34, 285);
            label2.Name = "label2";
            label2.Size = new Size(153, 32);
            label2.TabIndex = 1;
            label2.Text = "CostumerNIF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(469, 164);
            label3.Name = "label3";
            label3.Size = new Size(69, 32);
            label3.TabIndex = 2;
            label3.Text = "Store";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(456, 280);
            label4.Name = "label4";
            label4.Size = new Size(82, 32);
            label4.TabIndex = 3;
            label4.Text = "Sell ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(216, 285);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(568, 285);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(173, 27);
            textBox4.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(568, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 28);
            comboBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(284, 27);
            label5.Name = "label5";
            label5.Size = new Size(254, 50);
            label5.TabIndex = 9;
            label5.Text = "SEARCH SELL";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(343, 374);
            button1.Name = "button1";
            button1.Size = new Size(137, 47);
            button1.TabIndex = 10;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SearchSell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SearchSell";
            Text = "SearchSell";
            Load += SearchSell_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Label label5;
        private Button button1;
    }
}