using RumahScarlett2.CommonComponents;
using RumahScarlett2.Domain.Models.TipeBarang;
using RumahScarlett2.Presentation.Helper;
using RumahScarlett2.Presentation.Views.CommonControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahScarlett2.Presentation.Views.TipeBarang
{
   public partial class TipeEntryView : BaseEntryView, ITipeBarangEntryView
   {
      private bool _isNewData;
      private ITipeBarangModel _model;
      public event EventHandler OnSaveData;
      private static string _typeName = "Tipe Barang";

      public TipeEntryView(bool isNewData = true, ITipeBarangModel model = null)
      {
         InitializeComponent();
         _isNewData = isNewData;
         panelUp.LabelInfo = isNewData ?  $"TAMBAH {_typeName.ToUpper()}" : $"UBAH {_typeName.ToUpper()}";

         if (!_isNewData)
         {
            _model = model;
            textBoxNama.Text = model.nama;
            textBoxKeterangan.Text = model.keterangan;
         }

         operationButtons.OnSaveButtonClick += OperationButtons_OnSaveButtonClick;
      }

      private void OperationButtons_OnSaveButtonClick(object sender, EventArgs e)
      {
         var model = new TipeBarangModel
         {
            nama = textBoxNama.Text,
            keterangan = textBoxKeterangan.Text
         };

         var modelArgs = new ModelEventArgs<TipeBarangModel>(model);

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
