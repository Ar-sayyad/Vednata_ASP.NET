#pragma checksum "C:\Users\baps\source\repos\VedantaWebPortal\VedantaWebPortal\Views\Manual\manual_cppfiveFourtyCA.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09933952382ade730a02187ebf2d60130e1460cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manual_manual_cppfiveFourtyCA), @"mvc.1.0.view", @"/Views/Manual/manual_cppfiveFourtyCA.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manual/manual_cppfiveFourtyCA.cshtml", typeof(AspNetCore.Views_Manual_manual_cppfiveFourtyCA))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09933952382ade730a02187ebf2d60130e1460cf", @"/Views/Manual/manual_cppfiveFourtyCA.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afb7184c17f878475dc1a3ff643a3806dc45adf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Manual_manual_cppfiveFourtyCA : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/piadmin/js/manual_cppfiveFourtyCA.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2680, true);
            WriteLiteral(@"<style>
    .card-body {
        padding: 0;
        margin: 5px;
    }
    thead tr {
        background-color: #2083e4;
    }
    #dateTime, #time {
        height: 40px;
    }
    .table td:nth-child(2) {
        text-align: left;
        padding-left: 20px;
    }
</style>
<!-- Start Page Content -->
<div class=""row"">
    <div class=""col-lg-3 newcard"">
        <div class=""datetimeDiv"">
            <h4 class=""datediv"">Select Date-Time: </h4>
        </div>
    </div>
    <div class=""col-lg-2 newcard"">
        <div class=""datetimeDiv"">
            <input type=""text"" class=""dateTime form-control"" autocomplete=""off"" data-date-format='yy-mm-dd' id=""dateTime"" placeholder=""Date Time"">
        </div>
    </div>
    <div class=""col-lg-2 newcard"">
        <div class=""datetimeDiv"">
            <input type=""time"" name=""time"" id=""time"" autocomplete=""off"" step=""2"" readonly="""" class=""time form-control"">
        </div>
    </div>
    <div class=""col-lg-5 newcard"" style=""padding-left: 50px;");
            WriteLiteral(@"text-align: left;"">
        <div class=""datetimeDiv"">
            <button id=""editTime"" class=""btn btn-primary""><i class=""fa fa-edit""></i> </button>
            <button id=""saveTime"" class=""btn btn-success""><i class=""fa fa-save""></i> </button>
        </div>
    </div>
    <div class=""col-lg-12"">
        <div class=""card mydata"">
            <div class=""card-body"">
                <button style=""float:right;margin-bottom: 5px;"" class=""btn btn-primary"" disabled="""" id=""sendToPi""><i class=""fa fa-database""></i> Send Data to PI <i class=""fa fa-send""></i></button>
                <button style=""float:right;margin-bottom: 5px;margin-right: 20px;"" class=""btn btn-info"" id=""refresh""><i class=""fa fa-refresh""></i> Refresh</button>
                <table id=""tableData"" class=""display nowrap table table-striped  table-bordered"" cellspacing=""0"" width=""100%"">
                    <thead>
                        <tr>
                            <th style=""width: 10% !important;"" onclick="""">Sr.No.</th>
          ");
            WriteLiteral(@"                  <th style=""width: 50% !important;text-align: left;padding-left:20px;"">Parameters</th>
                            <!--<th style=""width: 20% !important;"">Name</th>-->
                            <th style=""width: 10% !important;"">UOM</th>
                            <th style=""width: 10% !important;"">Value</th>
                            <th style=""width: 20% !important;"">Status</th>
                        </tr>
                    </thead>
                    <tbody id=""sortTable""></tbody>
                </table>
            </div>
        </div>
    </div>
</div>
<!-- End PAge Content -->
");
            EndContext();
            BeginContext(2680, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c00c334dc2b488ca4d47be36cad5f33", async() => {
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
            BeginContext(2765, 2, true);
            WriteLiteral("  ");
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
