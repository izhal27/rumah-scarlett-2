using Dapper;
using Dapper.Contrib.Extensions;
using RumahScarlett2.CommonComponents;
using RumahScarlett2.Domain.Models.Barang;
using RumahScarlett2.Domain.Models.StokBarang;
using RumahScarlett2.Services.Services.StokBarang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Infrastructure.DataAccess.Repositories.StokBarang
{
  public class StokBarangRepository : BaseRepository<IStokBarangModel>, IStokBarangRepository
  {
    public StokBarangRepository()
    {
      _modelName = "stok barang";
    }

    public void Insert(IStokBarangModel model)
    {
      var dataAccessStatus = new DataAccessStatus();

      using (var context = new DbContext())
      {
        context.BeginTransaction();

        Insert(model, () =>
        {
          var queryStr = "INSERT INTO stok_barang (tanggal, barang_id, stok_awal, barang_masuk, barang_keluar, stok_akhir) " +
                         "VALUES (@tanggal, @barang_id, @stok_awal, @barang_masuk, @barang_keluar, @stok_akhir);" +
                         "SELECT LAST_INSERT_ROWID();";

          var barang = context.Conn.Get<BarangModel>(model.barang_id);

          if (barang == null)
          {
            var ex = new DataAccessException(dataAccessStatus);
            SetDataAccessValues(ex, "Salah satu barang yang ingin ditambahkan ke dalam tabel stok barang tidak ditemukan.");
            throw ex;
          }

          var stok_awal = barang.stok_akhir;
          var stok_akhir = (stok_awal + model.barang_masuk) - model.barang_keluar;

          var insertedId = context.Conn.Query<uint>(queryStr, new
          {
            model.tanggal,
            model.barang_id,
            stok_awal,
            model.barang_masuk,
            model.barang_keluar,
            stok_akhir
          }, context.Transaction).Single();

          if (insertedId > 0)
          {
            barang.stok_akhir = stok_akhir;
            context.Conn.Update(barang, context.Transaction);
            context.Commit();
          }
        }, dataAccessStatus,
        () => CheckAfterInsert(context, "SELECT COUNT(1) FROM stok_barang WHERE tanggal=@tanggal "
                               + "AND id=(SELECT id FROM stok_barang ORDER BY ID DESC LIMIT 1)",
                               new { model.tanggal }));
      }
    }

    public void Update(IStokBarangModel model)
    {
      var dataAccessStatus = new DataAccessStatus();

      using (var context = new DbContext())
      {
        Update(model, () => context.Conn.Update((StokBarangModel)model), dataAccessStatus,
              () => CheckModelExist(context, model.id));
      }
    }

    public void Delete(IStokBarangModel model)
    {
      var dataAccessStatus = new DataAccessStatus();

      using (var context = new DbContext())
      {
        context.BeginTransaction();

        var barangModel = context.Conn.Get<BarangModel>(model.barang_id);
        if (barangModel != null)
        {
          barangModel.stok_akhir = (barangModel.stok_akhir + model.barang_keluar) - model.barang_masuk;
          context.Conn.Update(barangModel);
        }

        Delete(model, () => context.Conn.Delete((StokBarangModel)model), dataAccessStatus,
              () => CheckModelExist(context, model.id));

        context.Commit();
      }
    }

    public IEnumerable<IStokBarangModel> GetAll()
    {
      //var dataAccessStatus = new DataAccessStatus();

      //using (var context = new DbContext())
      //{
      //  var queryStr = "SELECT * FROM stok_barang ORDER BY tanggal DESC";
      //  return GetAll(() => context.Conn.Query<StokBarangModel>(queryStr), dataAccessStatus);
      //}
      throw new NotImplementedException();
    }

    public IStokBarangModel GetById(object id)
    {
      var dataAccessStatus = new DataAccessStatus();

      using (var context = new DbContext())
      {
        return GetBy(() => context.Conn.Get<StokBarangModel>(id), dataAccessStatus,
                    () => CheckModelExist(context, id));
      }
    }

    public IEnumerable<IStokBarangModel> GetByBarangId(object id)
    {
      var dataAccessStatus = new DataAccessStatus();

      using (var context = new DbContext())
      {
        var queryStr = "SELECT * FROM stok_barang WHERE barang_id = @id ORDER BY id DESC";
        return GetAll(() => context.Conn.Query<StokBarangModel>(queryStr, new { id }), dataAccessStatus);
      }
    }

    public IEnumerable<IStokBarangModel> GetStokBarangLogByDate(object date, object endDate = null)
    {
      var dataAccessStatus = new DataAccessStatus();

      using (var context = new DbContext())
      {
        string queryStr = "SELECT sb.barang_id [id], sb.tanggal, b.nama [barang_nama], SUM(sb.barang_masuk) [barang_masuk], " +
                       "SUM(sb.barang_keluar) [barang_keluar] " +
                       "FROM stok_barang as sb LEFT JOIN barang as b on sb.barang_id = b.id " +
                       "WHERE {WHERE} " +
                       "GROUP BY sb.barang_id " +
                       "ORDER BY sb.barang_id";
        object param = null;
        var dateStr = ((DateTime)date).ToString("yyyy-MM-dd");

        if (endDate == null)
        {
          queryStr = queryStr.Replace("{WHERE}", "date(sb.tanggal) = @date");
          param = new { date = dateStr };
        }
        else
        {
          var endDateStr = ((DateTime)endDate).ToString("yyyy-MM-dd");
          queryStr = queryStr.Replace("{WHERE}", "date(sb.tanggal) BETWEEN @date and @enddate");
          param = new { date = dateStr, enddate = endDateStr };
        }

        return GetAll(() => context.Conn.Query<StokBarangLogModel>(queryStr, param), dataAccessStatus);
      }
    }

    private bool CheckModelExist(DbContext context, object id)
    {
      return CheckModelExist(context, "SELECT COUNT(1) FROM stok_barang WHERE id=@id",
                                               new { id });
    }
  }
}
