using Microsoft.AspNetCore.Mvc.ModelBinding;
using TakipSistemi.Components.Alerts;
using System;

namespace TakipSistemi.Validators
{
    public interface IValidator : IDisposable
    {
        ModelStateDictionary ModelState { get; set; }
        Int32 CurrentAccountId { get; set; }
        AlertsContainer Alerts { get; set; }
    }
}
