#pragma checksum "C:\Users\baps\source\repos\VedantaWebPortal\VedantaWebPortal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "763484b84785a2ceb1a41df2b265a4d614c4a159"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"763484b84785a2ceb1a41df2b265a4d614c4a159", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afb7184c17f878475dc1a3ff643a3806dc45adf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/piadmin/js/dashboard.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 14217, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-3"">
        <div class=""card bg-primary p-20"">
            <div class=""media widget-ten"">
                <div class=""media-left meida media-middle"">
                    <span><i class=""fa fa-inr f-s-40""></i></span>
                </div>
                <div class=""media-body media-text-right"">
                    <h2 class=""color-white""><i class=""fa fa-inr""></i> X,XX,XXX</h2>
                    <p class=""m-b-0"">Coal Cost (Rs/kWh)</p>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-3"">
        <div class=""card bg-bluevila p-20"">
            <div class=""media widget-ten"">
                <div class=""media-left meida media-middle"">
                    <span><i class=""fa fa-inr f-s-40""></i></span>
                </div>
                <div class=""media-body media-text-right"">
                    <h2 class=""color-white""><i class=""fa fa-inr""></i> XX,XXX</h2>
                    <p class=""m-b-0"">Coal Cost (R");
            WriteLiteral(@"s/kWh)</p>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-3"">
        <div class=""card bg-danger p-20"">
            <div class=""media widget-ten"">
                <div class=""media-left meida media-middle"">
                    <span><i class=""fa fa-inr f-s-40""></i></span>
                </div>
                <div class=""media-body media-text-right"">
                    <h2 class=""color-white""><i class=""fa fa-inr""></i> XX,XXX</h2>
                    <p class=""m-b-0"">Import Grid Cost (Rs/kWh)</p>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-3"">
        <div class=""card bg-success p-20"">
            <div class=""media widget-ten"">
                <div class=""media-left meida media-middle"">
                    <span><i class=""fa fa-inr f-s-40""></i></span>
                </div>
                <div class=""media-body media-text-right"">
                    <h2 class=""color-white""><i class=""fa fa-inr""");
            WriteLiteral(@"></i> X,XX,XX,XXX</h2>
                    <p class=""m-b-0"">Total Cost (Rs/kWh)</p>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-3"">
        <div class=""card bg-info p-20"">
            <div class=""media widget-ten"">
                <div class=""media-left meida media-middle"">
                    <span><i class=""ti-server f-s-40""></i></span>
                </div>
                <div class=""media-body media-text-right"">
                    <h2 class=""color-white""><i class=""ti-server""></i> XXX</h2>
                    <p class=""m-b-0"">Coal Stock (MT)</p>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-3"">
        <div class=""card bg-warning p-20"">
            <div class=""media widget-ten"">
                <div class=""media-left meida media-middle"">
                    <span><i class=""fa fa-inr f-s-40""></i></span>
                </div>
                <div class=""media-bod");
            WriteLiteral(@"y media-text-right"">
                    <h2 class=""color-white""><i class=""fa fa-inr""></i> X,XX,XXX</h2>
                    <p class=""m-b-0"">Power Smelter Cost (Rs/Ton)</p>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-3"">
        <div class=""card bg-dark  p-20"">
            <div class=""media widget-ten"">
                <div class=""media-left meida media-middle"">
                    <span><i class=""fa fa-inr f-s-40""></i></span>
                </div>
                <div class=""media-body media-text-right"">
                    <h2 class=""color-white""><i class=""fa fa-inr""></i> X,XX,XXX</h2>
                    <p class=""m-b-0"">Electricity Duty (Rs/kWh)</p>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-3"">
        <div class=""card bg-brown p-20"">
            <div class=""media widget-ten"">
                <div class=""media-left meida media-middle"">
                    <span><i class=""fa fa-inr f-s-");
            WriteLiteral(@"40""></i></span>
                </div>
                <div class=""media-body media-text-right"">
                    <h2 class=""color-white""><i class=""fa fa-inr""></i> X,XX,XXX</h2>
                    <p class=""m-b-0"">EBIDTA</p>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"" style=""padding: 10px;min-height: 650px;"">
            <div class=""table-responsive"">
                <table id=""example3"" class=""table table-striped  table-bordered"" cellspacing=""0"" width=""100%"">
                    <thead>
                        <tr>
                            <th>
                                SR.
                            </th>
                            <th>
                                KPI
                            </th>
                            <th>
                                Actual (MTD)
                            </th>
                            <th style=""width:20%""");
            WriteLiteral(@">
                                ACT Vs BP<br>(MTD)
                            </th>
                            <th style=""width:45%;text-align: center;"">
                                Monthly Achievements
                            </th>
                            <th>
                                Actual (YTD)
                            </th>
                            <th style=""width:20%"">
                                ACT Vs BP<br>(YTD)
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1</td>
                            <td>Plant Load Factor (%)</td>
                            <td>
                                <div id=""plfMTDActual""></div>
                            </td>
                            <td>
                                <div id=""plfMTD""></div>
                            </td>
                            <td>
       ");
            WriteLiteral(@"                         <div id=""plfMonth""></div>
                            </td>
                            <td>
                                <div id=""plfYTDActual""></div>
                            </td>
                            <td>
                                <div id=""plfYTD""></div>
                            </td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td>Plant Availability Factor (%)</td>
                            <td>
                                <div id=""pafMTDActual""></div>
                            </td>
                            <td>
                                <div id=""pafMTD""></div>
                            </td>
                            <td>
                                <div id=""pafMonth""></div>
                            </td>
                            <td>
                                <div id=""pafYTDActual""></div>
                           ");
            WriteLiteral(@" </td>
                            <td>
                                <div id=""pafYTD""></div>
                            </td>
                        </tr>
                        <tr>
                            <td>3</td>
                            <td>Gross Generation</td>
                            <td><div id=""grossgenerationMTDActual""></div></td>
                            <td>
                                <div id=""grossgenerationMTD""></div>
                            </td>
                            <td>
                                <div id=""grossgenerationMonth""></div>
                            </td>
                            <td>
                                <div id=""grossgenerationYTDActual""></div>
                            </td>
                            <td>
                                <div id=""grossgenerationYTD""></div>
                            </td>
                        </tr>
                        <tr>
                            <td>4");
            WriteLiteral(@"</td>
                            <td>Aux Consumption</td>
                            <td>
                                <div id=""auxconsumptionMTDActual""></div>
                            </td>
                            <td>
                                <div id=""auxconsumptionMTD""></div>
                            </td>
                            <td>
                                <div id=""auxconsumptionMonth""></div>
                            </td>
                            <td>
                                <div id=""auxconsumptionYTDActual""></div>
                            </td>
                            <td>
                                <div id=""auxconsumptionYTD""></div>
                            </td>
                        </tr>
                        <tr>
                            <td>5</td>
                            <td>Net Generation</td>
                            <td><div id=""netgenerationMTDActual""></div></td>
                            <td>");
            WriteLiteral(@"
                                <div id=""netgenerationMTD""></div>
                            </td>
                            <td>
                                <div id=""netgenerationMonth""></div>
                            </td>
                            <td><div id=""netgenerationYTDActual""></div></td>
                            <td>
                                <div id=""netgenerationYTD""></div>
                            </td>
                        </tr>
                        <tr>
                            <td>6</td>
                            <td>SCC 360</td>
                            <td><div id=""scc360MTDActual""></div></td>
                            <td>
                                <div id=""scc360MTD""></div>
                            </td>
                            <td>
                                <div id=""scc360Month""></div>
                            </td>
                            <td><div id=""scc360YTDActual""></div></td>
                   ");
            WriteLiteral(@"         <td>
                                <div id=""scc360YTD""></div>
                            </td>
                        </tr>
                        <tr>
                            <td>7</td>
                            <td>Heat Rate</td>
                            <td><div id=""heatrateMTDActual""></div></td>
                            <td>
                                <div id=""heatrateMTD""></div>
                            </td>
                            <td>
                                <div id=""heatrateMonth""></div>
                            </td>
                            <td><div id=""heatrateYTDActual""></div></td>
                            <td>
                                <div id=""heatrateYTD""></div>
                            </td>
                        </tr>
                        <tr>
                            <td>8</td>
                            <td>SOC</td>
                            <td><div id=""socMTDActual""></div></td>
             ");
            WriteLiteral(@"               <td>
                                <div id=""socMTD""></div>
                            </td>
                            <td>
                                <div id=""socMonth""></div>
                            </td>
                            <td><div id=""socYTDActual""></div></td>
                            <td>
                                <div id=""socYTD""></div>
                            </td>
                        </tr>
                        <tr>
                            <td>9</td>
                            <td>Oil Consumption</td>
                            <td><div id=""oilconsumptionMTDActual""></div></td>
                            <td>
                                <div id=""oilconsumptionMTD""></div>
                            </td>
                            <td>
                                <div id=""oilconsumptionMonth""></div>
                            </td>
                            <td><div id=""oilconsumptionYTDActual""></div></td>
");
            WriteLiteral(@"                            <td>
                                <div id=""oilconsumptionYTD""></div>
                            </td>
                        </tr>
                        <tr>
                            <td>10</td>
                            <td>GCV</td>
                            <td><div id=""gcvMTDActual""></div></td>
                            <td>
                                <div id=""gcvMTD""></div>
                            </td>
                            <td>
                                <div id=""gcvMonth""></div>
                            </td>
                            <td><div id=""gcvYTDActual""></div></td>
                            <td>
                                <div id=""gcvYTD""></div>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-4"">
        <div class=""card"">
         ");
            WriteLiteral(@"   <div class=""card-title center"">
                <h4>Monthly Coal Receipt(MT)</h4>
            </div>
            <div class=""card-body"">
                <div id=""monthlyCoalReceipt""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-title center"">
                <h4>Monthly Delivered Cost(Rs/MT)</h4>
            </div>
            <div class=""card-body"">
                <div id=""monthlyDeliveredCost""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card"">
            <div class=""card-title center"">
                <h4>Gross Generation in MU</h4>
            </div>
            <div class=""card-body"">
                <div id=""monthlyGrossgeneration""></div>
            </div>
        </div>
    </div>
</div>

<!-- Chart code -->
");
            EndContext();
            BeginContext(14217, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87a0fa8c3b0b4094bcccac3616a4e2e5", async() => {
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
            BeginContext(14289, 21, true);
            WriteLiteral("\r\n<!-- Chart code -->");
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
