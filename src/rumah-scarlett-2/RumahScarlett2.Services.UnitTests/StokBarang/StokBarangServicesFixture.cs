using RumahScarlett2.Domain.Models.StokBarang;
using RumahScarlett2.Services.Services;
using RumahScarlett2.Services.Services.StokBarang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Services.UnitTests.StokBarang
{
  public class StokBarangServicesFixture : BaseServicesFixture<IStokBarangModel, IStokBarangServices>
  {
    public StokBarangServicesFixture()
    {
      Model = new StokBarangModel();
      Services = new StokBarangServices(null, new ModelDataAnnotationCheck());
    }
  }
}
