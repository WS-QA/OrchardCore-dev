#pragma checksum "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\Items\SiteSettingsDeploymentStep.Fields.Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34d86e97979e23b621987938305ccabb2dc759e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_SiteSettingsDeploymentStep_Fields_Summary), @"mvc.1.0.view", @"/Views/Items/SiteSettingsDeploymentStep.Fields.Summary.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 11 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\_ViewImports.cshtml"
using OrchardCore.DisplayManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\_ViewImports.cshtml"
using OrchardCore.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\_ViewImports.cshtml"
using OrchardCore.Settings.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34d86e97979e23b621987938305ccabb2dc759e6", @"/Views/Items/SiteSettingsDeploymentStep.Fields.Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a236d10a4baf1622c31f49aa557d92a4f546201", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_SiteSettingsDeploymentStep_Fields_Summary : OrchardCore.DisplayManagement.Razor.RazorPage<OrchardCore.DisplayManagement.Views.ShapeViewModel<OrchardCore.Settings.Deployment.SiteSettingsDeploymentStep>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\Items\SiteSettingsDeploymentStep.Fields.Summary.cshtml"
  
    var settings = Model.Value.Settings;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h5>");
#nullable restore
#line 7 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\Items\SiteSettingsDeploymentStep.Fields.Summary.cshtml"
Write(T["Site Settings"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\n");
#nullable restore
#line 9 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\Items\SiteSettingsDeploymentStep.Fields.Summary.cshtml"
 if (settings != null && settings.Length > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\Items\SiteSettingsDeploymentStep.Fields.Summary.cshtml"
     foreach (var setting in settings)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"badge badge-info\">");
#nullable restore
#line 13 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\Items\SiteSettingsDeploymentStep.Fields.Summary.cshtml"
                                  Write(setting);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 14 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\Items\SiteSettingsDeploymentStep.Fields.Summary.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\Items\SiteSettingsDeploymentStep.Fields.Summary.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span class=\"badge badge-warning\">");
#nullable restore
#line 18 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\Items\SiteSettingsDeploymentStep.Fields.Summary.cshtml"
                                 Write(T["No settings selected."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 19 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\Items\SiteSettingsDeploymentStep.Fields.Summary.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrchardCore.DisplayManagement.Views.ShapeViewModel<OrchardCore.Settings.Deployment.SiteSettingsDeploymentStep>> Html { get; private set; }
    }
}
#pragma warning restore 1591