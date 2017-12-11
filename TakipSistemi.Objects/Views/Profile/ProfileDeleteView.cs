using TakipSistemi.Components.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace TakipSistemi.Objects
{
    public class ProfileDeleteView : BaseView
    {
        [Required]
        [NotTrimmed]
        [StringLength(32)]
        public String Password { get; set; }
    }
}
