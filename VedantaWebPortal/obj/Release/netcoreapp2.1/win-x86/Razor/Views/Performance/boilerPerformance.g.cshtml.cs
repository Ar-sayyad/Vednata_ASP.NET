#pragma checksum "C:\Users\baps\source\repos\VedantaWebPortal\VedantaWebPortal\Views\Performance\boilerPerformance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d13be99ef9cec87de6ff8ecf3293d7503ecabf37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Performance_boilerPerformance), @"mvc.1.0.view", @"/Views/Performance/boilerPerformance.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Performance/boilerPerformance.cshtml", typeof(AspNetCore.Views_Performance_boilerPerformance))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d13be99ef9cec87de6ff8ecf3293d7503ecabf37", @"/Views/Performance/boilerPerformance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afb7184c17f878475dc1a3ff643a3806dc45adf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Performance_boilerPerformance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/piadmin/js/boilerPerformance.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 1916, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-title center"">
                <h4>Unit wise Performance</h4>
            </div>
            <div class=""card-body"">
                <div id=""plantwiseFFTPerformance""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-title center"">
                <h4>Boiler #1 Efficiency</h4>
            </div>
            <div class=""card-body"">
                <div id=""boilerOneEfficiency""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-title center"">
                <h4>Boiler #2 Efficiency</h4>
            </div>
            <div class=""card-body"">
                <div id=""boilerTwoEfficiency""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=");
            WriteLiteral(@"""card-title center"">
                <h4>Boiler Efficiency</h4>
            </div>
            <div class=""card-body"">
                <div id=""boilerEfficiency""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-title center"">
                <h4>Boiler #3 Efficiency</h4>
            </div>
            <div class=""card-body"">
                <div id=""boilerThreeEfficiency""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-title center"">
                <h4>Boiler #4 Efficiency</h4>
            </div>
            <div class=""card-body"">
                <div id=""boilerFourEfficiency""></div>
            </div>
        </div>
    </div>
</div>

<script>
    /**/
    var elementName = """);
            EndContext();
            BeginContext(1917, 17, false);
#line 66 "C:\Users\baps\source\repos\VedantaWebPortal\VedantaWebPortal\Views\Performance\boilerPerformance.cshtml"
                  Write(ViewData["path1"]);

#line default
#line hidden
            EndContext();
            BeginContext(1934, 8, true);
            WriteLiteral("\"+\"\\\\\"+\"");
            EndContext();
            BeginContext(1943, 17, false);
#line 66 "C:\Users\baps\source\repos\VedantaWebPortal\VedantaWebPortal\Views\Performance\boilerPerformance.cshtml"
                                            Write(ViewData["path2"]);

#line default
#line hidden
            EndContext();
            BeginContext(1960, 8, true);
            WriteLiteral("\"+\"\\\\\"+\"");
            EndContext();
            BeginContext(1969, 17, false);
#line 66 "C:\Users\baps\source\repos\VedantaWebPortal\VedantaWebPortal\Views\Performance\boilerPerformance.cshtml"
                                                                      Write(ViewData["path3"]);

#line default
#line hidden
            EndContext();
            BeginContext(1986, 23, true);
            WriteLiteral("\";\r\n/**/\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(2009, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c39f191ac759408eb11389d1f122c3aa", async() => {
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