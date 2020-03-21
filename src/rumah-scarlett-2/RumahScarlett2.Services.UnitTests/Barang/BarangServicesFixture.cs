using RumahScarlett2.Domain.Models.Barang;
using RumahScarlett2.Services.Services;
using RumahScarlett2.Services.Services.Barang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Services.UnitTests.Barang
{
   public class BarangServicesFixture: BaseServicesFixture<IBarangModel, IBarangServices>
   {
      public BarangServicesFixture()
      {
         Model = new BarangModel();
         Services = new BarangServices(null, new ModelDataAnnotationCheck());
      }
   }
}
