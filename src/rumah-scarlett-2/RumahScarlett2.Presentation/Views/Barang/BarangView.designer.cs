namespace RumahScarlett2.Presentation.Views.Barang
{
   partial class BarangView
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
      this.listDataGrid = new RumahScarlett2.Presentation.Views.CommonControls.ListDataGrid();
      this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
      this.buttonTambah = new System.Windows.Forms.Button();
      this.buttonUbah = new System.Windows.Forms.Button();
      this.buttonHapus = new System.Windows.Forms.Button();
      this.buttonTutup = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).BeginInit();
      this.tlpButtons.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelUp
      // 
      this.panelUp.Size = new System.Drawing.Size(954, 40);
      // 
      // listDataGrid
      // 
      this.listDataGrid.AccessibleName = "Table";
      this.listDataGrid.AllowEditing = false;
      this.listDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
      this.listDataGrid.Location = new System.Drawing.Point(12, 58);
      this.listDataGrid.Name = "listDataGrid";
      this.listDataGrid.ShowRowHeader = true;
      this.listDataGrid.Size = new System.Drawing.Size(954, 351);
      this.listDataGrid.TabIndex = 1;
      this.listDataGrid.Text = "listDataGrid1";
      this.listDataGrid.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.listDataGrid_CellDoubleClick);
      // 
      // tlpButtons
      // 
      this.tlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tlpButtons.BackColor = System.Drawing.SystemColors.Control;
      this.tlpButtons.ColumnCount = 4;
      this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpButtons.Controls.Add(this.buttonTambah, 0, 0);
      this.tlpButtons.Controls.Add(this.buttonUbah, 1, 0);
      this.tlpButtons.Controls.Add(this.buttonHapus, 2, 0);
      this.tlpButtons.Controls.Add(this.buttonTutup, 3, 0);
      this.tlpButtons.Location = new System.Drawing.Point(12, 415);
      this.tlpButtons.Name = "tlpButtons";
      this.tlpButtons.RowCount = 1;
      this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpButtons.Size = new System.Drawing.Size(954, 35);
      this.tlpButtons.TabIndex = 6;
      // 
      // buttonTambah
      // 
      this.buttonTambah.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.buttonTambah.Location = new System.Drawing.Point(3, 6);
      this.buttonTambah.Name = "buttonTambah";
      this.buttonTambah.Size = new System.Drawing.Size(75, 23);
      this.buttonTambah.TabIndex = 94;
      this.buttonTambah.Tag = "Tambah";
      this.buttonTambah.Text = "&Tambah";
      this.buttonTambah.UseVisualStyleBackColor = true;
      this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
      // 
      // buttonUbah
      // 
      this.buttonUbah.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.buttonUbah.Location = new System.Drawing.Point(84, 6);
      this.buttonUbah.Name = "buttonUbah";
      this.buttonUbah.Size = new System.Drawing.Size(75, 23);
      this.buttonUbah.TabIndex = 95;
      this.buttonUbah.Tag = "Ubah";
      this.buttonUbah.Text = "&Ubah";
      this.buttonUbah.UseVisualStyleBackColor = true;
      this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
      // 
      // buttonHapus
      // 
      this.buttonHapus.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.buttonHapus.Location = new System.Drawing.Point(165, 6);
      this.buttonHapus.Name = "buttonHapus";
      this.buttonHapus.Size = new System.Drawing.Size(75, 23);
      this.buttonHapus.TabIndex = 96;
      this.buttonHapus.Tag = "Hapus";
      this.buttonHapus.Text = "&Hapus";
      this.buttonHapus.UseVisualStyleBackColor = true;
      this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
      // 
      // buttonTutup
      // 
      this.buttonTutup.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.buttonTutup.Location = new System.Drawing.Point(876, 6);
      this.buttonTutup.Name = "buttonTutup";
      this.buttonTutup.Size = new System.Drawing.Size(75, 23);
      this.buttonTutup.TabIndex = 100;
      this.buttonTutup.Tag = "ignore";
      this.buttonTutup.Text = "Tutu&p";
      this.buttonTutup.UseVisualStyleBackColor = true;
      this.buttonTutup.Click += new System.EventHandler(this.crudcButtons_OnTutupClickEvent);
      // 
      // BarangView
      // 
      this.AccessibleName = "Master";
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(978, 462);
      this.Controls.Add(this.tlpButtons);
      this.Controls.Add(this.listDataGrid);
      this.Name = "BarangView";
      this.Text = "Barang";
      this.Load += new System.EventHandler(this.BarangView_Load);
      this.Controls.SetChildIndex(this.listDataGrid, 0);
      this.Controls.SetChildIndex(this.panelUp, 0);
      this.Controls.SetChildIndex(this.tlpButtons, 0);
      ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).EndInit();
      this.tlpButtons.ResumeLayout(false);
      this.ResumeLayout(false);

      }

      #endregion

      private CommonControls.ListDataGrid listDataGrid;
      protected System.Windows.Forms.TableLayoutPanel tlpButtons;
      protected System.Windows.Forms.Button buttonTambah;
      protected System.Windows.Forms.Button buttonUbah;
      protected System.Windows.Forms.Button buttonHapus;
      protected System.Windows.Forms.Button buttonTutup;
    }
}