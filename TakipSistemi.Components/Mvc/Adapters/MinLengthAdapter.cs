﻿using Microsoft.AspNetCore.Mvc.DataAnnotations.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using TakipSistemi.Resources.Form;
using System;
using System.ComponentModel.DataAnnotations;

namespace TakipSistemi.Components.Mvc
{
    public class MinLengthAdapter : MinLengthAttributeAdapter
    {
        public MinLengthAdapter(MinLengthAttribute attribute)
            : base(attribute, null)
        {
        }

        public override String GetErrorMessage(ModelValidationContextBase context)
        {
            Attribute.ErrorMessage = Validations.MinLength;

            return base.GetErrorMessage(context);
        }
    }
}
