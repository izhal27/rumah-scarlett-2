using RumahScarlett2.Presentation.Views.CommonControls;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Windows.Forms;

namespace RumahScarlett2.Presentation.Views.StokBarang
{
  public partial class StokBarangView : BaseDataView, IStokBarangView
  {
    public event EventHandler OnLoadData;
    public event EventHandler OnButtonTambahClick;
    public event EventHandler OnButtonUbahClick;
    public event EventHandler OnButtonHapusClick;
    public event EventHandler OnButtonRefreshClick;
    public event EventHandler OnButtonCetakClick;
    public event EventHandler<CellClickEventArgs> OnDataGridCellDoubleClick;
    public event EventHandler<TreeViewEventArgs> OnTreeViewAfterSelect;

    public ListDataGrid ListDataGrid
    {
      get { return listDataGrid; }
    }

    public TreeView TreeViewTipeBarang
    {
      get { return treeViewTipeBarang; }
    }

    public StokBarangView()
    {
      InitializeComponent();

      panelUp.LabelInfo = $"DATA {Text.ToUpper()}";

      listDataGrid.CellDoubleClick += ListDataGrid_CellDoubleClick;
      crudcButtons.OnTambahClick += ButtonsCRUD_OnTambahClick;
      crudcButtons.OnUbahClick += ButtonsCRUD_OnUbahClick;
      crudcButtons.OnHapusClick += ButtonsCRUD_OnHapusClick;
      crudcButtons.OnTutupClick += ButtonsCRUD_OnTutupClickEvent;
    }

    private void StokBarangView_Load(object sender, EventArgs e)
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

    private void treeViewTipeBarang_AfterSelect(object sender, TreeViewEventArgs e)
    {
      OnTreeViewAfterSelect?.Invoke(sender, e);
    }

    private void ButtonsCRUD_OnTutupClickEvent(object sender, EventArgs e)
    {
      Close();
    }
  }
}
