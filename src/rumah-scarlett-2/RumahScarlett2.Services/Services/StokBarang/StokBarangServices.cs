using RumahScarlett2.Domain.Models.StokBarang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Services.Services.StokBarang
{
  public class StokBarangServices : IStokBarangServices
  {
    private IStokBarangRepository _repo;
    private IModelDataAnnotationCheck _modelDAC;

    public StokBarangServices(IStokBarangRepository repo, IModelDataAnnotationCheck modelDAC)
    {
      _repo = repo;
      _modelDAC = modelDAC;
    }

    public void Insert(IStokBarangModel model)
    {
      ValidateModel(model);
      _repo.Insert(model);
    }

    public void Update(IStokBarangModel model)
    {
      ValidateModel(model);
      _repo.Update(model);
    }

    public void Delete(IStokBarangModel model)
    {
      _repo.Delete(model);
    }

    public IEnumerable<IStokBarangModel> GetAll()
    {
      return _repo.GetAll();
    }

    public IStokBarangModel GetById(object id)
    {
      return _repo.GetById(id);
    }

    public IEnumerable<IStokBarangModel> GetByBarangId(object id)
    {
      return _repo.GetByBarangId(id);
    }
    
    public IEnumerable<IStokBarangModel> GetStokBarangLogByDate(object date, object endDate = null)
    {
      return _repo.GetStokBarangLogByDate(date, endDate);
    }

    public void ValidateModel(IStokBarangModel model)
    {
      _modelDAC.ValidateModel(model);
    }
  }
}
