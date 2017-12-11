﻿using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Routing;
using System;

namespace TakipSistemi.Components.Mvc
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AjaxOnlyAttribute : ActionMethodSelectorAttribute
    {
        public override Boolean IsValidForRequest(RouteContext context, ActionDescriptor action)
        {
            if (context.HttpContext.Request.Headers == null)
                return false;

            return context.HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";
        }
    }
}
