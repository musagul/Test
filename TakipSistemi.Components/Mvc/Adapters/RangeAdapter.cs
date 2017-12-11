﻿using Microsoft.AspNetCore.Mvc.DataAnnotations.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using TakipSistemi.Resources.Form;
using System;
using System.ComponentModel.DataAnnotations;

namespace TakipSistemi.Components.Mvc
{
    public class RangeAdapter : RangeAttributeAdapter
    {
        public RangeAdapter(RangeAttribute attribute)
            : base(attribute, null)
        {
        }

        public override String GetErrorMessage(ModelValidationContextBase context)
        {
            Attribute.ErrorMessage = Validations.Range;

            return GetErrorMessage(context.ModelMetadata);
        }
    }
}
