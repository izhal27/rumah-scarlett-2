namespace RumahScarlett2.Presentation.Views.StokBarang
{
   partial class StokBarangView
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
      this.crudcButtons = new RumahScarlett2.Presentation.Views.CommonControls.CRUDCButtons();
      this.treeViewTipeBarang = new System.Windows.Forms.TreeView();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.labelNamaBarang = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.labelStokAkhir = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // listDataGrid
      // 
      this.listDataGrid.AccessibleName = "Table";
      this.listDataGrid.AllowEditing = false;
      this.listDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
      this.listDataGrid.Location = new System.Drawing.Point(238, 126);
      this.listDataGrid.Name = "listDataGrid";
      this.listDataGrid.ShowRowHeader = true;
      this.listDataGrid.Size = new System.Drawing.Size(534, 283);
      this.listDataGrid.TabIndex = 1;
      this.listDataGrid.Text = "listDataGrid1";
      // 
      // crudcButtons
      // 
      this.crudcButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.crudcButtons.BackColor = System.Drawing.Color.Transparent;
      this.crudcButtons.Location = new System.Drawing.Point(238, 415);
      this.crudcButtons.Name = "crudcButtons";
      this.crudcButtons.Size = new System.Drawing.Size(534, 35);
      this.crudcButtons.TabIndex = 2;
      // 
      // treeViewTipeBarang
      // 
      this.treeViewTipeBarang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.treeViewTipeBarang.Location = new System.Drawing.Point(12, 58);
      this.treeViewTipeBarang.Name = "treeViewTipeBarang";
      this.treeViewTipeBarang.Size = new System.Drawing.Size(220, 392);
      this.treeViewTipeBarang.TabIndex = 0;
      this.treeViewTipeBarang.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTipeBarang_AfterSelect);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.labelNamaBarang, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.labelStokAkhir, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(238, 58);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 62);
      this.tableLayoutPanel1.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(3, 7);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(95, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nama Barang";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(104, 7);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(12, 17);
      this.label2.TabIndex = 0;
      this.label2.Text = ":";
      // 
      // labelNamaBarang
      // 
      this.labelNamaBarang.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.labelNamaBarang.AutoSize = true;
      this.labelNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelNamaBarang.Location = new System.Drawing.Point(122, 7);
      this.labelNamaBarang.Name = "labelNamaBarang";
      this.labelNamaBarang.Size = new System.Drawing.Size(13, 17);
      this.labelNamaBarang.TabIndex = 0;
      this.labelNamaBarang.Text = "-";
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(104, 38);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(12, 17);
      this.label4.TabIndex = 0;
      this.label4.Text = ":";
      // 
      // labelStokAkhir
      // 
      this.labelStokAkhir.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.labelStokAkhir.AutoSize = true;
      this.labelStokAkhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelStokAkhir.Location = new System.Drawing.Point(122, 38);
      this.labelStokAkhir.Name = "labelStokAkhir";
      this.labelStokAkhir.Size = new System.Drawing.Size(13, 17);
      this.labelStokAkhir.TabIndex = 0;
      this.labelStokAkhir.Text = "-";
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(3, 38);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(72, 17);
      this.label3.TabIndex = 0;
      this.label3.Text = "Stok Akhir";
      // 
      // StokBarangView
      // 
      this.AccessibleName = "Master";
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 462);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.treeViewTipeBarang);
      this.Controls.Add(this.crudcButtons);
      this.Controls.Add(this.listDataGrid);
      this.Name = "StokBarangView";
      this.Text = "Stok Barang";
      this.Load += new System.EventHandler(this.StokBarangView_Load);
      this.Controls.SetChildIndex(this.listDataGrid, 0);
      this.Controls.SetChildIndex(this.panelUp, 0);
      this.Controls.SetChildIndex(this.crudcButtons, 0);
      this.Controls.SetChildIndex(this.treeViewTipeBarang, 0);
      this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
      ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

      }

      #endregion

      private CommonControls.ListDataGrid listDataGrid;
      private CommonControls.CRUDCButtons crudcButtons;
        private System.Windows.Forms.TreeView treeViewTipeBarang;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label labelNamaBarang;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label labelStokAkhir;
    private System.Windows.Forms.Label label3;
  }
}