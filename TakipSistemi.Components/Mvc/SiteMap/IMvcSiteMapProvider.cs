using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TakipSistemi.Components.Mvc
{
    public interface IMvcSiteMapProvider
    {
        IEnumerable<MvcSiteMapNode> GetSiteMap(ViewContext context);
        IEnumerable<MvcSiteMapNode> GetBreadcrumb(ViewContext context);
    }
}
