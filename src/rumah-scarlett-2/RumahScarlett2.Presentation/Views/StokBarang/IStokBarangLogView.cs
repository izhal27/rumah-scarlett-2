using System;
using System.Windows.Forms;

namespace RumahScarlett2.Presentation.Views.StokBarang
{
  public interface IStokBarangLogView : IDataView
  {
    bool TanggalChecked { get; }
    DateTimePicker DateTimePickerTanggal { get; }
    DateTimePicker DateTimePickerStart { get; }
    DateTimePicker DateTimePickerEnd { get; }
    Label LabelTotalMasuk { get; }
    Label LabelTotalKeluar { get; }
    event EventHandler<EventArgs> OnButtonTampilkanClick;
  }
}
