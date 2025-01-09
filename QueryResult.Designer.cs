namespace Sql_Interactor
{
    partial class QueryResult
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
            Data_grid_Query_Result = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Data_grid_Query_Result).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(307, 51);
            label1.Name = "label1";
            label1.Size = new Size(211, 45);
            label1.TabIndex = 0;
            label1.Text = "Query Result";
            // 
            // Data_grid_Query_Result
            // 
            Data_grid_Query_Result.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_grid_Query_Result.Location = new Point(58, 99);
            Data_grid_Query_Result.Name = "Data_grid_Query_Result";
            Data_grid_Query_Result.Size = new Size(690, 269);
            Data_grid_Query_Result.TabIndex = 1;
            // 
            // QueryResult
            // 
            FormClosing += QueryResult_Closing;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(Data_grid_Query_Result);
            Controls.Add(label1);
            Name = "QueryResult";
            Text = "Sql Interactor 2000 - Query Result";
            Load += QueryResult_Load;
            ((System.ComponentModel.ISupportInitialize)Data_grid_Query_Result).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView Data_grid_Query_Result;
    }
}