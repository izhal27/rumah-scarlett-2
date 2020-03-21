using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RumahScarlett2.Domain.Models.TipeBarang;

namespace RumahScarlett2.Services.Services.TipeBarang
{
  public class TipeBarangServices : ITipeBarangServices
  {
    private ITipeBarangRepository _repo;
    private IModelDataAnnotationCheck _modelDAC;

    public TipeBarangServices(ITipeBarangRepository repo, IModelDataAnnotationCheck modelDAC)
    {
      _repo = repo;
      _modelDAC = modelDAC;
    }

    public void Insert(ITipeBarangModel model)
    {
      ValidateModel(model);
      _repo.Insert(model);
    }

    public void Update(ITipeBarangModel model)
    {
      ValidateModel(model);
      _repo.Update(model);
    }

    public void Delete(ITipeBarangModel model)
    {
      _repo.Delete(model);
    }

    public IEnumerable<ITipeBarangModel> GetAll()
    {
      return _repo.GetAll();
    }

    public ITipeBarangModel GetById(object id)
    {
      return _repo.GetById(id);
    }

    public void ValidateModel(ITipeBarangModel model)
    {
      _modelDAC.ValidateModel(model);
    }
  }
}
