#pragma checksum "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Account\ActiveCode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3db3f51245f82215b0e6fb7de2a3b8b6c8756e8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ActiveCode), @"mvc.1.0.view", @"/Views/Account/ActiveCode.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ActiveCode.cshtml", typeof(AspNetCore.Views_Account_ActiveCode))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3db3f51245f82215b0e6fb7de2a3b8b6c8756e8b", @"/Views/Account/ActiveCode.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ActiveCode : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Account\ActiveCode.cshtml"
  
    ViewData["Title"] = "ActiveCode";

#line default
#line hidden
            BeginContext(46, 69, true);
            WriteLiteral("<h2>ActiveCode</h2>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 7 "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Account\ActiveCode.cshtml"
         if (ViewBag.Issuccess)
        {

#line default
#line hidden
            BeginContext(159, 189, true);
            WriteLiteral("            <div class=\"alert alert-success text-center\">\r\n                <h4> کاربر گرامی حساب شما با موفقیت فعال شد </h4>\r\n                <a href=\"/Login\">ورود</a>\r\n            </div>\r\n");
            EndContext();
#line 13 "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Account\ActiveCode.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(384, 131, true);
            WriteLiteral("            <div class=\"alert alert-danger text-center\">\r\n                <h4> حساب شما غیر فعال می باشد</h4>\r\n            </div>\r\n");
            EndContext();
#line 19 "C:\Users\HP\Desktop\User_Login\UserInformation.App\UserInformation\Views\Account\ActiveCode.cshtml"
        }

#line default
#line hidden
            BeginContext(526, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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