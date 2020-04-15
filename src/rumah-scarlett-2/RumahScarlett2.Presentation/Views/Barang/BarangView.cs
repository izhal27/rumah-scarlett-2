using RumahScarlett2.Presentation.Views.CommonControls;
using Syncfusion.WinForms.DataGrid.Events;
using System;

namespace RumahScarlett2.Presentation.Views.Barang
{
  public partial class BarangView : BaseDataView, IBarangView
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

    public BarangView()
    {
      InitializeComponent();

      panelUp.LabelInfo = $"DATA {Text.ToUpper()}";
    }

    private void BarangView_Load(object sender, EventArgs e)
    {
      OnLoadData?.Invoke(sender, e);
      ActiveControl = buttonTutup;
    }

    private void listDataGrid_CellDoubleClick(object sender, CellClickEventArgs e)
    {
      if (buttonUbah.Enabled)
      {
        OnDataGridCellDoubleClick?.Invoke(sender, e);
      }
    }

    private void buttonTambah_Click(object sender, EventArgs e)
    {
      OnButtonTambahClick?.Invoke(sender, e);
    }

    private void buttonUbah_Click(object sender, EventArgs e)
    {
      OnButtonUbahClick?.Invoke(sender, e);
    }

    private void buttonHapus_Click(object sender, EventArgs e)
    {
      OnButtonHapusClick?.Invoke(sender, e);
    }

    private void buttonRefresh_Click(object sender, EventArgs e)
    {
      OnButtonRefreshClick?.Invoke(sender, e);
    }

    private void crudcButtons_OnTutupClickEvent(object sender, EventArgs e)
    {
      Close();
    }
  }
}
