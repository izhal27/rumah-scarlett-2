﻿using RumahScarlett2.Presentation.Views.Tentang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Presentation.Presenters.Tentang
{
   public class TentangPresenter : ITentangPresenter
   {
      private ITentangView _view;

      public ITentangView GetView
      {
         get { return _view; }
      }

      public TentangPresenter()
      {
         _view = new TentangView();
      }
   }
}
