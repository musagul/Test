﻿using Microsoft.AspNetCore.Mvc.Filters;
using TakipSistemi.Services;
using System;

namespace TakipSistemi.Controllers
{
    public abstract class ServicedController<TService> : BaseController
        where TService : IService
    {
        public TService Service { get; }

        protected ServicedController(TService service)
        {
            Service = service;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            Service.CurrentAccountId = CurrentAccountId;
        }

        protected override void Dispose(Boolean disposing)
        {
            Service.Dispose();

            base.Dispose(disposing);
        }
    }
}
