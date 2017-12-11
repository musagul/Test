using Microsoft.AspNetCore.Mvc;
using TakipSistemi.Components.Lookups;
using TakipSistemi.Components.Mvc;
using TakipSistemi.Components.Security;
using TakipSistemi.Data.Core;
using TakipSistemi.Objects;
using NonFactors.Mvc.Lookup;
using System;

namespace TakipSistemi.Controllers
{
    [AllowUnauthorized]
    public class LookupController : BaseController
    {
        private IUnitOfWork UnitOfWork { get; }

        public LookupController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        [NonAction]
        public virtual JsonResult GetData(MvcLookup lookup, LookupFilter filter)
        {
            lookup.Filter = filter;

            return Json(lookup.GetData());
        }

        [AjaxOnly]
        public JsonResult Role(LookupFilter filter)
        {
            return GetData(new MvcLookup<Role, RoleView>(UnitOfWork), filter);
        }

        protected override void Dispose(Boolean disposing)
        {
            UnitOfWork.Dispose();

            base.Dispose(disposing);
        }
    }
}
