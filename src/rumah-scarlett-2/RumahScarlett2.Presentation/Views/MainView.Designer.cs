namespace RumahScarlett2.Presentation.Views
{
  partial class MainView
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.tipeBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.stokBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.stokBarangToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.barangToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.menuStrip.SuspendLayout();
      this.toolStrip.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.toolsMenu,
            this.helpMenu});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(632, 24);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "MenuStrip";
      // 
      // fileMenu
      // 
      this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
      this.fileMenu.Name = "fileMenu";
      this.fileMenu.Size = new System.Drawing.Size(37, 20);
      this.fileMenu.Text = "&File";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // toolsMenu
      // 
      this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipeBarangToolStripMenuItem,
            this.barangToolStripMenuItem,
            this.stokBarangToolStripMenuItem});
      this.toolsMenu.Name = "toolsMenu";
      this.toolsMenu.Size = new System.Drawing.Size(43, 20);
      this.toolsMenu.Text = "&Data";
      // 
      // tipeBarangToolStripMenuItem
      // 
      this.tipeBarangToolStripMenuItem.Name = "tipeBarangToolStripMenuItem";
      this.tipeBarangToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
      this.tipeBarangToolStripMenuItem.Text = "&Tipe Barang";
      this.tipeBarangToolStripMenuItem.Click += new System.EventHandler(this.tipeBarangToolStripMenuItem_Click);
      // 
      // barangToolStripMenuItem
      // 
      this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
      this.barangToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
      this.barangToolStripMenuItem.Text = "&Barang";
      this.barangToolStripMenuItem.Click += new System.EventHandler(this.barangToolStripMenuItem_Click);
      // 
      // stokBarangToolStripMenuItem
      // 
      this.stokBarangToolStripMenuItem.Name = "stokBarangToolStripMenuItem";
      this.stokBarangToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
      this.stokBarangToolStripMenuItem.Text = "&Stok Barang";
      this.stokBarangToolStripMenuItem.Click += new System.EventHandler(this.stokBarangToolStripMenuItem_Click);
      // 
      // helpMenu
      // 
      this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpMenu.Name = "helpMenu";
      this.helpMenu.Size = new System.Drawing.Size(44, 20);
      this.helpMenu.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.aboutToolStripMenuItem.Text = "&About ... ...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // toolStrip
      // 
      this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokBarangToolStripButton,
            this.barangToolStripButton,
            this.toolStripSeparator1,
            this.exitToolStripButton});
      this.toolStrip.Location = new System.Drawing.Point(0, 24);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(632, 25);
      this.toolStrip.TabIndex = 1;
      this.toolStrip.Text = "ToolStrip";
      // 
      // stokBarangToolStripButton
      // 
      this.stokBarangToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.stokBarangToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("stokBarangToolStripButton.Image")));
      this.stokBarangToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
      this.stokBarangToolStripButton.Name = "stokBarangToolStripButton";
      this.stokBarangToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.stokBarangToolStripButton.Text = "Stok Barang";
      this.stokBarangToolStripButton.Click += new System.EventHandler(this.stokBarangToolStripButton_Click);
      // 
      // barangToolStripButton
      // 
      this.barangToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.barangToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("barangToolStripButton.Image")));
      this.barangToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
      this.barangToolStripButton.Name = "barangToolStripButton";
      this.barangToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.barangToolStripButton.Text = "Barang";
      this.barangToolStripButton.Click += new System.EventHandler(this.barangToolStripButton_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // exitToolStripButton
      // 
      this.exitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.exitToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripButton.Image")));
      this.exitToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
      this.exitToolStripButton.Name = "exitToolStripButton";
      this.exitToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.exitToolStripButton.Text = "Exit";
      this.exitToolStripButton.Click += new System.EventHandler(this.exitToolStripButton_Click);
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 431);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(632, 22);
      this.statusStrip.TabIndex = 2;
      this.statusStrip.Text = "StatusStrip";
      // 
      // toolStripStatusLabel
      // 
      this.toolStripStatusLabel.Name = "toolStripStatusLabel";
      this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
      this.toolStripStatusLabel.Text = "Status";
      // 
      // MainView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(632, 453);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.toolStrip);
      this.Controls.Add(this.menuStrip);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip;
      this.Name = "MainView";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "RUMAH SCARLETT";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.MainView_Load);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion


    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStrip toolStrip;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fileMenu;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolsMenu;
    private System.Windows.Forms.ToolStripMenuItem helpMenu;
    private System.Windows.Forms.ToolStripButton stokBarangToolStripButton;
    private System.Windows.Forms.ToolStripButton barangToolStripButton;
    private System.Windows.Forms.ToolStripButton exitToolStripButton;
    private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tipeBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokBarangToolStripMenuItem;
    }
}



