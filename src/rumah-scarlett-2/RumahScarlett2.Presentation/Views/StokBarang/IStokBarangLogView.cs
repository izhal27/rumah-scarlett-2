using System;
using System.Windows.Forms;

namespace RumahScarlett2.Presentation.Views.StokBarang
{
  public interface IStokBarangLogView : IDataView
  {
    DateTimePicker DateTimePickerTanggal { get; }
    Label LabelTotalMasuk { get; }
    Label LabelTotalKeluar { get; }
    event EventHandler<EventArgs> OnButtonTampilkanClick;
  }
}
