using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahScarlett2.Presentation.Views.CommonControls
{
   public class BaseTextBoxDigit : IntegerTextBox
   {
      protected override void OnEnter(EventArgs e)
      {
         if (!ReadOnly)
         {
            BackColor = Color.AliceBlue;
         }
      }

      protected override void OnLeave(EventArgs e)
      {
         if (!ReadOnly)
         {
            BackColor = SystemColors.Window;
         }
      }
   }
}
