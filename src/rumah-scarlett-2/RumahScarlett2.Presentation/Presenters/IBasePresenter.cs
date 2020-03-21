using RumahScarlett2.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Presentation.Presenters
{
   public interface IBasePresenter<TView> where TView : IView
   {
      TView GetView { get; }
   }
}
