﻿using Microsoft.AspNetCore.Mvc;
using TakipSistemi.Components.Mvc;
using TakipSistemi.Components.Security;
using TakipSistemi.Objects;
using TakipSistemi.Resources.Views.Administration.Accounts.AccountView;
using TakipSistemi.Services;
using TakipSistemi.Validators;

namespace TakipSistemi.Controllers
{
    [AllowUnauthorized]
    public class ProfileController : ValidatedController<IAccountValidator, IAccountService>
    {
        public ProfileController(IAccountValidator validator, IAccountService service)
            : base(validator, service)
        {
        }

        [HttpGet]
        public ActionResult Edit()
        {
            if (!Service.IsActive(CurrentAccountId))
                return RedirectToAction("Logout", "Auth");

            return View(Service.Get<ProfileEditView>(CurrentAccountId));
        }

        [HttpPost]
        public ActionResult Edit([BindExcludeId] ProfileEditView profile)
        {
            if (!Service.IsActive(CurrentAccountId))
                return RedirectToAction("Logout", "Auth");

            if (!Validator.CanEdit(profile))
                return View(profile);

            Service.Edit(profile);

            Alerts.AddSuccess(Messages.ProfileUpdated, 4000);

            return RedirectToAction("Edit");
        }

        [HttpGet]
        public ActionResult Delete()
        {
            if (!Service.IsActive(CurrentAccountId))
                return RedirectToAction("Logout", "Auth");

            Alerts.AddWarning(Messages.ProfileDeleteDisclaimer);

            return View();
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed([BindExcludeId] ProfileDeleteView profile)
        {
            if (!Service.IsActive(CurrentAccountId))
                return RedirectToAction("Logout", "Auth");

            if (!Validator.CanDelete(profile))
            {
                Alerts.AddWarning(Messages.ProfileDeleteDisclaimer);

                return View();
            }

            Service.Delete(CurrentAccountId);

            Authorization?.Refresh();

            return RedirectToAction("Logout", "Auth");
        }
    }
}
