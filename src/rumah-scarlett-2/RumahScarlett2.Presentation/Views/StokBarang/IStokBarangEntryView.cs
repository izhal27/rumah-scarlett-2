using RumahScarlett2.Presentation.Views.CommonControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Presentation.Views.StokBarang
{
   public interface IStokBarangEntryView : IEntryView
   {
    BaseTextBoxDigit TextBoxStokAwal { get; }
    BaseTextBoxDigit TextBoxStokAkhir { get; }
  }
}
