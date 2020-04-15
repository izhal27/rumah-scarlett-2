using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RumahScarlett2.CommonComponents;
using RumahScarlett2.Domain.Models.StokBarang;
using RumahScarlett2.Infrastructure.DataAccess.Repositories.StokBarang;
using RumahScarlett2.Services.Services;
using RumahScarlett2.Services.Services.StokBarang;
using RumahScarlett2.Services.UnitTests.CommonTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace RumahScarlett2.Services.UnitTests.StokBarang
{
  [Trait("Category", "Data Access Validations")]
  public class StokServicesDataAccessTests
  {
    private IStokBarangServices _services;
    private readonly ITestOutputHelper _testOutputHelper;

    public StokServicesDataAccessTests(ITestOutputHelper testOutputHelper)
    {
      _testOutputHelper = testOutputHelper;
      _services = new StokBarangServices(new StokBarangRepository(), new ModelDataAnnotationCheck());
    }

    [Fact]
    private void ShouldReturnSuccessForInsert()
    {
      var operationSucceded = false;
      var dataAccessJsonStr = string.Empty;
      var formattedJsonStr = string.Empty;

      try
      {
        for (int i = 1; i <= 3; i++)
        {
          var model = new StokBarangModel()
          {
            tanggal = DateTime.Now,
            barang_id = i,
            barang_masuk = 5,
            barang_keluar = 10
          };

          _services.Insert(model);
        }

        operationSucceded = true;
      }
      catch (DataAccessException ex)
      {
        operationSucceded = ex.DataAccessStatusInfo.OperationSucceeded;
        dataAccessJsonStr = JsonConvert.SerializeObject(ex.DataAccessStatusInfo);
        formattedJsonStr = JToken.Parse(dataAccessJsonStr).ToString();
      }

      try
      {
        Assert.True(operationSucceded);
        _testOutputHelper.WriteLine("Data berhasil ditambahkan.");
      }
      finally
      {
        _testOutputHelper.WriteLine(formattedJsonStr);
      }
    }

    [Fact]
    private void ShouldReturnSuccessForUpdate()
    {
      var operationSecceded = false;
      var dataAccessJsonStr = string.Empty;
      var formattedJsonStr = string.Empty;

      try
      {
        var model = new StokBarangModel()
        {
          id = 3,
          tanggal = DateTime.Now,
          barang_id = 3,
          stok_awal = 100,
          barang_masuk = 10,
          barang_keluar = 10,
          stok_akhir = 100
        };

        _services.Update(model);
        operationSecceded = true;
      }
      catch (DataAccessException ex)
      {
        operationSecceded = ex.DataAccessStatusInfo.OperationSucceeded;
        dataAccessJsonStr = JsonConvert.SerializeObject(ex.DataAccessStatusInfo);
        formattedJsonStr = JToken.Parse(dataAccessJsonStr).ToString();
      }

      try
      {
        Assert.True(operationSecceded);
        _testOutputHelper.WriteLine("Data berhasil diubah.");
      }
      finally
      {
        _testOutputHelper.WriteLine(formattedJsonStr);
      }
    }

    [Fact]
    private void ShouldReturnSuccessForDelete()
    {
      var operationSecceded = false;
      var dataAccessJsonStr = string.Empty;
      var formattedJsonStr = string.Empty;

      try
      {
        var model = new StokBarangModel()
        {
          id = 3,
        };

        _services.Delete(model);
        operationSecceded = true;
      }
      catch (DataAccessException ex)
      {
        operationSecceded = ex.DataAccessStatusInfo.OperationSucceeded;
        dataAccessJsonStr = JsonConvert.SerializeObject(ex.DataAccessStatusInfo);
        formattedJsonStr = JToken.Parse(dataAccessJsonStr).ToString();
      }

      try
      {
        Assert.True(operationSecceded);
        _testOutputHelper.WriteLine("Data berhasil dihapus.");
      }
      finally
      {
        _testOutputHelper.WriteLine(formattedJsonStr);
      }
    }

    [Fact]
    public void ShouldReturnListOfModels()
    {
      var listModels = _services.GetAll().ToList();

      Assert.NotEmpty(listModels);

      TestsHelper.WriteListModels(_testOutputHelper, listModels);
    }

    [Fact]
    public void ShouldReturnListOfModelsByBarangId()
    {
      var listModels = _services.GetByBarangId(1).ToList();

      Assert.NotEmpty(listModels);

      TestsHelper.WriteListModels(_testOutputHelper, listModels);
    }

    [Fact]
    public void ShouldReturnModelMatchingId()
    {
      StokBarangModel model = null;
      var idToGet = 1;

      try
      {
        model = (StokBarangModel)_services.GetById(idToGet);
      }
      catch (DataAccessException ex)
      {
        _testOutputHelper.WriteLine(ex.DataAccessStatusInfo.GetFormatedValues());
      }

      Assert.True(model != null);
      Assert.True(model.id == idToGet);

      if (model != null)
      {
        TestsHelper.WriteModel(_testOutputHelper, model);
      }
    }
    
    [Fact]
    public void ShouldReturnListOfStokBarangLogModels()
    {
      var listModels = _services.GetStokBarangLogByDate(DateTime.Now).ToList();

      Assert.NotEmpty(listModels);

      TestsHelper.WriteListModels(_testOutputHelper, listModels);
    }

    [Fact]
    public void ShouldReturnListOfStokBarangLogModelsBetweenDate()
    {
      var listModels = _services.GetStokBarangLogByDate(DateTime.Now.AddDays(-10), DateTime.Now).ToList();

      Assert.NotEmpty(listModels);

      TestsHelper.WriteListModels(_testOutputHelper, listModels);
    }
  }
}
