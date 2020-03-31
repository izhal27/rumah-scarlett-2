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
      this.stokBarangLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // toolsMenu
      // 
      this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipeBarangToolStripMenuItem,
            this.barangToolStripMenuItem,
            this.stokBarangToolStripMenuItem,
            this.stokBarangLogToolStripMenuItem});
      this.toolsMenu.Name = "toolsMenu";
      this.toolsMenu.Size = new System.Drawing.Size(43, 20);
      this.toolsMenu.Text = "&Data";
      // 
      // tipeBarangToolStripMenuItem
      // 
      this.tipeBarangToolStripMenuItem.Name = "tipeBarangToolStripMenuItem";
      this.tipeBarangToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
      this.tipeBarangToolStripMenuItem.Text = "&Tipe Barang";
      this.tipeBarangToolStripMenuItem.Click += new System.EventHandler(this.tipeBarangToolStripMenuItem_Click);
      // 
      // barangToolStripMenuItem
      // 
      this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
      this.barangToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
      this.barangToolStripMenuItem.Text = "&Barang";
      this.barangToolStripMenuItem.Click += new System.EventHandler(this.barangToolStripMenuItem_Click);
      // 
      // stokBarangToolStripMenuItem
      // 
      this.stokBarangToolStripMenuItem.Name = "stokBarangToolStripMenuItem";
      this.stokBarangToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
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
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
      this.aboutToolStripMenuItem.Text = "&About ... ...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
      // 
      // toolStrip
      // 
      this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokBarangToolStripButton,
            this.barangToolStripButton,
            this.toolStripSeparator1,
            this.exitToolStripButton});
      this.toolStrip.Location = new System.Drawing.Point(0, 24);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(632, 64);
      this.toolStrip.TabIndex = 1;
      this.toolStrip.Text = "ToolStrip";
      // 
      // stokBarangToolStripButton
      // 
      this.stokBarangToolStripButton.Image = global::RumahScarlett2.Presentation.Properties.Resources.stock_32;
      this.stokBarangToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.stokBarangToolStripButton.ImageTransparentColor = System.Drawing.Color.BlanchedAlmond;
      this.stokBarangToolStripButton.Name = "stokBarangToolStripButton";
      this.stokBarangToolStripButton.Padding = new System.Windows.Forms.Padding(5);
      this.stokBarangToolStripButton.Size = new System.Drawing.Size(84, 61);
      this.stokBarangToolStripButton.Text = "Stok Barang";
      this.stokBarangToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.stokBarangToolStripButton.Click += new System.EventHandler(this.stokBarangToolStripButton_Click);
      // 
      // barangToolStripButton
      // 
      this.barangToolStripButton.Image = global::RumahScarlett2.Presentation.Properties.Resources.skincare_32;
      this.barangToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.barangToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
      this.barangToolStripButton.Name = "barangToolStripButton";
      this.barangToolStripButton.Padding = new System.Windows.Forms.Padding(5);
      this.barangToolStripButton.Size = new System.Drawing.Size(58, 61);
      this.barangToolStripButton.Text = "Barang";
      this.barangToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.barangToolStripButton.Click += new System.EventHandler(this.barangToolStripButton_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 64);
      // 
      // exitToolStripButton
      // 
      this.exitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.exitToolStripButton.Image = global::RumahScarlett2.Presentation.Properties.Resources.exit_32;
      this.exitToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.exitToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
      this.exitToolStripButton.Name = "exitToolStripButton";
      this.exitToolStripButton.Padding = new System.Windows.Forms.Padding(5);
      this.exitToolStripButton.Size = new System.Drawing.Size(46, 61);
      this.exitToolStripButton.Text = "Exit";
      this.exitToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
      // stokBarangLogToolStripMenuItem
      // 
      this.stokBarangLogToolStripMenuItem.Name = "stokBarangLogToolStripMenuItem";
      this.stokBarangLogToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
      this.stokBarangLogToolStripMenuItem.Text = "Stok Barang &Log";
      this.stokBarangLogToolStripMenuItem.Click += new System.EventHandler(this.stokBarangLogToolStripMenuItem_Click);
      // 
      // MainView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(632, 453);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.toolStrip);
      this.Controls.Add(this.menuStrip);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    private System.Windows.Forms.ToolStripMenuItem stokBarangLogToolStripMenuItem;
  }
}



