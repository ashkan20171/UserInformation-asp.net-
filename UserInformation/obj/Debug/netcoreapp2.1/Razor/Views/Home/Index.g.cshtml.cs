#pragma checksum "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36717a61a87fe769f4a906262f0f00309c617066"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36717a61a87fe769f4a906262f0f00309c617066", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Home\Index.cshtml"
  

    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 156, true);
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-10 bg-light\">\r\n            <div id=\"menu-list\">\r\n                <ul id=\"list\">\r\n");
            EndContext();
#line 10 "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Home\Index.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
            BeginContext(279, 105, true);
            WriteLiteral("                        <li class=\"d-inline-block text-center\">\r\n                            <a href=\"#\">");
            EndContext();
            BeginContext(385, 18, false);
#line 13 "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Home\Index.cshtml"
                                   Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(403, 205, true);
            WriteLiteral(" | خوش آمدید</a>\r\n                        </li>\r\n                        <li class=\"d-inline-block text-center\">\r\n                            <a href=\"/LogOut\">LogOut |</a>\r\n                        </li>\r\n");
            EndContext();
#line 18 "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(680, 324, true);
            WriteLiteral(@"                        <li class=""d-inline-block text-center mr-3"">
                            <a href=""/Register"">Register |</a>
                        </li>
                        <li class=""d-inline-block text-center mr-3"">
                            <a href=""/Login"">Login |</a>
                        </li>
");
            EndContext();
#line 27 "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1027, 498, true);
            WriteLiteral(@"                </ul>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-10 bg-blue text-center mb-md-5"">
            <h1>
                <i class=""fa fa-home bg-success""></i>
                <code>|</code> Hello WellCom Home Page
            </h1>
            <img src=""/Images/api.jpg"" alt=""landingImage"" class=""img-fluid"">
            <p class=""alert-warning"">this Education is for Login and Register</p>
        </div>
    </div>
</div>");
            EndContext();
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