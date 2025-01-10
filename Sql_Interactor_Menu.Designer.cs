namespace Sql_Interactor
{
    partial class Sql_Interactor_Menu
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
            Label_Welcome = new Label();
            MenuStrip_Main_Menu = new MenuStrip();
            Item_Program = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            clientToolStripMenuItem = new ToolStripMenuItem();
            clientAddToolStripMenuItem = new ToolStripMenuItem();
            clientSearchToolStripMenuItem = new ToolStripMenuItem();
            clientDeleteToolStripMenuItem = new ToolStripMenuItem();
            clientSearchByToolStripMenuItem3 = new ToolStripMenuItem();
            clientUpdateDataToolStripMenuItem = new ToolStripMenuItem();
            carToolStripMenuItem = new ToolStripMenuItem();
            carRegisterToolStripMenuItem = new ToolStripMenuItem();
            carAddModelToolStripMenuItem = new ToolStripMenuItem();
            carSearchByToolStripMenuItem = new ToolStripMenuItem();
            batchToolStripMenuItem = new ToolStripMenuItem();
            batchRegisterToolStripMenuItem = new ToolStripMenuItem();
            batchSearchBatchToolStripMenuItem = new ToolStripMenuItem();
            sellToolStripMenuItem = new ToolStripMenuItem();
            sellPerformSellToolStripMenuItem = new ToolStripMenuItem();
            sellUndoSellToolStripMenuItem = new ToolStripMenuItem();
            sellSearchSellToolStripMenuItem = new ToolStripMenuItem();
            transportationToolStripMenuItem = new ToolStripMenuItem();
            transportationRegisterTransportToolStripMenuItem = new ToolStripMenuItem();
            transportationRegisterEntryToolStripMenuItem = new ToolStripMenuItem();
            transportationListEntriesToolStripMenuItem = new ToolStripMenuItem();
            transportationSearchToolStripMenuItem = new ToolStripMenuItem();
            transportUpdateDataToolStripMenuItem = new ToolStripMenuItem();
            warehousesToolStripMenuItem = new ToolStripMenuItem();
            warehousesAddToolStripMenuItem = new ToolStripMenuItem();
            storesToolStripMenuItem = new ToolStripMenuItem();
            storesAddToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            employeeAddToolStripMenuItem = new ToolStripMenuItem();
            employeeDeleteToolStripMenuItem = new ToolStripMenuItem();
            employeeListToolStripMenuItem = new ToolStripMenuItem();
            employeeSearchByToolStripMenuItem = new ToolStripMenuItem();
            employeeUpdateDataToolStripMenuItem = new ToolStripMenuItem();
            projectToolStripMenuItem = new ToolStripMenuItem();
            projectAddToolStripMenuItem = new ToolStripMenuItem();
            projectListToolStripMenuItem = new ToolStripMenuItem();
            projectSearchByToolStripMenuItem = new ToolStripMenuItem();
            projectUpdateDataToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            Button_See_Sells = new Button();
            Button_See_Clients = new Button();
            Button_Insurance = new Button();
            Button_Simulations = new Button();
            label2 = new Label();
            Button_See_Manufacturers = new Button();
            Button_See_Stores = new Button();
            Data_grid_Menu = new DataGridView();
            panel1 = new Panel();
            label_Table_Name = new Label();
            MenuStrip_Main_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Data_grid_Menu).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Label_Welcome
            // 
            Label_Welcome.AutoSize = true;
            Label_Welcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Welcome.Location = new Point(227, 33);
            Label_Welcome.Name = "Label_Welcome";
            Label_Welcome.Size = new Size(324, 41);
            Label_Welcome.TabIndex = 1;
            Label_Welcome.Text = "Welcome (name here)";
            // 
            // MenuStrip_Main_Menu
            // 
            MenuStrip_Main_Menu.ImageScalingSize = new Size(20, 20);
            MenuStrip_Main_Menu.Items.AddRange(new ToolStripItem[] { Item_Program, clientToolStripMenuItem, carToolStripMenuItem, batchToolStripMenuItem, sellToolStripMenuItem, transportationToolStripMenuItem, warehousesToolStripMenuItem, storesToolStripMenuItem, employeeToolStripMenuItem, projectToolStripMenuItem });
            MenuStrip_Main_Menu.Location = new Point(0, 0);
            MenuStrip_Main_Menu.Name = "MenuStrip_Main_Menu";
            MenuStrip_Main_Menu.Padding = new Padding(5, 2, 0, 2);
            MenuStrip_Main_Menu.Size = new Size(686, 28);
            MenuStrip_Main_Menu.TabIndex = 2;
            MenuStrip_Main_Menu.Text = "menuStrip1";
            // 
            // Item_Program
            // 
            Item_Program.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, exitToolStripMenuItem });
            Item_Program.Name = "Item_Program";
            Item_Program.Size = new Size(66, 24);
            Item_Program.Text = "Program";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(134, 26);
            aboutToolStripMenuItem.Text = "About...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(134, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // clientToolStripMenuItem
            // 
            clientToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientAddToolStripMenuItem, clientSearchToolStripMenuItem, clientDeleteToolStripMenuItem, clientSearchByToolStripMenuItem3, clientUpdateDataToolStripMenuItem });
            clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            clientToolStripMenuItem.Size = new Size(73, 24);
            clientToolStripMenuItem.Text = "Customer";
            // 
            // clientAddToolStripMenuItem
            // 
            clientAddToolStripMenuItem.Name = "clientAddToolStripMenuItem";
            clientAddToolStripMenuItem.Size = new Size(224, 26);
            clientAddToolStripMenuItem.Text = "Add";
            clientAddToolStripMenuItem.Click += clientAddToolStripMenuItem_Click;
            // 
            // clientSearchToolStripMenuItem
            // 
            clientSearchToolStripMenuItem.Name = "clientSearchToolStripMenuItem";
            clientSearchToolStripMenuItem.Size = new Size(224, 26);
            clientSearchToolStripMenuItem.Text = "Search";
            // 
            // clientDeleteToolStripMenuItem
            // 
            clientDeleteToolStripMenuItem.Name = "clientDeleteToolStripMenuItem";
            clientDeleteToolStripMenuItem.Size = new Size(224, 26);
            clientDeleteToolStripMenuItem.Text = "Delete";
            clientDeleteToolStripMenuItem.Click += clientDeleteToolStripMenuItem_Click;
            // 
            // clientSearchByToolStripMenuItem3
            // 
            clientSearchByToolStripMenuItem3.Name = "clientSearchByToolStripMenuItem3";
            clientSearchByToolStripMenuItem3.Size = new Size(224, 26);
            clientSearchByToolStripMenuItem3.Text = "Search by...";
            clientSearchByToolStripMenuItem3.Click += clientSearchByToolStripMenuItem3_Click;
            // 
            // clientUpdateDataToolStripMenuItem
            // 
            clientUpdateDataToolStripMenuItem.Name = "clientUpdateDataToolStripMenuItem";
            clientUpdateDataToolStripMenuItem.Size = new Size(224, 26);
            clientUpdateDataToolStripMenuItem.Text = "Update Customer Data";
            clientUpdateDataToolStripMenuItem.Click += clientUpdateDataToolStripMenuItem_Click;
            // 
            // carToolStripMenuItem
            // 
            carToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { carRegisterToolStripMenuItem, carAddModelToolStripMenuItem, carSearchByToolStripMenuItem });
            carToolStripMenuItem.Name = "carToolStripMenuItem";
            carToolStripMenuItem.Size = new Size(38, 24);
            carToolStripMenuItem.Text = "Car";
            // 
            // carRegisterToolStripMenuItem
            // 
            carRegisterToolStripMenuItem.Name = "carRegisterToolStripMenuItem";
            carRegisterToolStripMenuItem.Size = new Size(154, 26);
            carRegisterToolStripMenuItem.Text = "Register";
            // 
            // carAddModelToolStripMenuItem
            // 
            carAddModelToolStripMenuItem.Name = "carAddModelToolStripMenuItem";
            carAddModelToolStripMenuItem.Size = new Size(154, 26);
            carAddModelToolStripMenuItem.Text = "Add Model";
            // 
            // carSearchByToolStripMenuItem
            // 
            carSearchByToolStripMenuItem.Name = "carSearchByToolStripMenuItem";
            carSearchByToolStripMenuItem.Size = new Size(154, 26);
            carSearchByToolStripMenuItem.Text = "Search by...";
            // 
            // batchToolStripMenuItem
            // 
            batchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { batchRegisterToolStripMenuItem, batchSearchBatchToolStripMenuItem });
            batchToolStripMenuItem.Name = "batchToolStripMenuItem";
            batchToolStripMenuItem.Size = new Size(52, 24);
            batchToolStripMenuItem.Text = "Batch";
            // 
            // batchRegisterToolStripMenuItem
            // 
            batchRegisterToolStripMenuItem.Name = "batchRegisterToolStripMenuItem";
            batchRegisterToolStripMenuItem.Size = new Size(154, 26);
            batchRegisterToolStripMenuItem.Text = "Register";
            // 
            // batchSearchBatchToolStripMenuItem
            // 
            batchSearchBatchToolStripMenuItem.Name = "batchSearchBatchToolStripMenuItem";
            batchSearchBatchToolStripMenuItem.Size = new Size(154, 26);
            batchSearchBatchToolStripMenuItem.Text = "Search By...";
            // 
            // sellToolStripMenuItem
            // 
            sellToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sellPerformSellToolStripMenuItem, sellUndoSellToolStripMenuItem, sellSearchSellToolStripMenuItem });
            sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            sellToolStripMenuItem.Size = new Size(39, 24);
            sellToolStripMenuItem.Text = "Sell";
            // 
            // sellPerformSellToolStripMenuItem
            // 
            sellPerformSellToolStripMenuItem.Name = "sellPerformSellToolStripMenuItem";
            sellPerformSellToolStripMenuItem.Size = new Size(154, 26);
            sellPerformSellToolStripMenuItem.Text = "Perform Sell";
            // 
            // sellUndoSellToolStripMenuItem
            // 
            sellUndoSellToolStripMenuItem.Name = "sellUndoSellToolStripMenuItem";
            sellUndoSellToolStripMenuItem.Size = new Size(154, 26);
            sellUndoSellToolStripMenuItem.Text = "Undo Sell";
            // 
            // sellSearchSellToolStripMenuItem
            // 
            sellSearchSellToolStripMenuItem.Name = "sellSearchSellToolStripMenuItem";
            sellSearchSellToolStripMenuItem.Size = new Size(154, 26);
            sellSearchSellToolStripMenuItem.Text = "Search by...";
            // 
            // transportationToolStripMenuItem
            // 
            transportationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { transportationRegisterTransportToolStripMenuItem, transportationRegisterEntryToolStripMenuItem, transportationListEntriesToolStripMenuItem, transportationSearchToolStripMenuItem, transportUpdateDataToolStripMenuItem });
            transportationToolStripMenuItem.Name = "transportationToolStripMenuItem";
            transportationToolStripMenuItem.Size = new Size(101, 24);
            transportationToolStripMenuItem.Text = "Transportation";
            // 
            // transportationRegisterTransportToolStripMenuItem
            // 
            transportationRegisterTransportToolStripMenuItem.Name = "transportationRegisterTransportToolStripMenuItem";
            transportationRegisterTransportToolStripMenuItem.Size = new Size(214, 26);
            transportationRegisterTransportToolStripMenuItem.Text = "Register Transport";
            // 
            // transportationRegisterEntryToolStripMenuItem
            // 
            transportationRegisterEntryToolStripMenuItem.Name = "transportationRegisterEntryToolStripMenuItem";
            transportationRegisterEntryToolStripMenuItem.Size = new Size(214, 26);
            transportationRegisterEntryToolStripMenuItem.Text = "Register Entry";
            // 
            // transportationListEntriesToolStripMenuItem
            // 
            transportationListEntriesToolStripMenuItem.Name = "transportationListEntriesToolStripMenuItem";
            transportationListEntriesToolStripMenuItem.Size = new Size(214, 26);
            transportationListEntriesToolStripMenuItem.Text = "List Entries";
            // 
            // transportationSearchToolStripMenuItem
            // 
            transportationSearchToolStripMenuItem.Name = "transportationSearchToolStripMenuItem";
            transportationSearchToolStripMenuItem.Size = new Size(214, 26);
            transportationSearchToolStripMenuItem.Text = "Search...";
            // 
            // transportUpdateDataToolStripMenuItem
            // 
            transportUpdateDataToolStripMenuItem.Name = "transportUpdateDataToolStripMenuItem";
            transportUpdateDataToolStripMenuItem.Size = new Size(214, 26);
            transportUpdateDataToolStripMenuItem.Text = "Update Transport Data";
            // 
            // warehousesToolStripMenuItem
            // 
            warehousesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { warehousesAddToolStripMenuItem });
            warehousesToolStripMenuItem.Name = "warehousesToolStripMenuItem";
            warehousesToolStripMenuItem.Size = new Size(88, 24);
            warehousesToolStripMenuItem.Text = "Warehouses";
            // 
            // warehousesAddToolStripMenuItem
            // 
            warehousesAddToolStripMenuItem.Name = "warehousesAddToolStripMenuItem";
            warehousesAddToolStripMenuItem.Size = new Size(110, 26);
            warehousesAddToolStripMenuItem.Text = "Add";
            // 
            // storesToolStripMenuItem
            // 
            storesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { storesAddToolStripMenuItem });
            storesToolStripMenuItem.Name = "storesToolStripMenuItem";
            storesToolStripMenuItem.Size = new Size(56, 24);
            storesToolStripMenuItem.Text = "Stores";
            // 
            // storesAddToolStripMenuItem
            // 
            storesAddToolStripMenuItem.Name = "storesAddToolStripMenuItem";
            storesAddToolStripMenuItem.Size = new Size(110, 26);
            storesAddToolStripMenuItem.Text = "Add";
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeeAddToolStripMenuItem, employeeDeleteToolStripMenuItem, employeeListToolStripMenuItem, employeeSearchByToolStripMenuItem, employeeUpdateDataToolStripMenuItem });
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(74, 24);
            employeeToolStripMenuItem.Text = "Employee";
            // 
            // employeeAddToolStripMenuItem
            // 
            employeeAddToolStripMenuItem.Name = "employeeAddToolStripMenuItem";
            employeeAddToolStripMenuItem.Size = new Size(214, 26);
            employeeAddToolStripMenuItem.Text = "Add";
            // 
            // employeeDeleteToolStripMenuItem
            // 
            employeeDeleteToolStripMenuItem.Name = "employeeDeleteToolStripMenuItem";
            employeeDeleteToolStripMenuItem.Size = new Size(214, 26);
            employeeDeleteToolStripMenuItem.Text = "Delete";
            // 
            // employeeListToolStripMenuItem
            // 
            employeeListToolStripMenuItem.Name = "employeeListToolStripMenuItem";
            employeeListToolStripMenuItem.Size = new Size(214, 26);
            employeeListToolStripMenuItem.Text = "List";
            // 
            // employeeSearchByToolStripMenuItem
            // 
            employeeSearchByToolStripMenuItem.Name = "employeeSearchByToolStripMenuItem";
            employeeSearchByToolStripMenuItem.Size = new Size(214, 26);
            employeeSearchByToolStripMenuItem.Text = "Search by...";
            // 
            // employeeUpdateDataToolStripMenuItem
            // 
            employeeUpdateDataToolStripMenuItem.Name = "employeeUpdateDataToolStripMenuItem";
            employeeUpdateDataToolStripMenuItem.Size = new Size(214, 26);
            employeeUpdateDataToolStripMenuItem.Text = "Update Employee Data";
            // 
            // projectToolStripMenuItem
            // 
            projectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { projectAddToolStripMenuItem, projectListToolStripMenuItem, projectSearchByToolStripMenuItem, projectUpdateDataToolStripMenuItem });
            projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            projectToolStripMenuItem.Size = new Size(60, 24);
            projectToolStripMenuItem.Text = "Project";
            // 
            // projectAddToolStripMenuItem
            // 
            projectAddToolStripMenuItem.Name = "projectAddToolStripMenuItem";
            projectAddToolStripMenuItem.Size = new Size(200, 26);
            projectAddToolStripMenuItem.Text = "Add";
            // 
            // projectListToolStripMenuItem
            // 
            projectListToolStripMenuItem.Name = "projectListToolStripMenuItem";
            projectListToolStripMenuItem.Size = new Size(200, 26);
            projectListToolStripMenuItem.Text = "List";
            // 
            // projectSearchByToolStripMenuItem
            // 
            projectSearchByToolStripMenuItem.Name = "projectSearchByToolStripMenuItem";
            projectSearchByToolStripMenuItem.Size = new Size(200, 26);
            projectSearchByToolStripMenuItem.Text = "Search by...";
            // 
            // projectUpdateDataToolStripMenuItem
            // 
            projectUpdateDataToolStripMenuItem.Name = "projectUpdateDataToolStripMenuItem";
            projectUpdateDataToolStripMenuItem.Size = new Size(200, 26);
            projectUpdateDataToolStripMenuItem.Text = "Update Project Data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 48);
            label1.Name = "label1";
            label1.Size = new Size(81, 14);
            label1.TabIndex = 4;
            label1.Text = "Quick Actions";
            // 
            // Button_See_Sells
            // 
            Button_See_Sells.Location = new Point(10, 80);
            Button_See_Sells.Name = "Button_See_Sells";
            Button_See_Sells.Size = new Size(90, 55);
            Button_See_Sells.TabIndex = 5;
            Button_See_Sells.Text = "See Sells";
            Button_See_Sells.UseVisualStyleBackColor = true;
            Button_See_Sells.Click += Button_See_Sells_Click;
            // 
            // Button_See_Clients
            // 
            Button_See_Clients.Location = new Point(105, 80);
            Button_See_Clients.Name = "Button_See_Clients";
            Button_See_Clients.Size = new Size(84, 55);
            Button_See_Clients.TabIndex = 6;
            Button_See_Clients.Text = "See Clients";
            Button_See_Clients.UseVisualStyleBackColor = true;
            Button_See_Clients.Click += Button_See_Clients_Click;
            // 
            // Button_Insurance
            // 
            Button_Insurance.Location = new Point(10, 140);
            Button_Insurance.Name = "Button_Insurance";
            Button_Insurance.Size = new Size(90, 57);
            Button_Insurance.TabIndex = 7;
            Button_Insurance.Text = "See Insurance Contracts";
            Button_Insurance.UseVisualStyleBackColor = true;
            Button_Insurance.Click += Button_Insurance_Click;
            // 
            // Button_Simulations
            // 
            Button_Simulations.Location = new Point(105, 140);
            Button_Simulations.Name = "Button_Simulations";
            Button_Simulations.Size = new Size(84, 57);
            Button_Simulations.TabIndex = 8;
            Button_Simulations.Text = "See Simulations";
            Button_Simulations.UseVisualStyleBackColor = true;
            Button_Simulations.Click += Button_Simulations_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 61);
            label2.Name = "label2";
            label2.Size = new Size(137, 14);
            label2.TabIndex = 9;
            label2.Text = "What will we do today?";
            // 
            // Button_See_Manufacturers
            // 
            Button_See_Manufacturers.Location = new Point(10, 202);
            Button_See_Manufacturers.Name = "Button_See_Manufacturers";
            Button_See_Manufacturers.Size = new Size(90, 54);
            Button_See_Manufacturers.TabIndex = 10;
            Button_See_Manufacturers.Text = "See Manufacturers";
            Button_See_Manufacturers.UseVisualStyleBackColor = true;
            Button_See_Manufacturers.Click += Button_See_Manufacturers_Click;
            // 
            // Button_See_Stores
            // 
            Button_See_Stores.Location = new Point(105, 202);
            Button_See_Stores.Name = "Button_See_Stores";
            Button_See_Stores.Size = new Size(84, 54);
            Button_See_Stores.TabIndex = 11;
            Button_See_Stores.Text = "See Stores";
            Button_See_Stores.UseVisualStyleBackColor = true;
            Button_See_Stores.Click += Button_See_Stores_Click;
            // 
            // Data_grid_Menu
            // 
            Data_grid_Menu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data_grid_Menu.Location = new Point(227, 98);
            Data_grid_Menu.Name = "Data_grid_Menu";
            Data_grid_Menu.RowHeadersWidth = 51;
            Data_grid_Menu.Size = new Size(424, 249);
            Data_grid_Menu.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label_Table_Name);
            panel1.Location = new Point(227, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 19);
            panel1.TabIndex = 13;
            // 
            // label_Table_Name
            // 
            label_Table_Name.AutoSize = true;
            label_Table_Name.Location = new Point(189, 3);
            label_Table_Name.Name = "label_Table_Name";
            label_Table_Name.Size = new Size(0, 14);
            label_Table_Name.TabIndex = 0;
            // 
            // Sql_Interactor_Menu
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(686, 390);
            Controls.Add(panel1);
            Controls.Add(Data_grid_Menu);
            Controls.Add(Button_See_Stores);
            Controls.Add(Button_See_Manufacturers);
            Controls.Add(label2);
            Controls.Add(Button_Simulations);
            Controls.Add(Button_Insurance);
            Controls.Add(Button_See_Clients);
            Controls.Add(Button_See_Sells);
            Controls.Add(label1);
            Controls.Add(Label_Welcome);
            Controls.Add(MenuStrip_Main_Menu);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = MenuStrip_Main_Menu;
            Name = "Sql_Interactor_Menu";
            Text = "SQL Interactor 2000";
            FormClosing += Sql_Interactor_FormClosing;
            MenuStrip_Main_Menu.ResumeLayout(false);
            MenuStrip_Main_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Data_grid_Menu).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Label_Welcome;
        private MenuStrip MenuStrip_Main_Menu;
        private ToolStripMenuItem Item_Program;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem clientToolStripMenuItem;
        private ToolStripMenuItem clientAddToolStripMenuItem;
        private ToolStripMenuItem clientSearchToolStripMenuItem;
        private ToolStripMenuItem clientDeleteToolStripMenuItem;
        private ToolStripMenuItem carToolStripMenuItem;
        private ToolStripMenuItem carRegisterToolStripMenuItem;
        private ToolStripMenuItem batchToolStripMenuItem;
        private ToolStripMenuItem batchRegisterToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem sellToolStripMenuItem;
        private Button Button_See_Sells;
        private Button Button_See_Clients;
        private Button Button_Insurance;
        private Button Button_Simulations;
        private Label label2;
        private ToolStripMenuItem transportationToolStripMenuItem;
        private ToolStripMenuItem transportationRegisterTransportToolStripMenuItem;
        private ToolStripMenuItem transportationRegisterEntryToolStripMenuItem;
        private ToolStripMenuItem carAddModelToolStripMenuItem;
        private ToolStripMenuItem warehousesToolStripMenuItem;
        private ToolStripMenuItem storesToolStripMenuItem;
        private Button Button_See_Manufacturers;
        private Button Button_See_Stores;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem employeeAddToolStripMenuItem;
        private ToolStripMenuItem employeeDeleteToolStripMenuItem;
        private DataGridView Data_grid_Menu;
        private Panel panel1;
        private Label label_Table_Name;
        private ToolStripMenuItem clientSearchByToolStripMenuItem3;
        private ToolStripMenuItem carSearchByToolStripMenuItem;
        private ToolStripMenuItem batchSearchBatchToolStripMenuItem;
        private ToolStripMenuItem sellPerformSellToolStripMenuItem;
        private ToolStripMenuItem sellUndoSellToolStripMenuItem;
        private ToolStripMenuItem sellSearchSellToolStripMenuItem;
        private ToolStripMenuItem warehousesAddToolStripMenuItem;
        private ToolStripMenuItem storesAddToolStripMenuItem;
        private ToolStripMenuItem employeeListToolStripMenuItem;
        private ToolStripMenuItem employeeSearchByToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem projectAddToolStripMenuItem;
        private ToolStripMenuItem projectListToolStripMenuItem;
        private ToolStripMenuItem projectSearchByToolStripMenuItem;
        private ToolStripMenuItem transportationListEntriesToolStripMenuItem;
        private ToolStripMenuItem transportationSearchToolStripMenuItem;
        private ToolStripMenuItem clientUpdateDataToolStripMenuItem;
        private ToolStripMenuItem transportUpdateDataToolStripMenuItem;
        private ToolStripMenuItem employeeUpdateDataToolStripMenuItem;
        private ToolStripMenuItem projectUpdateDataToolStripMenuItem;
    }
}