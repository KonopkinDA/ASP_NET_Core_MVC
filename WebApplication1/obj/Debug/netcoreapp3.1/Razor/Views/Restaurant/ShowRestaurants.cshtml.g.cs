#pragma checksum "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\Restaurant\ShowRestaurants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "348121b4f4a5514e03dce591b41b494cf0af3e6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurant_ShowRestaurants), @"mvc.1.0.view", @"/Views/Restaurant/ShowRestaurants.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"348121b4f4a5514e03dce591b41b494cf0af3e6d", @"/Views/Restaurant/ShowRestaurants.cshtml")]
    public class Views_Restaurant_ShowRestaurants : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Storage.Entity.Restaurant>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\Restaurant\ShowRestaurants.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "348121b4f4a5514e03dce591b41b494cf0af3e6d3050", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ShowRestaurants</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "348121b4f4a5514e03dce591b41b494cf0af3e6d4119", async() => {
                WriteLiteral("\r\n    <div>\r\n        <h1>??????????????????</h1>\r\n");
#nullable restore
#line 16 "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\Restaurant\ShowRestaurants.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label>ID: </label>");
#nullable restore
#line 18 "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\Restaurant\ShowRestaurants.cshtml"
                          Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            <label>???????????????? ??????????????????:  </label>");
#nullable restore
#line 19 "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\Restaurant\ShowRestaurants.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            <label>???????????????????? ??????????:  </label>");
#nullable restore
#line 20 "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\Restaurant\ShowRestaurants.cshtml"
                                         Write(item.Stars);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            <label>??????????: </label>");
#nullable restore
#line 21 "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\Restaurant\ShowRestaurants.cshtml"
                             Write(item.CityFor.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 579, "\"", 624, 2);
                WriteAttributeValue("", 586, "/Restaurant/UpdateRestaurants/", 586, 30, true);
#nullable restore
#line 22 "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\Restaurant\ShowRestaurants.cshtml"
WriteAttributeValue("", 616, item.Id, 616, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">?????????????????????????? ????????????????</a><br />\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 674, "\"", 718, 2);
                WriteAttributeValue("", 681, "/Restaurant/DeleteRestaurant/", 681, 29, true);
#nullable restore
#line 23 "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\Restaurant\ShowRestaurants.cshtml"
WriteAttributeValue("", 710, item.Id, 710, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">?????????????? ????????????????</a><br />\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 762, "\"", 801, 2);
                WriteAttributeValue("", 769, "/Veranda/CreateVerandas/", 769, 24, true);
#nullable restore
#line 24 "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\Restaurant\ShowRestaurants.cshtml"
WriteAttributeValue("", 793, item.Id, 793, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">???????????????? ??????????????</a><br /><br />\r\n");
#nullable restore
#line 25 "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\Restaurant\ShowRestaurants.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <a href=\"/Veranda/ShowVerandas\">???????????????? ??????????????</a><br /><br />\r\n    <a href=\"/Restaurant/FindRestaurants\">?????????? ??????????????????</a><br /><br />\r\n    <a href=\"/City/ShowCitys\">?????????????????? ?? ??????????????</a><br /><br />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Storage.Entity.Restaurant>> Html { get; private set; }
    }
}
#pragma warning restore 1591
