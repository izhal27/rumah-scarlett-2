using RumahScarlett2.Presentation.Helper;
using RumahScarlett2.Presentation.Presenters.Barang;
using RumahScarlett2.Presentation.Presenters.TipeBarang;
using RumahScarlett2.Presentation.Presenters.StokBarang;
using RumahScarlett2.Presentation.Views;
using System;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RumahScarlett2.Presentation.Presenters
{
  public class MainPresenter : IMainPresenter
  {
    private IMainView _view;

    public IMainView GetView
    {
      get { return _view; }
    }

    public MainPresenter()
    {
      _view = new MainView();

      _view.OnViewLoad += _view_OnViewLoad;

      // Data
      _view.OnTipeViewClick += _view_OnTipeViewClick;
      _view.OnBarangViewClick += _view_OnBarangViewClick;
      _view.OnStokBarangViewClick += _view_OnStokBarangViewClick;
    }

    private void _view_OnViewLoad(object sender, EventArgs e)
    {
      //
    }

    private void _view_OnTipeViewClick(object sender, MainViewEventArgs e)
    {
      var view = (DockContent)new TipeBarangPresenter().GetView;
      ShowChildForm(view, e);
    }

    private void _view_OnBarangViewClick(object sender, MainViewEventArgs e)
    {
      var view = (DockContent)new BarangPresenter().GetView;
      ShowChildForm(view, e);
    }

    private void _view_OnStokBarangViewClick(object sender, MainViewEventArgs e)
    {
      var view = (DockContent)new StokBarangPresenter().GetView;
      ShowChildForm(view, e);
    }

    /// <summary>
    /// Method untuk menampilkan Form child
    /// </summary>
    /// <param name="form">Form child</param>
    private void ShowChildForm(DockContent form, MainViewEventArgs e)
    {
      using (new WaitCursorHandler())
      {
        // List form yang active
        var formList = ((Form)_view).MdiChildren;

        // Cek jika form belum ada di list, maka buka form baru,
        // sebaliknya aktifkan form jika sudah ada.
        if (!formList.Any(frm => frm.Name == form.Name))
        {
          form.Owner = ((Form)_view);
          form.Show(e.DockPanel, DockState.Document);
        }
        else
        {
          var activeForm = formList.Where(frm => frm.Name == form.Name)
                           .FirstOrDefault();
          activeForm.Activate();
        }
      }
    }
  }
}
