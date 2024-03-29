﻿using RumahScarlett2.CommonComponents;
using RumahScarlett2.Presentation.Views.CommonControls;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahScarlett2.Presentation.Views.TipeBarang
{
   public partial class TipeBarangView : BaseDataView, ITipeBarangView
   {
      public event EventHandler OnLoadData;
      public event EventHandler OnButtonTambahClick;
      public event EventHandler OnButtonUbahClick;
      public event EventHandler OnButtonHapusClick;
      public event EventHandler OnButtonRefreshClick;
      public event EventHandler OnButtonCetakClick;
      public event EventHandler<CellClickEventArgs> OnDataGridCellDoubleClick;

      public ListDataGrid ListDataGrid
      {
         get { return listDataGrid; }
      }

      public TipeBarangView()
      {
         InitializeComponent();

         panelUp.LabelInfo = $"DATA {Text.ToUpper()}";

         listDataGrid.CellDoubleClick += ListDataGrid_CellDoubleClick;
         crudcButtons.OnTambahClick += ButtonsCRUD_OnTambahClick;
         crudcButtons.OnUbahClick += ButtonsCRUD_OnUbahClick;
         crudcButtons.OnHapusClick += ButtonsCRUD_OnHapusClick;
         crudcButtons.OnRefreshClick += ButtonsCRUD_OnRefreshClickEvent;
         crudcButtons.OnTutupClick += ButtonsCRUD_OnTutupClickEvent;
      }

      private void TipeView_Load(object sender, EventArgs e)
      {
         OnLoadData?.Invoke(sender, e);
         ActiveControl = crudcButtons.ButtonTutup;
      }

      private void ListDataGrid_CellDoubleClick(object sender, CellClickEventArgs e)
      {
         if (crudcButtons.ButtonUbah.Enabled)
         {
            OnDataGridCellDoubleClick?.Invoke(sender, e);
         }
      }

      private void ButtonsCRUD_OnTambahClick(object sender, EventArgs e)
      {
         OnButtonTambahClick?.Invoke(sender, e);
      }

      private void ButtonsCRUD_OnUbahClick(object sender, EventArgs e)
      {
         OnButtonUbahClick?.Invoke(sender, e);
      }

      private void ButtonsCRUD_OnHapusClick(object sender, EventArgs e)
      {
         OnButtonHapusClick?.Invoke(sender, e);
      }

      private void ButtonsCRUD_OnRefreshClickEvent(object sender, EventArgs e)
      {
         OnButtonRefreshClick?.Invoke(sender, e);
      }

      private void ButtonsCRUD_OnTutupClickEvent(object sender, EventArgs e)
      {
         Close();
      }
   }
}
