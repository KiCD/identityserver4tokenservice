#pragma checksum "C:\WORK\_exploration\openidconnect\identityserver4tokenservice\Views\Account\LoggedOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dec1a93fe05f76ae085be793aa2cfbb3fe82fab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(identityserver4tokenservice.Pages.Account.Views_Account_LoggedOut), @"mvc.1.0.view", @"/Views/Account/LoggedOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/LoggedOut.cshtml", typeof(identityserver4tokenservice.Pages.Account.Views_Account_LoggedOut))]
namespace identityserver4tokenservice.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\WORK\_exploration\openidconnect\identityserver4tokenservice\Views\_ViewImports.cshtml"
using identityserver4tokenservice;

#line default
#line hidden
#line 1 "C:\WORK\_exploration\openidconnect\identityserver4tokenservice\Views\Account\LoggedOut.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dec1a93fe05f76ae085be793aa2cfbb3fe82fab", @"/Views/Account/LoggedOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596e9b1521df8230807442947580d97819de6f2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_LoggedOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityServer4.Quickstart.UI.LoggedOutViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signout-redirect.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(93, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\WORK\_exploration\openidconnect\identityserver4tokenservice\Views\Account\LoggedOut.cshtml"
   
    // set this so the layout rendering sees an anonymous user
    ViewData["signed-out"] = true;

#line default
#line hidden
            BeginContext(198, 119, true);
            WriteLiteral("\n<div class=\"page-header logged-out\">\n    <h1>\n        Logout\n        <small>You are now logged out</small>\n    </h1>\n\n");
            EndContext();
#line 15 "C:\WORK\_exploration\openidconnect\identityserver4tokenservice\Views\Account\LoggedOut.cshtml"
     if (Model.PostLogoutRedirectUri != null)
    {

#line default
#line hidden
            BeginContext(369, 64, true);
            WriteLiteral("        <div>\n            Click <a class=\"PostLogoutRedirectUri\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 433, "\"", 468, 1);
#line 18 "C:\WORK\_exploration\openidconnect\identityserver4tokenservice\Views\Account\LoggedOut.cshtml"
WriteAttributeValue("", 440, Model.PostLogoutRedirectUri, 440, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(469, 45, true);
            WriteLiteral(">here</a> to return to the\n            <span>");
            EndContext();
            BeginContext(515, 16, false);
#line 19 "C:\WORK\_exploration\openidconnect\identityserver4tokenservice\Views\Account\LoggedOut.cshtml"
             Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(531, 36, true);
            WriteLiteral("</span> application.\n        </div>\n");
            EndContext();
#line 21 "C:\WORK\_exploration\openidconnect\identityserver4tokenservice\Views\Account\LoggedOut.cshtml"
    }

#line default
#line hidden
            BeginContext(573, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 23 "C:\WORK\_exploration\openidconnect\identityserver4tokenservice\Views\Account\LoggedOut.cshtml"
     if (Model.SignOutIframeUrl != null)
    {

#line default
#line hidden
            BeginContext(621, 52, true);
            WriteLiteral("        <iframe width=\"0\" height=\"0\" class=\"signout\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 673, "\"", 702, 1);
#line 25 "C:\WORK\_exploration\openidconnect\identityserver4tokenservice\Views\Account\LoggedOut.cshtml"
WriteAttributeValue("", 679, Model.SignOutIframeUrl, 679, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(703, 11, true);
            WriteLiteral("></iframe>\n");
            EndContext();
#line 26 "C:\WORK\_exploration\openidconnect\identityserver4tokenservice\Views\Account\LoggedOut.cshtml"
    }

#line default
#line hidden
            BeginContext(720, 8, true);
            WriteLiteral("</div>\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(746, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 31 "C:\WORK\_exploration\openidconnect\identityserver4tokenservice\Views\Account\LoggedOut.cshtml"
     if (Model.AutomaticRedirectAfterSignOut)
    {

#line default
#line hidden
                BeginContext(799, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(807, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dec1a93fe05f76ae085be793aa2cfbb3fe82fab7213", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(855, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 34 "C:\WORK\_exploration\openidconnect\identityserver4tokenservice\Views\Account\LoggedOut.cshtml"
    }

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityServer4.Quickstart.UI.LoggedOutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591