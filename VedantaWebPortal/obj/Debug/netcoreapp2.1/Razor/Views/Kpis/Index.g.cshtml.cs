#pragma checksum "C:\Users\baps\source\repos\VedantaWebPortal\VedantaWebPortal\Views\Kpis\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56c0e459955270648985e8f59c663c93d805be62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kpis_Index), @"mvc.1.0.view", @"/Views/Kpis/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kpis/Index.cshtml", typeof(AspNetCore.Views_Kpis_Index))]
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
#line 1 "C:\Users\baps\source\repos\VedantaWebPortal\VedantaWebPortal\Views\_ViewImports.cshtml"
using VedantaWebPortal;

#line default
#line hidden
#line 2 "C:\Users\baps\source\repos\VedantaWebPortal\VedantaWebPortal\Views\_ViewImports.cshtml"
using VedantaWebPortal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56c0e459955270648985e8f59c663c93d805be62", @"/Views/Kpis/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afb7184c17f878475dc1a3ff643a3806dc45adf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Kpis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/piadmin/js/PlantKpis.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 3050, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-title center"">
                <h4>Plant Load Factor (PLF)</h4>
            </div>
            <div class=""card-body"">
                <div id=""plantloadfactor""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-title center"">
                <h4>Plant Availability Factor (PAF)</h4>
            </div>
            <div class=""card-body"">
                <div id=""plantAvailabilityfactor""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-2"">
        <div class=""card"">
            <div class=""card-title center"">
                <h4>Trips</h4>
            </div>
            <div class=""card-body"">
                <div id=""trips""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-2"">
        <div class=""card"">
            <div class=""card-title center"">");
            WriteLiteral(@"
                <h4>Tube Leaks</h4>
            </div>
            <div class=""card-body"">
                <div id=""tubeleaks""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-title center"">
                <h4>Gross Generation</h4>
            </div>
            <div class=""card-body"">
                <div id=""grossgeneration""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-title center"">
                <h4>Net Generation</h4>
            </div>
            <div class=""card-body"">
                <div id=""netgeneration""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-title center"">
                <h4>Aux Consumption in (%)</h4>
            </div>
            <div class=""card-body"">
                <div id=""auxconsump");
            WriteLiteral(@"tion""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-title center"">
                <h4>Gross Heat Rate</h4>
            </div>
            <div class=""card-body"">
                <div id=""grossheatrate""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-title center"">
                <h4>Gas Calorific Value(GCV)</h4>
            </div>
            <div class=""card-body"">
                <div id=""gascalorificValue""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-title center"">
                <h4>SCC 3600</h4>
            </div>
            <div class=""card-body"">
                <div id=""scc360""></div>
            </div>
        </div>
    </div>
</div>

<script>
    /**/
    var elementName = """);
            EndContext();
            BeginContext(3051, 16, false);
#line 106 "C:\Users\baps\source\repos\VedantaWebPortal\VedantaWebPortal\Views\Kpis\Index.cshtml"
                  Write(ViewData["path"]);

#line default
#line hidden
            EndContext();
            BeginContext(3067, 21, true);
            WriteLiteral("\";\r\n/**/\r\n</script>\r\n");
            EndContext();
            BeginContext(3088, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1305bb21d5004934b510118427a9a34c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
