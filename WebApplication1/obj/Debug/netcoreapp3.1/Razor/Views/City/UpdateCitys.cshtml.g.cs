#pragma checksum "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\City\UpdateCitys.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b495d6262f166faad5a7833e0f58c0abf9c0609"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_City_UpdateCitys), @"mvc.1.0.view", @"/Views/City/UpdateCitys.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b495d6262f166faad5a7833e0f58c0abf9c0609", @"/Views/City/UpdateCitys.cshtml")]
    public class Views_City_UpdateCitys : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Storage.Entity.City>
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
#line 2 "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\City\UpdateCitys.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b495d6262f166faad5a7833e0f58c0abf9c06092971", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>UpdateCity</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b495d6262f166faad5a7833e0f58c0abf9c06094035", async() => {
                WriteLiteral("\r\n    <div>\r\n");
#nullable restore
#line 15 "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\City\UpdateCitys.cshtml"
         using (Html.BeginForm("Update", "City", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input id=\"CityId\" name=\"CityId\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 363, "\"", 380, 1);
#nullable restore
#line 17 "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\City\UpdateCitys.cshtml"
WriteAttributeValue("", 371, Model.Id, 371, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
                WriteLiteral("            <label>???????????????? ????????????: </label>\r\n            <input id=\"Name\" type=\"text\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 486, "\"", 505, 1);
#nullable restore
#line 20 "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\City\UpdateCitys.cshtml"
WriteAttributeValue("", 494, Model.Name, 494, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br /><br />\r\n            <label>?????????????????? ????????????: </label>\r\n            <input id=\"People\" type=\"text\" name=\"People\"");
                BeginWriteAttribute("value", " value=\"", 626, "\"", 647, 1);
#nullable restore
#line 22 "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\City\UpdateCitys.cshtml"
WriteAttributeValue("", 634, Model.People, 634, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br /><br />\r\n            <input type=\"submit\" value=\"?????????????????? ??????????????????\" />\r\n");
#nullable restore
#line 24 "C:\Users\wowdi\source\repos\WebApplication1\WebApplication1\Views\City\UpdateCitys.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <a href=\"/City/ShowCitys\">??????????????????</a><br /><br />\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Storage.Entity.City> Html { get; private set; }
    }
}
#pragma warning restore 1591
