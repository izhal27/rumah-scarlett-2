﻿using RumahScarlett2.Presentation.Presenters;
using RumahScarlett2.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumahScarlett2.Presentation
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run((Form)new MainPresenter().GetView);
      }
   }
}
