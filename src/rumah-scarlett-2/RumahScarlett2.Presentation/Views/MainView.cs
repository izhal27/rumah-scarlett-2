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
    private DockPanel _dockPanel;
    private MainViewEventArgs _eventArgs;

    public event EventHandler OnViewLoad;
    public event EventHandler<MainViewEventArgs> OnTipeViewClick;
    public event EventHandler<MainViewEventArgs> OnBarangViewClick;
    public event EventHandler<MainViewEventArgs> OnStokBarangViewClick;
    public event EventHandler OnTentangViewClick;

    public MainView()
    {
      InitializeComponent();

      _dockPanel = new DockPanel();
      _dockPanel.Parent = this;
      _dockPanel.Dock = DockStyle.Fill;
      _dockPanel.BackgroundImageLayout = ImageLayout.Stretch;
      _dockPanel.BringToFront();
      _dockPanel.DocumentTabStripLocation = DocumentTabStripLocation.Top;
      _dockPanel.AllowEndUserDocking = false;
      _dockPanel.AllowEndUserNestedDocking = false;
      _dockPanel.ShowDocumentIcon = false;
      _dockPanel.DockBackColor = Color.Transparent;

      // Jika gambar di config file tidak kosong dan file gambar tersedia,
      // atur gambar ke DockPanel BackgroudImage
      //var gambar = MainProgram.Pengaturan.path_background;
      //if (!string.IsNullOrWhiteSpace(gambar) && File.Exists(gambar))
      //  _dockPanel.BackgroundImage = Image.FromFile(gambar);

      _eventArgs = new MainViewEventArgs(_dockPanel);
    }

    private void MainView_Load(object sender, EventArgs e)
    {
      toolStripStatusLabel.Text = DateTime.Now.ToShortDateString();
      OnViewLoad?.Invoke(sender, e);
    }

    private void tipeBarangToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OnTipeViewClick?.Invoke(sender, _eventArgs);
    }

    private void barangToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OnBarangViewClick?.Invoke(sender, _eventArgs);
    }

    private void stokBarangToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OnStokBarangViewClick?.Invoke(sender, _eventArgs);
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OnTentangViewClick?.Invoke(sender, _eventArgs);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void stokBarangToolStripButton_Click(object sender, EventArgs e)
    {
      OnStokBarangViewClick?.Invoke(sender, _eventArgs);
    }

    private void barangToolStripButton_Click(object sender, EventArgs e)
    {
      OnBarangViewClick?.Invoke(sender, _eventArgs);
    }

    private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      OnTentangViewClick?.Invoke(sender, e);
    }

    private void exitToolStripButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
}
}
