#pragma checksum "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f25231dedd09fa3129f5da9e4b81dfbc8a8a942"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SiteSettings_Edit), @"mvc.1.0.view", @"/Views/SiteSettings.Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f25231dedd09fa3129f5da9e4b81dfbc8a8a942", @"/Views/SiteSettings.Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a236d10a4baf1622c31f49aa557d92a4f546201", @"/Views/_ViewImports.cshtml")]
    public class Views_SiteSettings_Edit : OrchardCore.DisplayManagement.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"edit-item\">\n    <div class=\"edit-item-primary\">\n");
#nullable restore
#line 3 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.Edit.cshtml"
         if (Model.Content != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"edit-item-content\">\n                ");
#nullable restore
#line 6 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.Edit.cshtml"
           Write(await DisplayAsync(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 8 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n\n    <div class=\"edit-item-secondary group\">\n");
#nullable restore
#line 12 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.Edit.cshtml"
         if (Model.Actions != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"edit-item-actions form-group\">\n                ");
#nullable restore
#line 15 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.Edit.cshtml"
           Write(await DisplayAsync(Model.Actions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 17 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.Edit.cshtml"
         if (Model.Sidebar != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"edit-item-sidebar group\">\n                ");
#nullable restore
#line 21 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.Edit.cshtml"
           Write(await DisplayAsync(Model.Sidebar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 23 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n\n");
#nullable restore
#line 27 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.Edit.cshtml"
 if (!String.IsNullOrWhiteSpace(Context.Request.Query["returnUrl"]))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.Edit.cshtml"
Write(Html.Hidden("returnUrl", Context.Request.Query["returnUrl"]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\EUA\C_sharp_big\OrchardCore-dev\src\OrchardCore.Modules\OrchardCore.Settings\Views\SiteSettings.Edit.cshtml"
                                                                 
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
