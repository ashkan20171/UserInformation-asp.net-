#pragma checksum "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Shared\_ForgetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69e0e3d7515a2b5d1ba770aee9e0e7ba51eeb8f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ForgetPassword), @"mvc.1.0.view", @"/Views/Shared/_ForgetPassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ForgetPassword.cshtml", typeof(AspNetCore.Views_Shared__ForgetPassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69e0e3d7515a2b5d1ba770aee9e0e7ba51eeb8f1", @"/Views/Shared/_ForgetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ForgetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserInformation.Identity.MyUsers.Users>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 221, true);
            WriteLiteral("<div style=\"background-color: #c0c0c0; color:#FCFCFF; text-align: center; padding: 20px; margin: 30px; direction: rtl; border-radius: 8px;\">\r\n    <p style=\"font-size: 19px; background-color: #F4DC03;color: #575555\"> عزیز ");
            EndContext();
            BeginContext(269, 14, false);
#line 3 "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Shared\_ForgetPassword.cshtml"
                                                                          Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(283, 208, true);
            WriteLiteral("</p>\r\n    <p style=\"font-size: 19px;\">با سلام</p>\r\n    <h3> جهت بازیابی کلمه عبور به لینک زیر مراجعه بفرمایید</h3>\r\n    <a style=\"background-color: White; color: #38C0EF; font-size: 19px; border-radius: 2px;\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 491, "\"", 561, 2);
            WriteAttributeValue("", 498, "https://localhost:44305/account/ResetPassword/", 498, 46, true);
#line 6 "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Shared\_ForgetPassword.cshtml"
WriteAttributeValue("", 544, Model.ActiveCode, 544, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(562, 463, true);
            WriteLiteral(@">بازیابی کلمه عبور </a>
</div>
<div style=""margin-top: 2px;text-align: right;  padding:2px 6px 6px 6px; direction: rtl;"">
    <p style=""text-align: center;"">------------------------------------</p>
    <p style=""text-align: center;"">----------------------</p>
    <p style=""text-align: center;font-weight: bold"">
        با احترام
        مرکز پشتیبانی آسان کد
    </p>
    <p style=""text-align: center;font-weight: bold"">https://Asancode.com</p>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserInformation.Identity.MyUsers.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591