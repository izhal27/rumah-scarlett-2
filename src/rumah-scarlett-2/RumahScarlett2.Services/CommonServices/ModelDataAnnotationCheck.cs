using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Services.Services
{
   public class ModelDataAnnotationCheck : IModelDataAnnotationCheck
   {
      public void ValidateModel<TDomainModel>(TDomainModel model)
      {
         var validationResultList = new List<ValidationResult>();
         var validationContext = new ValidationContext(model);
         var stringBuilder = new StringBuilder();

         if (!Validator.TryValidateObject(instance: model,
                                          validationContext: validationContext,
                                          validationResults: validationResultList,
                                          validateAllProperties: true))
         {
            foreach (var validationResult in validationResultList)
            {
               stringBuilder.Append(validationResult.ErrorMessage)
                            .AppendLine();
            }
         }

         if (validationResultList.Count > 0)
         {
            throw new ArgumentException(stringBuilder.ToString());
         }
      }

      public void ValidateModels<TDomainModel>(IEnumerable<TDomainModel> models)
      {
         foreach (var model in models)
         {
            ValidateModel(model);
         }
      }
   }
}
