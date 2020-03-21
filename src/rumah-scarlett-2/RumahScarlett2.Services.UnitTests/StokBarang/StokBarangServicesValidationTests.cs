using Newtonsoft.Json.Linq;
using RumahScarlett2.Domain.Models.StokBarang;
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
   [Trait("Category", "Model Validations")]
   public class StokServicesValidationTests : IClassFixture<StokBarangServicesFixture>
   {
    private readonly ITestOutputHelper _testOutputHelper;
    private StokBarangServicesFixture _servicesFixture;

    public StokServicesValidationTests(StokBarangServicesFixture servicesFixture, ITestOutputHelper testOutputHelper)
    {
      _servicesFixture = servicesFixture;
      _testOutputHelper = testOutputHelper;
      SetValidSampleValues();
    }

    private void SetValidSampleValues()
    {
      _servicesFixture.Model = new StokBarangModel
      {
        id = 1,
        barang_id = 1,
        tanggal = DateTime.Now,
        stok_awal = 10,
        barang_masuk = 10,
        barang_keluar = 10,
        stok_akhir = 10
      };
    }

    [Fact]
    public void ShouldNotThrowExceptionForDefaultTestValuesOnAnnotations()
    {
      var exception = Record.Exception(() => _servicesFixture
                                             .Services.ValidateModel(_servicesFixture.Model));

      Assert.Null(exception);

      WriteExceptionTestResult(exception);
    }

    [Fact]
    public void ShouldThrowExceptionForBarangIDEmpty()
    {
      _servicesFixture.Model.barang_id = default(int);

      var exception = Record.Exception(() => _servicesFixture
                                             .Services.ValidateModel(_servicesFixture.Model));

      WriteExceptionTestResult(exception);
    }

    private void WriteExceptionTestResult(Exception exception)
    {
      TestsHelper.WriteExceptionTestResult(exception, _testOutputHelper, _servicesFixture.Model);
    }
  }
}
