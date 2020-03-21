using System.Collections.Generic;

namespace RumahScarlett2.Services.Services
{
   public interface IModelDataAnnotationCheck
   {
      void ValidateModel<TDomainModel>(TDomainModel domainModel);
      void ValidateModels<TDomainModel>(IEnumerable<TDomainModel> listDomainModel);
   }
}