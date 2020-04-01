using Equin.ApplicationFramework;
using RumahScarlett2.CommonComponents;
using RumahScarlett2.Domain.Models.StokBarang;
using RumahScarlett2.Infrastructure.DataAccess.Repositories.Barang;
using RumahScarlett2.Infrastructure.DataAccess.Repositories.StokBarang;
using RumahScarlett2.Infrastructure.DataAccess.Repositories.TipeBarang;
using RumahScarlett2.Presentation.Helper;
using RumahScarlett2.Presentation.Views.CommonControls;
using RumahScarlett2.Presentation.Views.StokBarang;
using RumahScarlett2.Services.Services;
using RumahScarlett2.Services.Services.Barang;
using RumahScarlett2.Services.Services.StokBarang;
using RumahScarlett2.Services.Services.TipeBarang;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RumahScarlett2.Presentation.Presenters.StokBarang
{
  public class StokBarangLogPresenter : IStokBarangLogPresenter
  {
    private IStokBarangLogView _view;
    private IStokBarangServices _services;
    //private List<IStokBarangModel> _listObjs;
    private BindingListView<StokBarangLogModel> _bindingView;
    //private static string _typeName = "Stok Barang Log";

    public IStokBarangLogView GetView
    {
      get { return _view; }
    }

    public StokBarangLogPresenter()
    {
      _view = new StokBarangLogView();
      _services = new StokBarangServices(new StokBarangRepository(), new ModelDataAnnotationCheck());

      _view.OnLoadData += _view_LoadData;
      _view.OnButtonTampilkanClick += _view_OnButtonTampilkanClick;
    }

    private void _view_LoadData(object sender, EventArgs e)
    {
      using (new WaitCursorHandler())
      {
        if (_view.ListDataGrid != null)        {

          var listObjs = _services.GetStokBarangLogByDate(_view.DateTimePickerTanggal.Value).ToList();
          _bindingView = new BindingListView<StokBarangLogModel>(listObjs);
          _bindingView.ListChanged += _bindingView_ListChanged;
          _bindingView.Refresh();

          _view.ListDataGrid.DataSource = _bindingView;
        }
      }
    }

    private void _bindingView_ListChanged(object sender, ListChangedEventArgs e)
    {
      int totalMasuk = 0;
      int totalKeluar = 0;

      if (_bindingView.Count > 0)
      {
        totalMasuk = _bindingView.ToList().Sum(sb => sb.barang_masuk);
        totalKeluar = _bindingView.ToList().Sum(sb => sb.barang_keluar);
      }

      _view.LabelTotalMasuk.Text = totalMasuk.ToString("N0");
      _view.LabelTotalKeluar.Text = totalKeluar.ToString("N0");
    }

    private void _view_OnButtonTampilkanClick(object sender, EventArgs e)
    {
      using (new WaitCursorHandler())
      {
        var listObjs = _services.GetStokBarangLogByDate(_view.DateTimePickerTanggal.Value).ToList();
        _bindingView.DataSource = listObjs;
      }
    }
  }
}
