#pragma checksum "C:\Users\PICHAU\Desktop\cryptocurrencyAccenture\CRYPTOCURRENCY EXCHANGE RECOMMENDATION\CRYPTOCURRENCY EXCHANGE RECOMMENDATION\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aaa9f6433355d375488aeea7101c70c4d5eeb10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\PICHAU\Desktop\cryptocurrencyAccenture\CRYPTOCURRENCY EXCHANGE RECOMMENDATION\CRYPTOCURRENCY EXCHANGE RECOMMENDATION\Views\_ViewImports.cshtml"
using CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\PICHAU\Desktop\cryptocurrencyAccenture\CRYPTOCURRENCY EXCHANGE RECOMMENDATION\CRYPTOCURRENCY EXCHANGE RECOMMENDATION\Views\Home\Index.cshtml"
using CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aaa9f6433355d375488aeea7101c70c4d5eeb10", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4be3df6cfa793b4f5b13557b70106ae588fa2cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExchangeClass>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PICHAU\Desktop\cryptocurrencyAccenture\CRYPTOCURRENCY EXCHANGE RECOMMENDATION\CRYPTOCURRENCY EXCHANGE RECOMMENDATION\Views\Home\Index.cshtml"
  
    ViewBag.Titulo = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Crypto currency recomendation</h1>\r\n    <div>\r\n        ");
#nullable restore
#line 11 "C:\Users\PICHAU\Desktop\cryptocurrencyAccenture\CRYPTOCURRENCY EXCHANGE RECOMMENDATION\CRYPTOCURRENCY EXCHANGE RECOMMENDATION\Views\Home\Index.cshtml"
   Write(Html.DropDownList("TradeItems", null, new { onchange = "funcChamada1();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        &nbsp;\r\n        ");
#nullable restore
#line 13 "C:\Users\PICHAU\Desktop\cryptocurrencyAccenture\CRYPTOCURRENCY EXCHANGE RECOMMENDATION\CRYPTOCURRENCY EXCHANGE RECOMMENDATION\Views\Home\Index.cshtml"
   Write(Html.DropDownList("CoinItems", null, new { onchange = "funcChamada2()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        &nbsp;\r\n    </div>\r\n</div>\r\n<script>\r\n    function funcChamada1() {\r\n        $(\"#TradeItems\").ready(function () {\r\n            var val = $(\"#TradeItems\").val();\r\n            $.ajax({\r\n                type: \"POST\",\r\n                url: \'");
#nullable restore
#line 23 "C:\Users\PICHAU\Desktop\cryptocurrencyAccenture\CRYPTOCURRENCY EXCHANGE RECOMMENDATION\CRYPTOCURRENCY EXCHANGE RECOMMENDATION\Views\Home\Index.cshtml"
                 Write(Url.Action("ChamadaTrade"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: { valor: val },
                success: function (result) {
                    console.log(result);
                },
                error: function (result) {
                    console.log(""erro"");
                }
            });
        });
    }
    function funcChamada2() {
        $(""#CoinItems"").ready(function () {
            var val = $(""#CoinItems"").val();
            $.ajax({
                type: ""POST"",
                url: '");
#nullable restore
#line 39 "C:\Users\PICHAU\Desktop\cryptocurrencyAccenture\CRYPTOCURRENCY EXCHANGE RECOMMENDATION\CRYPTOCURRENCY EXCHANGE RECOMMENDATION\Views\Home\Index.cshtml"
                 Write(Url.Action("ChamadaCoin"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: { valor: val },
                success: function (result) {
                    console.log(result);
                },
                error: function (result) {
                    console.log(""erro"");
                }
            });
        });
    }
   
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExchangeClass> Html { get; private set; }
    }
}
#pragma warning restore 1591
