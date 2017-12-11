﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using TakipSistemi.Resources.Form;
using System;

namespace TakipSistemi.Components.Mvc
{
    public class DateValidator : IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes["data-val"] = "true";
            context.Attributes["data-val-date"] = String.Format(Validations.Date, context.ModelMetadata.GetDisplayName());
        }
    }
}
