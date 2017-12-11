using Genny;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TakipSistemi.Web.Templates
{
    [GennyModuleDescriptor("Default system module template")]
    public class Module : GennyModule
    {
        [GennyParameter(0, Required = true)]
        public String Model { get; set; }

        [GennyParameter(1, Required = true)]
        public String Controller { get; set; }

        [GennyParameter(2, Required = false)]
        public String Area { get; set; }

        public Module(IServiceProvider services)
            : base(services)
        {
        }

        public override void Run()
        {
            String path = (Area != null ? Area + "/" : "") + Controller;
            Dictionary<String, GennyScaffoldingResult> results = new Dictionary<String, GennyScaffoldingResult>();

            results.Add($"../TakipSistemi.Controllers/{path}/{Controller}Controller.cs", Scaffold("Controllers/Controller"));
            results.Add($"../../test/TakipSistemi.Tests/Unit/Controllers/{path}/{Controller}ControllerTests.cs", Scaffold("Tests/ControllerTests"));

            results.Add($"../TakipSistemi.Objects/Models/{path}/{Model}.cs", Scaffold("Objects/Model"));
            results.Add($"../TakipSistemi.Objects/Views/{path}/{Model}View.cs", Scaffold("Objects/View"));

            results.Add($"../TakipSistemi.Services/{path}/{Model}Service.cs", Scaffold("Services/Service"));
            results.Add($"../TakipSistemi.Services/{path}/I{Model}Service.cs", Scaffold("Services/IService"));
            results.Add($"../../test/TakipSistemi.Tests/Unit/Services/{path}/{Model}ServiceTests.cs", Scaffold("Tests/ServiceTests"));

            results.Add($"../TakipSistemi.Validators/{path}/{Model}Validator.cs", Scaffold("Validators/Validator"));
            results.Add($"../TakipSistemi.Validators/{path}/I{Model}Validator.cs", Scaffold("Validators/IValidator"));
            results.Add($"../../test/TakipSistemi.Tests/Unit/Validators/{path}/{Model}ValidatorTests.cs", Scaffold("Tests/ValidatorTests"));

            results.Add($"../TakipSistemi.Web/Views/{path}/Index.cshtml", Scaffold("Web/Index"));
            results.Add($"../TakipSistemi.Web/Views/{path}/Create.cshtml", Scaffold("Web/Create"));
            results.Add($"../TakipSistemi.Web/Views/{path}/Details.cshtml", Scaffold("Web/Details"));
            results.Add($"../TakipSistemi.Web/Views/{path}/Edit.cshtml", Scaffold("Web/Edit"));
            results.Add($"../TakipSistemi.Web/Views/{path}/Delete.cshtml", Scaffold("Web/Delete"));

            if (results.Any(result => result.Value.Errors.Any()))
            {
                foreach (GennyScaffoldingResult result in results.Select(x => x.Value))
                    foreach (String error in result.Errors)
                        Logger.Write($"    {error}");

                Logger.Write("Scaffolding failed! Rolling back...");
            }
            else
            {
                TryWrite(results);

                Logger.Write("Scaffolded successfully!");
            }
        }

        private GennyScaffoldingResult Scaffold(String path)
        {
            return Scaffolder.Scaffold("Templates/Module/" + path, new ModuleModel(Model, Controller, Area));
        }
    }
}
