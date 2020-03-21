using RumahScarlett2.CommonComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Presentation.Views
{
   public interface IEntryView : IView
   { 
      event EventHandler OnSaveData;
   }
}
