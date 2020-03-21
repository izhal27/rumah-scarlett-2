using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RumahScarlett2.Presentation.Views
{
  public interface IMainView : IView
  {
    event EventHandler OnViewLoad;
    event EventHandler<MainViewEventArgs> OnTipeViewClick;
    event EventHandler<MainViewEventArgs> OnBarangViewClick;
    event EventHandler<MainViewEventArgs> OnStokBarangViewClick;
    event EventHandler OnTentangViewClick;
  }

  public class MainViewEventArgs : EventArgs
  {
    public DockPanel DockPanel { get; }

    public MainViewEventArgs(DockPanel dockPanel)
    {
      DockPanel = dockPanel;
    }
  }
}
