using Equin.ApplicationFramework;
using RumahScarlett2.CommonComponents;
using RumahScarlett2.Domain.Models.Barang;
using RumahScarlett2.Infrastructure.DataAccess.Repositories.Barang;
using RumahScarlett2.Presentation.Helper;
using RumahScarlett2.Presentation.Views.Barang;
using RumahScarlett2.Presentation.Views.CommonControls;
using RumahScarlett2.Services.Services;
using RumahScarlett2.Services.Services.Barang;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RumahScarlett2.Presentation.Presenters.Barang
{
  class BarangPresenter : IBarangPresenter
  {
    private IBarangView _view;
    private IBarangServices _barangServices;
    private List<IBarangModel> _listObjs;
    private BindingListView<BarangModel> _bindingView;
    private static string _typeName = "Barang";

    public IBarangView GetView
    {
      get { return _view; }
    }

    public BarangPresenter()
    {
      _view = new BarangView();
      _barangServices = new BarangServices(new BarangRepository(), new ModelDataAnnotationCheck());

      _view.OnLoadData += _view_LoadData;
      _view.OnButtonTambahClick += _view_OnCreateData;
      _view.OnButtonUbahClick += _view_OnUpdateData;
      _view.OnButtonHapusClick += _view_OnDeleteData;
      _view.OnButtonRefreshClick += _view_OnButtonRefreshClick;

      _view.OnDataGridCellDoubleClick += _view_DataGrid_CellDoubleClick;
    }

    private void _view_LoadData(object sender, EventArgs e)
    {
      using (new WaitCursorHandler())
      {
        _listObjs = _barangServices.GetAll().ToList();
        _bindingView = new BindingListView<BarangModel>(_listObjs);
        _view.ListDataGrid.DataSource = _bindingView;
      }
    }

    private void _view_OnCreateData(object sender, EventArgs e)
    {
      var view = new BarangEntryView();
      view.OnSaveData += BarangEntryView_OnSaveData;
      view.ShowDialog();
    }

    private void _view_OnUpdateData(object sender, EventArgs e)
    {
      using (new WaitCursorHandler())
      {
        ListDataGrid listDataGrid = null;

        if (sender is ListDataGrid)
        {
          listDataGrid = (ListDataGrid)sender;
        }
        else
        {
          listDataGrid = _view.ListDataGrid;
        }

        if (listDataGrid != null && listDataGrid.SelectedItem != null)
        {
          var model = _barangServices.GetById(((BarangModel)listDataGrid.SelectedItem).id);

          if (model != null)
          {
            var view = new BarangEntryView(false, model);
            view.OnSaveData += BarangEntryView_OnSaveData;
            view.ShowDialog();
          }
        }
      }
    }

    private void BarangEntryView_OnSaveData(object sender, EventArgs e)
    {
      using (new WaitCursorHandler())
      {
        try
        {
          var listDataGrid = _view.ListDataGrid;
          var newModel = ((ModelEventArgs<BarangModel>)e).Value;
          var barangEntryView = ((BarangEntryView)sender);

          if (newModel.id == default(uint))
          {
            _barangServices.Insert(newModel);
            barangEntryView.Controls.ClearControls();
            Messages.InfoSave(_typeName);

            _listObjs.Add(newModel);
            _bindingView.DataSource = _listObjs;

            if (listDataGrid.SelectedItem != null)
            {
              listDataGrid.SelectedItem = null;
            }

            listDataGrid.SelectedItem = newModel;
          }
          else
          {
            _barangServices.Update(newModel);
            Messages.InfoUpdate(_typeName);
            barangEntryView.Close();

            var model = _bindingView.Where(b => b.id == newModel.id).FirstOrDefault();

            if (model != null)
            {
              model.nama = newModel.nama;
              model.tipe_id = newModel.tipe_id;
              model.stok_akhir = newModel.stok_akhir;
              model.keterangan = newModel.keterangan;

              _bindingView.Refresh();
            }
          }
        }
        catch (ArgumentException ex)
        {
          Messages.Error(ex);
        }
        catch (DataAccessException ex)
        {
          Messages.Error(ex);
        }
      }
    }

    private void _view_OnDeleteData(object sender, EventArgs e)
    {
      using (new WaitCursorHandler())
      {
        if (_view.ListDataGrid != null && _view.ListDataGrid.SelectedItem != null && Messages.ConfirmDelete(_typeName))
        {
          try
          {
            var model = _barangServices.GetById(((BarangModel)_view.ListDataGrid.SelectedItem).id);

            _barangServices.Delete(model);
            Messages.InfoDelete(_typeName);

            if (_listObjs.Remove((BarangModel)_view.ListDataGrid.SelectedItem))
            {
              _bindingView.DataSource = _listObjs;
            }
          }
          catch (DataAccessException ex)
          {
            Messages.Error(ex);
          }
          finally
          {
            if (_view.ListDataGrid.SelectedItem != null)
            {
              _view.ListDataGrid.SelectedItem = null;
            }
          }
        }
      }
    }

    private void _view_OnButtonRefreshClick(object sender, EventArgs e)
    {
      using (new WaitCursorHandler())
      {
        _listObjs = _barangServices.GetAll().ToList();
        _bindingView.DataSource = _listObjs;
      }
    }

    private void _view_DataGrid_CellDoubleClick(object sender, CellClickEventArgs e)
    {
      _view_OnUpdateData(sender, e);
    }
  }
}
