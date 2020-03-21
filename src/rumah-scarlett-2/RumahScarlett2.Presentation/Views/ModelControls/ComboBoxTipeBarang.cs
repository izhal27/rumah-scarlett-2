using RumahScarlett2.Domain.Models.TipeBarang;
using RumahScarlett2.Infrastructure.DataAccess.Repositories.TipeBarang;
using RumahScarlett2.Presentation.Helper;
using RumahScarlett2.Services.Services;
using RumahScarlett2.Services.Services.TipeBarang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahScarlett2.Presentation.Views.ModelControls
{
   public partial class ComboBoxTipe : UserControl
   {
      public ITipeBarangModel SelectedItem
      {
         get
         {
            return comboBox.SelectedIndex != -1 ? (ITipeBarangModel)comboBox.SelectedItem : null;
         }
         set
         {
            if (value != null)
            {
               comboBox.SelectedItem = comboBox.Items.Cast<ITipeBarangModel>().Where(t => t.id == value.id).FirstOrDefault();
            }
         }
      }

      public ComboBoxTipe()
      {
         InitializeComponent();

         if ((LicenseManager.UsageMode != LicenseUsageMode.Designtime))
         {
            LoadDataSource();
         }
      }

      private void LoadDataSource()
      {
         var services = new TipeBarangServices(new TipeBarangRepository(), new ModelDataAnnotationCheck());
         var listTipes = services.GetAll().ToList();

         if (listTipes != null && listTipes.Count > 0)
         {
            comboBox.Items.AddRange(listTipes.ToArray());
            comboBox.DisplayMember = "nama";
            comboBox.SelectedIndex = 0;
         }
      }
   }
}
