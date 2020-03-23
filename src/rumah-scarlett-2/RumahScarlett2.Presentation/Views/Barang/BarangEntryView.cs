using RumahScarlett2.CommonComponents;
using RumahScarlett2.Domain.Models.Barang;
using RumahScarlett2.Domain.Models.TipeBarang;
using RumahScarlett2.Presentation.Helper;
using RumahScarlett2.Presentation.Views.CommonControls;
using System;

namespace RumahScarlett2.Presentation.Views.Barang
{
  public partial class BarangEntryView : BaseEntryView, IBarangEntryView
  {
    private bool _isNewData;
    private IBarangModel _model;
    public event EventHandler OnSaveData;
    private static string _typeName = "Barang";

    public BarangEntryView(bool isNewData = true, IBarangModel model = null)
    {
      InitializeComponent();

      _isNewData = isNewData;
      panelUp.LabelInfo = isNewData ? $"TAMBAH {_typeName.ToUpper()}" : $"UBAH {_typeName.ToUpper()}";

      if (!_isNewData)
      {
        _model = model;
      }

      operationButtons.OnSaveButtonClick += OperationButtons_OnSaveButtonClick;
    }

    private void BarangEntryView_Load(object sender, EventArgs e)
    {
      if (!_isNewData && _model != null)
      {
        comboBoxTipe.SelectedItem = new TipeBarangModel { id = _model.tipe_id };
        textBoxNama.Text = _model.nama;
        textBoxStokAkhir.Text = _model.stok_akhir.ToString("N0");
        textBoxKeterangan.Text = _model.keterangan;
      }
    }

    private void OperationButtons_OnSaveButtonClick(object sender, EventArgs e)
    {
      var model = new BarangModel
      {
        tipe_id = comboBoxTipe.SelectedItem.id,
        nama = textBoxNama.Text,
        stok_akhir = int.Parse(textBoxStokAkhir.Text),
        keterangan = textBoxKeterangan.Text
      };

      var modelArgs = new ModelEventArgs<BarangModel>(model);

      if (_isNewData)
      {
        if (Messages.ConfirmSave(_typeName))
        {
          OnSaveData?.Invoke(this, modelArgs);
        }
      }
      else if (Messages.ConfirmUpdate(_typeName))
      {
        model.id = _model.id;
        OnSaveData?.Invoke(this, modelArgs);
      }
    }
  }
}
