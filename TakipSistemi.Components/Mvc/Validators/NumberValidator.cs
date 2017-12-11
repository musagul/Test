using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using TakipSistemi.Resources.Form;
using System;

namespace TakipSistemi.Components.Mvc
{
    public class NumberValidator : IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes["data-val"] = "true";
            context.Attributes["data-val-number"] = String.Format(Validations.Numeric, context.ModelMetadata.GetDisplayName());
        }
    }
}
