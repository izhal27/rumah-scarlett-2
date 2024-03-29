﻿using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahScarlett2.Presentation.Views.CommonControls
{
   public class BaseTextBox : TextBoxExt
   {
      protected override void OnEnter(EventArgs e)
      {
         base.OnEnter(e);
         if (!ReadOnly)
         {
            BackColor = Color.AliceBlue;
         }
      }

      protected override void OnLeave(EventArgs e)
      {
         base.OnLeave(e);
         if (!ReadOnly)
         {
            BackColor = SystemColors.Window;
         }
      }

      public override string Text
      {
         get
         {
            return base.Text.Trim();
         }

         set
         {
            base.Text = value != null ? value.Trim() : string.Empty;
         }
      }
   }
}
