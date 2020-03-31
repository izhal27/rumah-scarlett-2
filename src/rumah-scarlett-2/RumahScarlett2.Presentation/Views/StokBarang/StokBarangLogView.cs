using RumahScarlett2.Presentation.Views.CommonControls;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Windows.Forms;

namespace RumahScarlett2.Presentation.Views.StokBarang
{
  public partial class StokBarangLogView : BaseDataView, IStokBarangLogView
  {
    public event EventHandler OnLoadData;
    public event EventHandler OnButtonTambahClick;
    public event EventHandler OnButtonUbahClick;
    public event EventHandler OnButtonHapusClick;
    public event EventHandler OnButtonRefreshClick;
    public event EventHandler OnButtonCetakClick;
    public event EventHandler<CellClickEventArgs> OnDataGridCellDoubleClick;
    public event EventHandler<EventArgs> OnButtonTampilkanClick;

    public ListDataGrid ListDataGrid
    {
      get { return listDataGrid; }
    }

    public DateTimePicker DateTimePickerTanggal
    {
      get { return dateTimePickerTanggal; }
    }
    
    public StokBarangLogView()
    {
      InitializeComponent();

      panelUp.LabelInfo = $"DATA {Text.ToUpper()}";
    }

    private void StokBarangView_Load(object sender, EventArgs e)
    {
      OnLoadData?.Invoke(sender, e);
      ActiveControl = buttonTutup;
    }
    
    private void buttonTampilkan_Click(object sender, EventArgs e)
    {
      OnButtonTampilkanClick?.Invoke(sender, e);
    }

    private void buttonTutup_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
