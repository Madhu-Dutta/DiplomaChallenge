#pragma checksum "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\Expenses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d19adcd0ae62e127d6e47ab66d80bb1f91221ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GameGroupApp.Pages.Expenses.Pages_Expenses_Index), @"mvc.1.0.razor-page", @"/Pages/Expenses/Index.cshtml")]
namespace GameGroupApp.Pages.Expenses
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
#line 1 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\_ViewImports.cshtml"
using GameGroupApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\_ViewImports.cshtml"
using GameGroupApp.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d19adcd0ae62e127d6e47ab66d80bb1f91221ab", @"/Pages/Expenses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e252780fe03c71f02578349acbce6d5f71858407", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Expenses_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\Expenses\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Expenses</h1>\r\n\r\n");
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\Expenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Record[0].UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\Expenses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Record[0].Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 30 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\Expenses\Index.cshtml"
         if (Model.ViewTypeSelected == IndexModel.ViewType.Totals)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\Expenses\Index.cshtml"
             foreach (var item in Model.Totals)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 39 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\Expenses\Index.cshtml"
                   Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\Expenses\Index.cshtml"
                   Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\Expenses\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\Expenses\Index.cshtml"
             
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\Expenses\Index.cshtml"
             foreach (var item in Model.Record)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 58 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\Expenses\Index.cshtml"
                   Write(item.User.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 61 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\Expenses\Index.cshtml"
                   Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 64 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\Expenses\Index.cshtml"
                   Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 72 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\Expenses\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\Madhu\source\repos\DiplomaChallange\GameGroupApp\Pages\Expenses\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameGroupApp.Pages.Expenses.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GameGroupApp.Pages.Expenses.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GameGroupApp.Pages.Expenses.IndexModel>)PageContext?.ViewData;
        public GameGroupApp.Pages.Expenses.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
