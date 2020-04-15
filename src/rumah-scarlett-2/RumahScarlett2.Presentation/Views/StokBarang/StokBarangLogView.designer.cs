namespace RumahScarlett2.Presentation.Views.StokBarang
{
   partial class StokBarangLogView
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label2 = new System.Windows.Forms.Label();
      this.buttonTampilkan = new System.Windows.Forms.Button();
      this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
      this.radioButtonTanggal = new System.Windows.Forms.RadioButton();
      this.radioButtonDari = new System.Windows.Forms.RadioButton();
      this.label1 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
      this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.labelTotalMasuk = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.buttonTutup = new System.Windows.Forms.Button();
      this.labelTotalKeluar = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // listDataGrid
      // 
      this.listDataGrid.AccessibleName = "Table";
      this.listDataGrid.AllowEditing = false;
      this.listDataGrid.AllowSorting = false;
      this.listDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
      this.listDataGrid.Location = new System.Drawing.Point(12, 147);
      this.listDataGrid.Name = "listDataGrid";
      this.listDataGrid.ShowRowHeader = true;
      this.listDataGrid.Size = new System.Drawing.Size(760, 262);
      this.listDataGrid.TabIndex = 1;
      this.listDataGrid.Text = "listDataGrid1";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.ColumnCount = 6;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.buttonTampilkan, 3, 2);
      this.tableLayoutPanel1.Controls.Add(this.dateTimePickerTanggal, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.radioButtonTanggal, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.radioButtonDari, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label8, 4, 1);
      this.tableLayoutPanel1.Controls.Add(this.dateTimePickerStart, 3, 1);
      this.tableLayoutPanel1.Controls.Add(this.dateTimePickerEnd, 5, 1);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 58);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 83);
      this.tableLayoutPanel1.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(73, 4);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(12, 17);
      this.label2.TabIndex = 0;
      this.label2.Text = ":";
      // 
      // buttonTampilkan
      // 
      this.buttonTampilkan.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.buttonTampilkan.Location = new System.Drawing.Point(91, 56);
      this.buttonTampilkan.Name = "buttonTampilkan";
      this.buttonTampilkan.Size = new System.Drawing.Size(75, 23);
      this.buttonTampilkan.TabIndex = 5;
      this.buttonTampilkan.Text = "&Tampilkan";
      this.buttonTampilkan.UseVisualStyleBackColor = true;
      this.buttonTampilkan.Click += new System.EventHandler(this.buttonTampilkan_Click);
      // 
      // dateTimePickerTanggal
      // 
      this.dateTimePickerTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.dateTimePickerTanggal.Location = new System.Drawing.Point(91, 3);
      this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
      this.dateTimePickerTanggal.Size = new System.Drawing.Size(150, 20);
      this.dateTimePickerTanggal.TabIndex = 1;
      // 
      // radioButtonTanggal
      // 
      this.radioButtonTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.radioButtonTanggal.AutoSize = true;
      this.radioButtonTanggal.Checked = true;
      this.radioButtonTanggal.Location = new System.Drawing.Point(3, 4);
      this.radioButtonTanggal.Name = "radioButtonTanggal";
      this.radioButtonTanggal.Size = new System.Drawing.Size(64, 17);
      this.radioButtonTanggal.TabIndex = 0;
      this.radioButtonTanggal.TabStop = true;
      this.radioButtonTanggal.Text = "Tangga&l";
      this.radioButtonTanggal.UseVisualStyleBackColor = true;
      this.radioButtonTanggal.CheckedChanged += new System.EventHandler(this.radioButtonTanggal_CheckedChanged);
      // 
      // radioButtonDari
      // 
      this.radioButtonDari.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.radioButtonDari.AutoSize = true;
      this.radioButtonDari.Location = new System.Drawing.Point(3, 30);
      this.radioButtonDari.Name = "radioButtonDari";
      this.radioButtonDari.Size = new System.Drawing.Size(44, 17);
      this.radioButtonDari.TabIndex = 2;
      this.radioButtonDari.Text = "D&ari";
      this.radioButtonDari.UseVisualStyleBackColor = true;
      this.radioButtonDari.CheckedChanged += new System.EventHandler(this.radioButtonDari_CheckedChanged);
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(73, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(12, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = ":";
      // 
      // label8
      // 
      this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(247, 30);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(27, 17);
      this.label8.TabIndex = 0;
      this.label8.Text = "s.d";
      // 
      // dateTimePickerStart
      // 
      this.dateTimePickerStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.dateTimePickerStart.Location = new System.Drawing.Point(91, 29);
      this.dateTimePickerStart.Name = "dateTimePickerStart";
      this.dateTimePickerStart.Size = new System.Drawing.Size(150, 20);
      this.dateTimePickerStart.TabIndex = 3;
      // 
      // dateTimePickerEnd
      // 
      this.dateTimePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.dateTimePickerEnd.Location = new System.Drawing.Point(280, 29);
      this.dateTimePickerEnd.Name = "dateTimePickerEnd";
      this.dateTimePickerEnd.Size = new System.Drawing.Size(150, 20);
      this.dateTimePickerEnd.TabIndex = 4;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel2.ColumnCount = 8;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.Controls.Add(this.labelTotalMasuk, 2, 0);
      this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.label6, 4, 0);
      this.tableLayoutPanel2.Controls.Add(this.label7, 5, 0);
      this.tableLayoutPanel2.Controls.Add(this.buttonTutup, 7, 0);
      this.tableLayoutPanel2.Controls.Add(this.labelTotalKeluar, 6, 0);
      this.tableLayoutPanel2.Controls.Add(this.label5, 3, 0);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 415);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(760, 35);
      this.tableLayoutPanel2.TabIndex = 4;
      // 
      // labelTotalMasuk
      // 
      this.labelTotalMasuk.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.labelTotalMasuk.AutoSize = true;
      this.labelTotalMasuk.Location = new System.Drawing.Point(93, 11);
      this.labelTotalMasuk.Name = "labelTotalMasuk";
      this.labelTotalMasuk.Size = new System.Drawing.Size(13, 13);
      this.labelTotalMasuk.TabIndex = 6;
      this.labelTotalMasuk.Text = "0";
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 11);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 13);
      this.label3.TabIndex = 11;
      this.label3.Text = "Total Masuk";
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(75, 9);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(12, 17);
      this.label4.TabIndex = 5;
      this.label4.Text = ":";
      // 
      // label6
      // 
      this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(137, 11);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(64, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Total Keluar";
      // 
      // label7
      // 
      this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(207, 9);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(12, 17);
      this.label7.TabIndex = 5;
      this.label7.Text = ":";
      // 
      // buttonTutup
      // 
      this.buttonTutup.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.buttonTutup.Location = new System.Drawing.Point(682, 6);
      this.buttonTutup.Name = "buttonTutup";
      this.buttonTutup.Size = new System.Drawing.Size(75, 23);
      this.buttonTutup.TabIndex = 10;
      this.buttonTutup.Text = "Tutu&p";
      this.buttonTutup.UseVisualStyleBackColor = true;
      this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
      // 
      // labelTotalKeluar
      // 
      this.labelTotalKeluar.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.labelTotalKeluar.AutoSize = true;
      this.labelTotalKeluar.Location = new System.Drawing.Point(225, 11);
      this.labelTotalKeluar.Name = "labelTotalKeluar";
      this.labelTotalKeluar.Size = new System.Drawing.Size(13, 13);
      this.labelTotalKeluar.TabIndex = 6;
      this.labelTotalKeluar.Text = "0";
      // 
      // label5
      // 
      this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(116, 9);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(11, 17);
      this.label5.TabIndex = 5;
      this.label5.Text = "|";
      // 
      // StokBarangLogView
      // 
      this.AccessibleName = "Master";
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 462);
      this.Controls.Add(this.tableLayoutPanel2);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.listDataGrid);
      this.Name = "StokBarangLogView";
      this.Text = "Stok Barang Log";
      this.Load += new System.EventHandler(this.StokBarangView_Load);
      this.Controls.SetChildIndex(this.listDataGrid, 0);
      this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
      this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
      this.Controls.SetChildIndex(this.panelUp, 0);
      ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.ResumeLayout(false);

      }

      #endregion

      private CommonControls.ListDataGrid listDataGrid;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button buttonTutup;
    private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
    private System.Windows.Forms.Button buttonTampilkan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalMasuk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotalKeluar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonTanggal;
        private System.Windows.Forms.RadioButton radioButtonDari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
    }
}