namespace UltraGamesStoreNoSteamNONONO
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            moneytoolStripMenuItem = new ToolStripMenuItem();
            MasterToolStripMenuItem = new ToolStripMenuItem();
            CreateToolStripMenuItem = new ToolStripMenuItem();
            CreatedToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPageMarket = new TabPage();
            tabControl2 = new TabControl();
            tabPageCatalog = new TabPage();
            marketPanel = new Panel();
            tabPageWanted = new TabPage();
            panelWanted = new Panel();
            tabPageBasket = new TabPage();
            panelBassket = new Panel();
            tabPageLibary = new TabPage();
            panelLibary = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageMarket.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPageCatalog.SuspendLayout();
            tabPageWanted.SuspendLayout();
            tabPageBasket.SuspendLayout();
            tabPageLibary.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem, ExitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(936, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { infoToolStripMenuItem, moneytoolStripMenuItem, MasterToolStripMenuItem, toolStripMenuItem1 });
            userToolStripMenuItem.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(12, 20);
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(214, 22);
            infoToolStripMenuItem.Text = "Информация об аккаунте";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // moneytoolStripMenuItem
            // 
            moneytoolStripMenuItem.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            moneytoolStripMenuItem.Name = "moneytoolStripMenuItem";
            moneytoolStripMenuItem.Size = new Size(214, 22);
            moneytoolStripMenuItem.Text = "Счет";
            moneytoolStripMenuItem.Click += moneytoolStripMenuItem_Click;
            // 
            // MasterToolStripMenuItem
            // 
            MasterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateToolStripMenuItem, CreatedToolStripMenuItem });
            MasterToolStripMenuItem.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MasterToolStripMenuItem.Name = "MasterToolStripMenuItem";
            MasterToolStripMenuItem.Size = new Size(214, 22);
            MasterToolStripMenuItem.Text = "Мастерская игр";
            // 
            // CreateToolStripMenuItem
            // 
            CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            CreateToolStripMenuItem.Size = new Size(180, 22);
            CreateToolStripMenuItem.Text = "Создать игру";
            CreateToolStripMenuItem.Click += CreateToolStripMenuItem_Click;
            // 
            // CreatedToolStripMenuItem
            // 
            CreatedToolStripMenuItem.Name = "CreatedToolStripMenuItem";
            CreatedToolStripMenuItem.Size = new Size(180, 22);
            CreatedToolStripMenuItem.Text = "Созданные игры";
            CreatedToolStripMenuItem.Click += CreatedToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(54, 20);
            ExitToolStripMenuItem.Text = "Выйти";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageMarket);
            tabControl1.Controls.Add(tabPageLibary);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(936, 835);
            tabControl1.TabIndex = 1;
            // 
            // tabPageMarket
            // 
            tabPageMarket.BackColor = SystemColors.Window;
            tabPageMarket.Controls.Add(tabControl2);
            tabPageMarket.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPageMarket.Location = new Point(4, 24);
            tabPageMarket.Name = "tabPageMarket";
            tabPageMarket.Padding = new Padding(3);
            tabPageMarket.Size = new Size(928, 807);
            tabPageMarket.TabIndex = 0;
            tabPageMarket.Text = "Магазин";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPageCatalog);
            tabControl2.Controls.Add(tabPageWanted);
            tabControl2.Controls.Add(tabPageBasket);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(3, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(922, 801);
            tabControl2.TabIndex = 0;
            // 
            // tabPageCatalog
            // 
            tabPageCatalog.Controls.Add(marketPanel);
            tabPageCatalog.Location = new Point(4, 24);
            tabPageCatalog.Name = "tabPageCatalog";
            tabPageCatalog.Padding = new Padding(3);
            tabPageCatalog.Size = new Size(914, 773);
            tabPageCatalog.TabIndex = 0;
            tabPageCatalog.Text = "Каталог";
            tabPageCatalog.UseVisualStyleBackColor = true;
            // 
            // marketPanel
            // 
            marketPanel.Dock = DockStyle.Fill;
            marketPanel.Location = new Point(3, 3);
            marketPanel.Name = "marketPanel";
            marketPanel.Size = new Size(908, 767);
            marketPanel.TabIndex = 1;
            // 
            // tabPageWanted
            // 
            tabPageWanted.Controls.Add(panelWanted);
            tabPageWanted.Location = new Point(4, 24);
            tabPageWanted.Name = "tabPageWanted";
            tabPageWanted.Padding = new Padding(3);
            tabPageWanted.Size = new Size(914, 773);
            tabPageWanted.TabIndex = 1;
            tabPageWanted.Text = "Список желаемоего";
            tabPageWanted.UseVisualStyleBackColor = true;
            // 
            // panelWanted
            // 
            panelWanted.Dock = DockStyle.Fill;
            panelWanted.Location = new Point(3, 3);
            panelWanted.Name = "panelWanted";
            panelWanted.Size = new Size(908, 767);
            panelWanted.TabIndex = 0;
            // 
            // tabPageBasket
            // 
            tabPageBasket.Controls.Add(panelBassket);
            tabPageBasket.Location = new Point(4, 24);
            tabPageBasket.Name = "tabPageBasket";
            tabPageBasket.Padding = new Padding(3);
            tabPageBasket.Size = new Size(914, 773);
            tabPageBasket.TabIndex = 2;
            tabPageBasket.Text = "Корзина";
            tabPageBasket.UseVisualStyleBackColor = true;
            // 
            // panelBassket
            // 
            panelBassket.Dock = DockStyle.Fill;
            panelBassket.Location = new Point(3, 3);
            panelBassket.Name = "panelBassket";
            panelBassket.Size = new Size(908, 767);
            panelBassket.TabIndex = 0;
            // 
            // tabPageLibary
            // 
            tabPageLibary.BackColor = SystemColors.Window;
            tabPageLibary.Controls.Add(panelLibary);
            tabPageLibary.Location = new Point(4, 24);
            tabPageLibary.Name = "tabPageLibary";
            tabPageLibary.Padding = new Padding(3);
            tabPageLibary.Size = new Size(928, 807);
            tabPageLibary.TabIndex = 1;
            tabPageLibary.Text = "Библиотека";
            // 
            // panelLibary
            // 
            panelLibary.Dock = DockStyle.Fill;
            panelLibary.Location = new Point(3, 3);
            panelLibary.Name = "panelLibary";
            panelLibary.Size = new Size(922, 801);
            panelLibary.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(214, 22);
            toolStripMenuItem1.Text = "Уведомления";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(936, 859);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form2";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageMarket.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPageCatalog.ResumeLayout(false);
            tabPageWanted.ResumeLayout(false);
            tabPageBasket.ResumeLayout(false);
            tabPageLibary.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem moneytoolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem MasterToolStripMenuItem;
        private ToolStripMenuItem CreateToolStripMenuItem;
        private ToolStripMenuItem CreatedToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPageMarket;
        private TabPage tabPageLibary;
        private TabControl tabControl2;
        private TabPage tabPageCatalog;
        private TabPage tabPageWanted;
        private TabPage tabPageBasket;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panelWanted;
        private Panel panelBassket;
        private Panel panelLibary;
        private Panel marketPanel;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}