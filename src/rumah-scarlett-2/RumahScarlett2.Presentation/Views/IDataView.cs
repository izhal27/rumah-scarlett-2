using RumahScarlett2.CommonComponents;
using RumahScarlett2.Presentation.Views.CommonControls;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Presentation.Views
{
   public interface IDataView : IView
   {
      event EventHandler OnLoadData;
      event EventHandler OnButtonTambahClick;
      event EventHandler OnButtonUbahClick;
      event EventHandler OnButtonHapusClick;
      event EventHandler OnButtonRefreshClick;
      event EventHandler OnButtonCetakClick;
      event EventHandler<CellClickEventArgs> OnDataGridCellDoubleClick;

      ListDataGrid ListDataGrid { get; }
   }
}
