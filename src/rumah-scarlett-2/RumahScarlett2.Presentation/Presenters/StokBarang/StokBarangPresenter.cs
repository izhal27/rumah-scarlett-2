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
  public class StokBarangPresenter : IStokBarangPresenter
  {
    private IStokBarangView _view;
    private IStokBarangServices _services;
    private IBarangServices _barangServices;
    private List<IStokBarangModel> _listObjs;
    private BindingListView<StokBarangModel> _bindingView;
    private static string _typeName = "Stok Barang";

    public IStokBarangView GetView
    {
      get { return _view; }
    }

    public StokBarangPresenter()
    {
      _view = new StokBarangView();
      _services = new StokBarangServices(new StokBarangRepository(), new ModelDataAnnotationCheck());
      _barangServices = new BarangServices(new BarangRepository(), new ModelDataAnnotationCheck());

      _view.OnLoadData += _view_LoadData;
      _view.OnButtonTambahClick += _view_OnCreateData;
      _view.OnButtonUbahClick += _view_OnUpdateData;
      _view.OnButtonHapusClick += _view_OnDeleteData;

      _view.OnDataGridCellDoubleClick += OnDataGrid_CellDoubleClick;
      _view.OnTreeViewAfterSelect += _view_OnTreeViewAfterSelect;
    }

    private void _view_LoadData(object sender, EventArgs e)
    {
      using (new WaitCursorHandler())
      {
        if (_view.ListDataGrid != null)
        {

          _bindingView = new BindingListView<StokBarangModel>(new List<StokBarangModel> { new StokBarangModel() });
          _view.ListDataGrid.DataSource = _bindingView;
          _bindingView.DataSource.Clear();
          _bindingView.Refresh();

          var tipeBarangList = new TipeBarangServices(new TipeBarangRepository(), new ModelDataAnnotationCheck()).GetAll();
          var barangList = _barangServices.GetAll().ToList();

          foreach (var tipe in tipeBarangList)
          {
            var node = _view.TreeViewTipeBarang.Nodes.Add(tipe.id.ToString(), tipe.nama);
            var barangMatched = barangList.Where(b => b.tipe_id == tipe.id).ToList();
            foreach (var barang in barangMatched)
            {
              node.Nodes.Add(barang.id.ToString(), barang.nama);
              barangList.Remove(barang);
            }
          }

          _view.TreeViewTipeBarang.ExpandAll();
        }
      }
    }

    private void _view_OnCreateData(object sender, EventArgs e)
    {
      var node = _view.TreeViewTipeBarang.SelectedNode;
      if (node != null && node.Parent != null)
      {
        var barangModel = _barangServices.GetById(node.Name);
        var view = new StokBarangEntryView(barangID: int.Parse(node.Name), barangModel: barangModel);
        view.OnSaveData += StokBarangEntryView_OnSaveData;
        view.ShowDialog();
      }
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
          var model = _services.GetById(((StokBarangModel)listDataGrid.SelectedItem).id);
          var node = _view.TreeViewTipeBarang.SelectedNode;

          if (model != null)
          {
            var view = new StokBarangEntryView(false, int.Parse(node.Name), model);
            view.OnSaveData += StokBarangEntryView_OnSaveData;
            view.ShowDialog();
          }
        }
      }
    }

    private void StokBarangEntryView_OnSaveData(object sender, EventArgs e)
    {
      using (new WaitCursorHandler())
      {
        try
        {
          var listDataGrid = _view.ListDataGrid;
          var newModel = ((ModelEventArgs<StokBarangModel>)e).Value;
          var view = ((StokBarangEntryView)sender);

          if (newModel.id == default(uint))
          {
            _services.Insert(newModel);
            view.Controls.ClearControls();
            Messages.InfoSave(_typeName);

            _listObjs.Add(newModel);
            _bindingView.DataSource = _listObjs;

            if (listDataGrid.SelectedItem != null)
            {
              listDataGrid.SelectedItem = null;
            }

            var node = _view.TreeViewTipeBarang.SelectedNode;
            var stokAkhir = _barangServices.GetById(node.Name).stok_akhir;
            view.TextBoxStokAwal.IntegerValue = stokAkhir;
            view.TextBoxStokAkhir.IntegerValue = stokAkhir;

            //listDataGrid.SelectedItem = newModel;
          }
          else
          {
            _services.Update(newModel);
            Messages.InfoUpdate(_typeName);
            view.Close();

            var model = _bindingView.Where(b => b.id == newModel.id).FirstOrDefault();

            if (model != null)
            {
              model.barang_id = newModel.barang_id;
              model.barang_masuk = newModel.barang_masuk;
              model.barang_keluar = newModel.barang_keluar;

              _bindingView.Refresh();
            }
          }

          _view_OnTreeViewAfterSelect(null, null);
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
            var model = _services.GetById(((StokBarangModel)_view.ListDataGrid.SelectedItem).id);

            _services.Delete(model);
            Messages.InfoDelete(_typeName);

            if (_listObjs.Remove((StokBarangModel)_view.ListDataGrid.SelectedItem))
            {
              _bindingView.DataSource = _listObjs;
              _view_OnTreeViewAfterSelect(null, null);
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

    private void OnDataGrid_CellDoubleClick(object sender, CellClickEventArgs e)
    {
      _view_OnUpdateData(sender, e);
    }

    private void _view_OnTreeViewAfterSelect(object sender, TreeViewEventArgs e)
    {
      var node = _view.TreeViewTipeBarang.SelectedNode;
      if (node != null && node.Parent != null)
      {
        var barangModel = _barangServices.GetById(node.Name);
        _view.LabelNamaBarang.Text = barangModel.nama;
        _view.LabelStokAkhir.Text = barangModel.stok_akhir.ToString("N0");
        _listObjs = _services.GetByBarangId(node.Name).ToList();
        _bindingView = new BindingListView<StokBarangModel>(_listObjs);
        _view.ListDataGrid.DataSource = _bindingView;
      }
      else
      {
        _view.LabelNamaBarang.Text = "-";
        _view.LabelStokAkhir.Text = "-";
        _bindingView.DataSource.Clear();
        _bindingView.Refresh();
      }
    }
  }
}
