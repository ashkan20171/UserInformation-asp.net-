#pragma checksum "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Account\SuccessRegister.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c270a6441ef557e631cef9f21ab6330d797a5ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SuccessRegister), @"mvc.1.0.view", @"/Views/Account/SuccessRegister.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/SuccessRegister.cshtml", typeof(AspNetCore.Views_Account_SuccessRegister))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c270a6441ef557e631cef9f21ab6330d797a5ef", @"/Views/Account/SuccessRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SuccessRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserInformation.Identity.MyUsers.Users>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Account\SuccessRegister.cshtml"
  
    ViewData["Title"] = "SuccessRegister";

#line default
#line hidden
            BeginContext(98, 146, true);
            WriteLiteral("<h2>SuccessRegister</h2>\r\n<div class=\"container\">\r\n    <div class=\"col col-md-12 bg-success \">\r\n        <h1 class=\"text-center text-white\"> عزیز  ");
            EndContext();
            BeginContext(245, 14, false);
#line 8 "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Account\SuccessRegister.cshtml"
                                             Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(259, 163, true);
            WriteLiteral(" </h1>\r\n        <br />\r\n        <h3 class=\"text-warning text-center\">ثبت شما با موفقیت انجام شد</h3>\r\n        <h5 class=\"text-center text-white\">مراجعه بفرمایید   ");
            EndContext();
            BeginContext(423, 11, false);
#line 11 "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Account\SuccessRegister.cshtml"
                                                        Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(434, 63, true);
            WriteLiteral("  لطفا جهت ادامه مراحل ثبت نام  به    </h5>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserInformation.Identity.MyUsers.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
