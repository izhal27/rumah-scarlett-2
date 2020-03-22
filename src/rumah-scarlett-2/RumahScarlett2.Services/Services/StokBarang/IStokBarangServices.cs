using RumahScarlett2.Domain.Models.StokBarang;
using System.Collections.Generic;

namespace RumahScarlett2.Services.Services.StokBarang
{
  public interface IStokBarangServices : IBaseServices<IStokBarangModel>
  {
    IEnumerable<IStokBarangModel> GetByBarangId(object id);
  }
}
