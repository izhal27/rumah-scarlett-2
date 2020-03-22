using RumahScarlett2.CommonComponents;
using RumahScarlett2.Domain.Models.StokBarang;
using RumahScarlett2.Presentation.Helper;
using RumahScarlett2.Presentation.Views.CommonControls;
using System;

namespace RumahScarlett2.Presentation.Views.StokBarang
{
  public partial class StokBarangEntryView : BaseEntryView, IStokBarangEntryView
  {
    private bool _isNewData;
    private int _barangID;
    private IStokBarangModel _model;
    public event EventHandler OnSaveData;
    private static string _typeName = "Stok Barang";

    public StokBarangEntryView(bool isNewData = true, int barangID = 0, IStokBarangModel model = null)
    {
      InitializeComponent();
      _isNewData = isNewData;
      _barangID = barangID;
      panelUp.LabelInfo = isNewData ? $"TAMBAH {_typeName.ToUpper()}" : $"UBAH {_typeName.ToUpper()}";

      if (!_isNewData)
      {
        _model = model;
        dateTimePickerTanggal.Value = model.tanggal;
        textBoxStokAwal.IntegerValue = model.stok_awal;
        textBoxBarangMasuk.IntegerValue = model.barang_masuk;
        textBoxBarangKeluar.IntegerValue = model.barang_keluar;
        textBoxStokAkhir.IntegerValue = model.stok_akhir;
      }

      operationButtons.OnSaveButtonClick += OperationButtons_OnSaveButtonClick;
    }

    private void OperationButtons_OnSaveButtonClick(object sender, EventArgs e)
    {
      var model = new StokBarangModel
      {
        barang_id = _barangID,
        tanggal = dateTimePickerTanggal.Value,
        barang_masuk = (int)textBoxBarangMasuk.IntegerValue,
        barang_keluar = (int)textBoxBarangKeluar.IntegerValue,
      };

      var modelArgs = new ModelEventArgs<StokBarangModel>(model);

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
        model.barang_id = _barangID;
        OnSaveData?.Invoke(this, modelArgs);
      }
    }
  }
}
