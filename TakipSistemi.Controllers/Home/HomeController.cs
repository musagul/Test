using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TakipSistemi.Components.Security;
using TakipSistemi.Services;

namespace TakipSistemi.Controllers
{
    [AllowUnauthorized]
    public class HomeController : ServicedController<IAccountService>
    {
        public HomeController(IAccountService service)
            : base(service)
        {
        }

        [HttpGet]
        public ActionResult Index()
        {
            if (!Service.IsActive(CurrentAccountId))
                return RedirectToAction("Logout", "Auth");

            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public ViewResult Error()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public new ViewResult NotFound()
        {
            return View();
        }

        [HttpGet]
        public new ActionResult Unauthorized()
        {
            if (!Service.IsActive(CurrentAccountId))
                return RedirectToAction("Logout", "Auth");

            return View();
        }
    }
}
