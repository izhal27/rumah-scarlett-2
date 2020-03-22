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
      ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).BeginInit();
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
      this.listDataGrid.Location = new System.Drawing.Point(238, 58);
      this.listDataGrid.Name = "listDataGrid";
      this.listDataGrid.ShowRowHeader = true;
      this.listDataGrid.Size = new System.Drawing.Size(534, 351);
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
      // StokBarangView
      // 
      this.AccessibleName = "Master";
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 462);
      this.Controls.Add(this.treeViewTipeBarang);
      this.Controls.Add(this.crudcButtons);
      this.Controls.Add(this.listDataGrid);
      this.Name = "StokBarangView";
      this.Text = "StokBarang";
      this.Load += new System.EventHandler(this.StokBarangView_Load);
      this.Controls.SetChildIndex(this.listDataGrid, 0);
      this.Controls.SetChildIndex(this.panelUp, 0);
      this.Controls.SetChildIndex(this.crudcButtons, 0);
      this.Controls.SetChildIndex(this.treeViewTipeBarang, 0);
      ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).EndInit();
      this.ResumeLayout(false);

      }

      #endregion

      private CommonControls.ListDataGrid listDataGrid;
      private CommonControls.CRUDCButtons crudcButtons;
        private System.Windows.Forms.TreeView treeViewTipeBarang;
    }
}