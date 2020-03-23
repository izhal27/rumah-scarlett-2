using RumahScarlett2.CommonComponents;
using RumahScarlett2.Domain.Models.Barang;
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

    public BaseTextBoxDigit TextBoxStokAwal
    {
      get { return textBoxStokAwal; }
    }

    public BaseTextBoxDigit TextBoxStokAkhir
    {
      get { return textBoxStokAkhir; }
    }

    public StokBarangEntryView(bool isNewData = true, int barangID = 0,
      IStokBarangModel model = null, IBarangModel barangModel = null)
    {
      InitializeComponent();
      _isNewData = isNewData;
      _barangID = barangID;
      panelUp.LabelInfo = isNewData ? $"TAMBAH {_typeName.ToUpper()}" : $"UBAH {_typeName.ToUpper()}";

      if (!_isNewData)
      {
        _model = model;
        textBoxStokAwal.IntegerValue = model.stok_awal;
        dateTimePickerTanggal.Value = model.tanggal;
        textBoxBarangMasuk.IntegerValue = model.barang_masuk;
        textBoxBarangKeluar.IntegerValue = model.barang_keluar;
        textBoxStokAkhir.IntegerValue = model.stok_akhir;

        textBoxStokAwal.ReadOnly = false;
        textBoxStokAkhir.ReadOnly = false;
      }
      else
      {
        if (barangModel != null)
        {
          textBoxStokAwal.IntegerValue = barangModel.stok_akhir;
          textBoxBarangMasuk.IntegerValue = 0;
          textBoxBarangKeluar.IntegerValue = 0;
          textBoxStokAkhir.IntegerValue = barangModel.stok_akhir;
        }
      }

      operationButtons.OnSaveButtonClick += OperationButtons_OnSaveButtonClick;
    }


    private void StokBarangEntryView_Load(object sender, EventArgs e)
    {
      textBoxBarangMasuk.TextChanged += textBox_TextChanged;
      textBoxBarangKeluar.TextChanged += textBox_TextChanged;
    }

    private void textBox_TextChanged(object sender, EventArgs e)
    {
      int stokAwal = (int)textBoxStokAwal.IntegerValue;
      int barangMasuk = (int)textBoxBarangMasuk.IntegerValue;
      int barangKeluar = (int)textBoxBarangKeluar.IntegerValue;
      int stokAkhir = (stokAwal + barangMasuk) - barangKeluar;
      textBoxStokAkhir.IntegerValue = stokAkhir;
    }

    private void OperationButtons_OnSaveButtonClick(object sender, EventArgs e)
    {
      var model = new StokBarangModel
      {
        barang_id = _barangID,
        tanggal = dateTimePickerTanggal.Value,
        stok_awal = (int)textBoxStokAwal.IntegerValue,
        barang_masuk = (int)textBoxBarangMasuk.IntegerValue,
        barang_keluar = (int)textBoxBarangKeluar.IntegerValue,
        stok_akhir = (int)textBoxStokAkhir.IntegerValue
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
