using Microsoft.AspNetCore.Mvc.DataAnnotations.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using TakipSistemi.Resources.Form;
using System;
using System.ComponentModel.DataAnnotations;

namespace TakipSistemi.Components.Mvc
{
    public class RequiredAdapter : RequiredAttributeAdapter
    {
        public RequiredAdapter(RequiredAttribute attribute)
            : base(attribute, null)
        {
        }

        public override String GetErrorMessage(ModelValidationContextBase context)
        {
            Attribute.ErrorMessage = Validations.Required;

            return GetErrorMessage(context.ModelMetadata);
        }
    }
}
