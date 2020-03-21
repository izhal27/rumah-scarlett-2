using RumahScarlett2.Domain.Models.TipeBarang;
using RumahScarlett2.Services.Services;
using RumahScarlett2.Services.Services.TipeBarang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Services.UnitTests.TipeBarang
{
  public class TipeBarangServicesFixture : BaseServicesFixture<ITipeBarangModel, ITipeBarangServices>
  {
    public TipeBarangServicesFixture()
    {
      Model = new TipeBarangModel();
      Services = new TipeBarangServices(null, new ModelDataAnnotationCheck());
    }
  }
}
