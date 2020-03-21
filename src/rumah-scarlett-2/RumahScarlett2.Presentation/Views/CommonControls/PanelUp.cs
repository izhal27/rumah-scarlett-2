﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahScarlett2.Presentation.Views.CommonControls
{
   public partial class PanelUp : UserControl
   {
      public string LabelInfo
      {
         get { return labelInfo.Text; }
         set { labelInfo.Text = value.Trim(); }
      }

      public PanelUp()
      {
         InitializeComponent();
         TabStop = false;
      }

      protected override void OnCreateControl()
      {
         base.OnCreateControl();
         panelInfo.BackColor = Color.FromArgb(67, 78, 84);
         labelInfo.ForeColor = Color.FromArgb(240, 240, 240);
    }
   }
}
