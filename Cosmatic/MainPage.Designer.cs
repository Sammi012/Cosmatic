namespace Cosmatic
{
    partial class MainPage
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dashboardMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.alertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.returnsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityAndAuditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupAndRecoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.shortCutToolMenu = new System.Windows.Forms.ToolStrip();
            this.tsSale = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsPayment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsPurchase = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.shortCutToolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardMenu,
            this.userManagementToolStripMenuItem,
            this.viewMenu,
            this.inventoryControlToolStripMenuItem,
            this.toolsMenu,
            this.salesManagementToolStripMenuItem,
            this.reportsMenu,
            this.securityAndAuditToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.reportsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1151, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // dashboardMenu
            // 
            this.dashboardMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.dashboardMenu.Name = "dashboardMenu";
            this.dashboardMenu.Size = new System.Drawing.Size(76, 20);
            this.dashboardMenu.Text = "&Dashboard";
            this.dashboardMenu.Click += new System.EventHandler(this.dashboardMenu_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.roleToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.userManagementToolStripMenuItem.Text = "&User Management";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.userToolStripMenuItem.Text = "&User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click_1);
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.roleToolStripMenuItem.Text = "&Role";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.generationToolStripMenuItem,
            this.managementToolStripMenuItem1});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(135, 20);
            this.viewMenu.Text = "&Product Management";
            // 
            // catalogToolStripMenuItem
            // 
            this.catalogToolStripMenuItem.Name = "catalogToolStripMenuItem";
            this.catalogToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.catalogToolStripMenuItem.Text = "&Catalog";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.managementToolStripMenuItem.Text = "&Catagories";
            // 
            // generationToolStripMenuItem
            // 
            this.generationToolStripMenuItem.Name = "generationToolStripMenuItem";
            this.generationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.generationToolStripMenuItem.Text = "&Barcode Generation";
            // 
            // managementToolStripMenuItem1
            // 
            this.managementToolStripMenuItem1.Name = "managementToolStripMenuItem1";
            this.managementToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.managementToolStripMenuItem1.Text = "&Pricing Management";
            // 
            // inventoryControlToolStripMenuItem
            // 
            this.inventoryControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem2,
            this.alertsToolStripMenuItem,
            this.managementToolStripMenuItem3,
            this.adjustmentToolStripMenuItem});
            this.inventoryControlToolStripMenuItem.Name = "inventoryControlToolStripMenuItem";
            this.inventoryControlToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryControlToolStripMenuItem.Text = "&Inventory";
            // 
            // managementToolStripMenuItem2
            // 
            this.managementToolStripMenuItem2.Name = "managementToolStripMenuItem2";
            this.managementToolStripMenuItem2.Size = new System.Drawing.Size(178, 22);
            this.managementToolStripMenuItem2.Text = "&Stock Management";
            // 
            // alertsToolStripMenuItem
            // 
            this.alertsToolStripMenuItem.Name = "alertsToolStripMenuItem";
            this.alertsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.alertsToolStripMenuItem.Text = "&Reorder Alerts";
            // 
            // managementToolStripMenuItem3
            // 
            this.managementToolStripMenuItem3.Name = "managementToolStripMenuItem3";
            this.managementToolStripMenuItem3.Size = new System.Drawing.Size(178, 22);
            this.managementToolStripMenuItem3.Text = "&Batch Management";
            // 
            // adjustmentToolStripMenuItem
            // 
            this.adjustmentToolStripMenuItem.Name = "adjustmentToolStripMenuItem";
            this.adjustmentToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.adjustmentToolStripMenuItem.Text = "&Stock Adjustment";
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.paymentsToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(136, 20);
            this.toolsMenu.Text = "&Supplier Management";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.databaseToolStripMenuItem.Text = "&Registration";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ordersToolStripMenuItem.Text = "&Purchase Orders";
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.paymentsToolStripMenuItem.Text = "&Payments";
            // 
            // salesManagementToolStripMenuItem
            // 
            this.salesManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionsToolStripMenuItem1,
            this.receiptsToolStripMenuItem1,
            this.returnsToolStripMenuItem1,
            this.customerToolStripMenuItem1});
            this.salesManagementToolStripMenuItem.Name = "salesManagementToolStripMenuItem";
            this.salesManagementToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.salesManagementToolStripMenuItem.Text = "&Sales Management";
            // 
            // transactionsToolStripMenuItem1
            // 
            this.transactionsToolStripMenuItem1.Name = "transactionsToolStripMenuItem1";
            this.transactionsToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.transactionsToolStripMenuItem1.Text = "&Sales Transactions";
            // 
            // receiptsToolStripMenuItem1
            // 
            this.receiptsToolStripMenuItem1.Name = "receiptsToolStripMenuItem1";
            this.receiptsToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.receiptsToolStripMenuItem1.Text = "&Sales Receipts";
            // 
            // returnsToolStripMenuItem1
            // 
            this.returnsToolStripMenuItem1.Name = "returnsToolStripMenuItem1";
            this.returnsToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.returnsToolStripMenuItem1.Text = "&Sales Returns";
            // 
            // customerToolStripMenuItem1
            // 
            this.customerToolStripMenuItem1.Name = "customerToolStripMenuItem1";
            this.customerToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.customerToolStripMenuItem1.Text = "&Customer Registration";
            // 
            // reportsMenu
            // 
            this.reportsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.reportsMenu.Name = "reportsMenu";
            this.reportsMenu.Size = new System.Drawing.Size(59, 20);
            this.reportsMenu.Text = "&Reports";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.newWindowToolStripMenuItem.Text = "&New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // securityAndAuditToolStripMenuItem
            // 
            this.securityAndAuditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trailsToolStripMenuItem,
            this.backupAndRecoveryToolStripMenuItem});
            this.securityAndAuditToolStripMenuItem.Name = "securityAndAuditToolStripMenuItem";
            this.securityAndAuditToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.securityAndAuditToolStripMenuItem.Text = " &Audit ";
            // 
            // trailsToolStripMenuItem
            // 
            this.trailsToolStripMenuItem.Name = "trailsToolStripMenuItem";
            this.trailsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.trailsToolStripMenuItem.Text = "&Trails";
            // 
            // backupAndRecoveryToolStripMenuItem
            // 
            this.backupAndRecoveryToolStripMenuItem.Name = "backupAndRecoveryToolStripMenuItem";
            this.backupAndRecoveryToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.backupAndRecoveryToolStripMenuItem.Text = "&Backup and Recovery";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUserName});
            this.statusStrip.Location = new System.Drawing.Point(0, 571);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1151, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            this.statusStrip.Visible = false;
            // 
            // toolUserName
            // 
            this.toolUserName.Name = "toolUserName";
            this.toolUserName.Size = new System.Drawing.Size(59, 17);
            this.toolUserName.Text = "username";
            // 
            // shortCutToolMenu
            // 
            this.shortCutToolMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.shortCutToolMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.shortCutToolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSale,
            this.toolStripSeparator2,
            this.tsPayment,
            this.toolStripSeparator3,
            this.tsPurchase});
            this.shortCutToolMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.shortCutToolMenu.Location = new System.Drawing.Point(0, 24);
            this.shortCutToolMenu.Name = "shortCutToolMenu";
            this.shortCutToolMenu.Size = new System.Drawing.Size(1151, 54);
            this.shortCutToolMenu.TabIndex = 4;
            this.shortCutToolMenu.Text = "shortCutToolMenu";
            // 
            // tsSale
            // 
            this.tsSale.Image = global::Cosmatic.Properties.Resources.sale_tag;
            this.tsSale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSale.Name = "tsSale";
            this.tsSale.Size = new System.Drawing.Size(59, 51);
            this.tsSale.Text = "&New Sale";
            this.tsSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // tsPayment
            // 
            this.tsPayment.Image = global::Cosmatic.Properties.Resources.coins;
            this.tsPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPayment.Name = "tsPayment";
            this.tsPayment.Size = new System.Drawing.Size(63, 51);
            this.tsPayment.Text = "&Payments";
            this.tsPayment.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsPayment.ToolTipText = "Payments";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // tsPurchase
            // 
            this.tsPurchase.Image = global::Cosmatic.Properties.Resources.buy_button;
            this.tsPurchase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPurchase.Name = "tsPurchase";
            this.tsPurchase.Size = new System.Drawing.Size(59, 51);
            this.tsPurchase.Text = "&Purchase";
            this.tsPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsPurchase.ToolTipText = "Purchase";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1151, 593);
            this.Controls.Add(this.shortCutToolMenu);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.shortCutToolMenu.ResumeLayout(false);
            this.shortCutToolMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolUserName;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem reportsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem receiptsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem returnsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inventoryControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem alertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem adjustmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityAndAuditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupAndRecoveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardMenu;
        private System.Windows.Forms.ToolStrip shortCutToolMenu;
        private System.Windows.Forms.ToolStripButton tsSale;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsPayment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsPurchase;
    }
}



