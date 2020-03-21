using Dapper;
using Dapper.Contrib.Extensions;
using RumahScarlett2.CommonComponents;
using RumahScarlett2.Domain.Models.Barang;
using RumahScarlett2.Services.Services.Barang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Infrastructure.DataAccess.Repositories.Barang
{
  public class BarangRepository : BaseRepository<IBarangModel>, IBarangRepository
  {
    public BarangRepository()
    {
      _modelName = "barang";
    }

    public void Insert(IBarangModel model)
    {
      var dataAccessStatus = new DataAccessStatus();

      using (var context = new DbContext())
      {
        ValidateModel(context, model, dataAccessStatus);

        Insert(model, () => context.Conn.Insert((BarangModel)model), dataAccessStatus,
              () => CheckAfterInsert(context, "SELECT COUNT(1) FROM barang WHERE nama=@nama "
                                     + "AND id=(SELECT LAST_INSERT_ROWID())",
                                     new { model.nama }));
      }
    }

    public void Update(IBarangModel model)
    {
      var dataAccessStatus = new DataAccessStatus();

      using (var context = new DbContext())
      {
        ValidateModel(context, model, dataAccessStatus);

        Update(model, () => context.Conn.Update((BarangModel)model), dataAccessStatus,
              () => CheckModelExist(context, model.id));
      }
    }

    public void Delete(IBarangModel model)
    {
      var dataAccessStatus = new DataAccessStatus();

      using (var context = new DbContext())
      {
        Delete(model, () => context.Conn.Delete((BarangModel)model), dataAccessStatus,
              () => CheckModelExist(context, model.id));
      }
    }

    public IEnumerable<IBarangModel> GetAll()
    {
      var dataAccessStatus = new DataAccessStatus();

      using (var context = new DbContext())
      {
        return GetAll(() => context.Conn.GetAll<BarangModel>(), dataAccessStatus);
      }
    }

    public IBarangModel GetById(object id)
    {
      var dataAccessStatus = new DataAccessStatus();

      using (var context = new DbContext())
      {
        return GetBy(() => context.Conn.Get<BarangModel>(id), dataAccessStatus,
                    () => CheckModelExist(context, id));
      }
    }

    private void ValidateModel(DbContext context, IBarangModel model, DataAccessStatus dataAccessStatus)
    {
      var existsNama = context.Conn.ExecuteScalar<bool>("SELECT COUNT(1) FROM barang WHERE nama=@nama AND id!=@id",
                                                          new { model.nama, model.id });

      if (existsNama)
      {
        dataAccessStatus.Status = "Error";
        dataAccessStatus.CustomMessage = StringHelper.DuplicateEntry("nama", _modelName);

        throw new DataAccessException(dataAccessStatus); ;
      }
    }

    private bool CheckModelExist(DbContext context, object id)
    {
      return CheckModelExist(context, "SELECT COUNT(1) FROM barang WHERE id=@id",
                                               new { id });
    }
  }
}
