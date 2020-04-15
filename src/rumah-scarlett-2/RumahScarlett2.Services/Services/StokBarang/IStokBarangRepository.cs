using RumahScarlett2.Domain.Models.StokBarang;
using System.Collections.Generic;

namespace RumahScarlett2.Services.Services.StokBarang
{
  public interface IStokBarangRepository : IBaseRepository<IStokBarangModel>
  {
    IEnumerable<IStokBarangModel> GetByBarangId(object id);
    IEnumerable<IStokBarangModel> GetStokBarangLogByDate(object date, object endDate = null);
  }
}
