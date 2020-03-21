using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RumahScarlett2.CommonComponents;

namespace RumahScarlett2.Presentation.Views.CommonControls
{
   public partial class OperationButtons : UserControl
   {
      public event EventHandler OnSaveButtonClick;
      public event EventHandler OnCloseButtonClick;

      public Button ButtonSave
      {
         get { return btnSave; }
      }

      public Button ButtonCancel
      {
         get { return btnCancel; }
      }

      public OperationButtons()
      {
         InitializeComponent();
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         OnSaveButtonClick?.Invoke(sender, e);
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         OnCloseButtonClick?.Invoke(sender, e);
      }
   }
}
