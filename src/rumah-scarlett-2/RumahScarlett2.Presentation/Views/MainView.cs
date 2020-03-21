using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RumahScarlett2.Presentation.Views
{
  public partial class MainView : DockContent, IMainView
  {
    public MenuStrip MenuStrip => throw new NotImplementedException();

    public ToolStrip ToolStrip => throw new NotImplementedException();

    public StatusStrip StatusStrip => throw new NotImplementedException();

    public event EventHandler OnViewLoad;
    public event EventHandler<MainViewEventArgs> OnTipeViewClick;
    public event EventHandler<MainViewEventArgs> OnBarangViewClick;
    public event EventHandler<MainViewEventArgs> OnStokBarangViewClick;
    public event EventHandler OnTentangViewClick;

    public MainView()
    {
      InitializeComponent();
    }

  }
}
