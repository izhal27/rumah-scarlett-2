using Dapper;
using Dapper.Contrib.Extensions;
using RumahScarlett2.CommonComponents;
using RumahScarlett2.Domain.Models.TipeBarang;
using RumahScarlett2.Services.Services.TipeBarang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Infrastructure.DataAccess.Repositories.TipeBarang
{
  public class TipeBarangRepository : BaseRepository<ITipeBarangModel>, ITipeBarangRepository
  {

    public TipeBarangRepository()
    {
      _modelName = "tipe barang";
    }

    public void Insert(ITipeBarangModel model)
    {
      var dataAccessStatus = new DataAccessStatus();

      using (var context = new DbContext())
      {
        ValidateModel(context, model, dataAccessStatus);

        Insert(model, () => context.Conn.Insert((TipeBarangModel)model), dataAccessStatus,
              () => CheckAfterInsert(context, "SELECT COUNT(1) FROM tipe_barang WHERE nama=@nama "
                                     + "AND id=(SELECT LAST_INSERT_ROWID())",
                                     new { model.nama }));
      }
    }

    public void Update(ITipeBarangModel model)
    {
      var dataAccessStatus = new DataAccessStatus();

      using (var context = new DbContext())
      {
        ValidateModel(context, model, dataAccessStatus);

        Update(model, () => context.Conn.Update((TipeBarangModel)model), dataAccessStatus,
              () => CheckModelExist(context, model.id));
      }
    }

    public void Delete(ITipeBarangModel model)
    {
      var dataAccessStatus = new DataAccessStatus();

      using (var context = new DbContext())
      {
        Delete(model, () => context.Conn.Delete((TipeBarangModel)model), dataAccessStatus,
              () => CheckModelExist(context, model.id));
      }
    }

    public IEnumerable<ITipeBarangModel> GetAll()
    {
      var dataAccessStatus = new DataAccessStatus();

      using (var context = new DbContext())
      {
        return GetAll(() => context.Conn.GetAll<TipeBarangModel>(), dataAccessStatus);
      }
    }

    public ITipeBarangModel GetById(object id)
    {
      var dataAccessStatus = new DataAccessStatus();

      using (var context = new DbContext())
      {
        return GetBy(() => context.Conn.Get<TipeBarangModel>(id), dataAccessStatus,
                    () => CheckModelExist(context, id));
      }
    }

    private void ValidateModel(DbContext context, ITipeBarangModel model, DataAccessStatus dataAccessStatus)
    {
      var existsNama = context.Conn.ExecuteScalar<bool>("SELECT COUNT(1) FROM tipe_barang WHERE nama=@nama AND id!=@id",
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
      return CheckModelExist(context, "SELECT COUNT(1) FROM tipe_barang WHERE id=@id",
                                               new { id });
    }
  }
}
