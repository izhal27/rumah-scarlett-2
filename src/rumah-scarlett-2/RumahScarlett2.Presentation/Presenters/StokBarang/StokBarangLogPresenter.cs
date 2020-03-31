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
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RumahScarlett2.Presentation.Presenters.StokBarang
{
  public class StokBarangLogPresenter : IStokBarangLogPresenter
  {
    private IStokBarangLogView _view;
    private IStokBarangServices _services;
    private IBarangServices _barangServices;
    private List<IStokBarangModel> _listObjs;
    private BindingListView<StokBarangLogModel> _bindingView;
    private static string _typeName = "Stok Barang Log";

    public IStokBarangLogView GetView
    {
      get { return _view; }
    }

    public StokBarangLogPresenter()
    {
      _view = new StokBarangLogView();
      _services = new StokBarangServices(new StokBarangRepository(), new ModelDataAnnotationCheck());

      _view.OnLoadData += _view_LoadData;
    }

    private void _view_LoadData(object sender, EventArgs e)
    {
      using (new WaitCursorHandler())
      {
        if (_view.ListDataGrid != null)
        {
          _listObjs = _services.GetStokBarangLogByDate(_view.DateTimePickerTanggal.Value).ToList();
          _bindingView = new BindingListView<StokBarangLogModel>(_listObjs);
          _view.ListDataGrid.DataSource = _bindingView;
        }
      }
    }    
  }
}
