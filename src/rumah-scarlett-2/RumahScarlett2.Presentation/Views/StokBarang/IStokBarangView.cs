using System;
using System.Windows.Forms;

namespace RumahScarlett2.Presentation.Views.StokBarang
{
  public interface IStokBarangView : IDataView
  {
    TreeView TreeViewTipeBarang { get; }
    Label LabelNamaBarang { get; }
    Label LabelStokAkhir { get; }
    event EventHandler<TreeViewEventArgs> OnTreeViewAfterSelect;
  }
}
