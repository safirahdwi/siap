#pragma checksum "C:\Users\Nadhilah\source\repos\pklkita\adminLTE\Views\Home\Daftaranggota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "476832f27a994eebdb2c1e3150240c81158d4da4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Daftaranggota), @"mvc.1.0.view", @"/Views/Home/Daftaranggota.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Daftaranggota.cshtml", typeof(AspNetCore.Views_Home_Daftaranggota))]
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
#line 1 "C:\Users\Nadhilah\source\repos\pklkita\adminLTE\Views\_ViewImports.cshtml"
using adminLTE;

#line default
#line hidden
#line 2 "C:\Users\Nadhilah\source\repos\pklkita\adminLTE\Views\_ViewImports.cshtml"
using adminLTE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"476832f27a994eebdb2c1e3150240c81158d4da4", @"/Views/Home/Daftaranggota.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd24ada9c472fbc4483b05568c273e393597dcb4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Daftaranggota : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "25", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Nadhilah\source\repos\pklkita\adminLTE\Views\Home\Daftaranggota.cshtml"
  
    ViewData["Title"] = "Daftaranggota";
    Layout = "~/Views/Shared/_MainMenu.cshtml";

#line default
#line hidden
            BeginContext(100, 1047, true);
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        Daftar Anggota
        <small>advanced tables</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""https://localhost:44384/Home/Beranda""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li class=""active"">Daftar Anggota</li>
    </ol>
</section>

<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-body"">
                    <div class=""dataTables_wrapper form-inline dt-bootstrap"" id=""example1_wrapper"">
                        <div class=""row"">
                        <div class=""col-sm-6"">
                            <div id=""example1_length"" class=""dataTables_length"">
                            <label>
                                Show 
                                <select class=""form-control input-sm"" aria-controls=""example1"" name=""example1_length"">
         ");
            WriteLiteral("                       ");
            EndContext();
            BeginContext(1147, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "476832f27a994eebdb2c1e3150240c81158d4da45806", async() => {
                BeginContext(1166, 2, true);
                WriteLiteral("10");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1177, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1211, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "476832f27a994eebdb2c1e3150240c81158d4da47211", async() => {
                BeginContext(1230, 2, true);
                WriteLiteral("25");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1241, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1275, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "476832f27a994eebdb2c1e3150240c81158d4da48616", async() => {
                BeginContext(1294, 2, true);
                WriteLiteral("50");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1305, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1339, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "476832f27a994eebdb2c1e3150240c81158d4da410021", async() => {
                BeginContext(1359, 3, true);
                WriteLiteral("100");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1371, 8291, true);
            WriteLiteral(@"
                                 </select> 
                                entries
                                </label>
                                </div>
                            </div>
                        <div class=""col-sm-6"">
                            <div id=""example1_filter"" class=""dataTables_filter"">
                            <label>
                                Search:
                                <input aria-controls=""example1"" placeholder="""" class=""form-control input-sm"" type=""search"">
                                </label>
                            </div>
                            </div>
                            </div>
                        <div class=""row"">
                            <div class=""col-sm-12"">
                                <table aria-describedby=""example1_info"" role=""grid"" id=""example1"" class=""table table-bordered table-striped dataTable"">
                                    <thead>
                                        <");
            WriteLiteral(@"tr role=""row"">
                                        <th aria-label=""Rendering engine: activate to sort column descending"" aria-sort=""ascending"" style=""width: 182.467px;"" colspan=""1"" rowspan=""1"" aria-controls=""example1"" tabindex=""0"" class=""sorting_asc"">No</th>
                                        <th aria-label=""Browser: activate to sort column ascending"" style=""width: 225.017px;"" colspan=""1"" rowspan=""1"" aria-controls=""example1"" tabindex=""0"" class=""sorting"">Nama</th>
                                        <th aria-label=""Platform(s): activate to sort column ascending"" style=""width: 198.733px;"" colspan=""1"" rowspan=""1"" aria-controls=""example1"" tabindex=""0"" class=""sorting"">Nim</th>
                                        <th aria-label=""Engine version: activate to sort column ascending"" style=""width: 155.9px;"" colspan=""1"" rowspan=""1"" aria-controls=""example1"" tabindex=""0"" class=""sorting"">Jabatan</th>
                                        <th aria-label=""CSS grade: activate to sort column ascending"" s");
            WriteLiteral(@"tyle=""width: 110.883px;"" colspan=""1"" rowspan=""1"" aria-controls=""example1"" tabindex=""0"" class=""sorting"">Action</th></tr>
                                    </thead>
                                    <tbody> <tr class=""odd"" role=""row"">
                                            <td class=""sorting_1"">Gecko</td>
                                            <td>Firefox 1.0</td>
                                            <td>Win 98+ / OSX.2+</td>
                                            <td>1.7</td>
                                            <td>A</td>
                                        </tr>
                                        <tr class=""even"" role=""row"">
                                            <td class=""sorting_1"">Gecko</td>
                                            <td>Firefox 1.5</td>
                                            <td>Win 98+ / OSX.2+</td>
                                            <td>1.8</td>
                                            <td>A</td>
         ");
            WriteLiteral(@"                               </tr>
                                        <tr class=""odd"" role=""row"">
                                            <td class=""sorting_1"">Gecko</td>
                                            <td>Firefox 2.0</td>
                                            <td>Win 98+ / OSX.2+</td>
                                            <td>1.8</td>
                                            <td>A</td>
                                        </tr>
                                        <tr class=""even"" role=""row"">
                                            <td class=""sorting_1"">Gecko</td>
                                            <td>Firefox 3.0</td>
                                            <td>Win 2k+ / OSX.3+</td>
                                            <td>1.9</td>
                                            <td>A</td>
                                        </tr>
                                        <tr class=""odd"" role=""row"">
                          ");
            WriteLiteral(@"                  <td class=""sorting_1"">Gecko</td>
                                            <td>Camino 1.0</td>
                                            <td>OSX.2+</td>
                                            <td>1.8</td>
                                            <td>A</td>
                                        </tr>
                                        <tr class=""even"" role=""row"">
                                            <td class=""sorting_1"">Gecko</td>
                                            <td>Camino 1.5</td>
                                            <td>OSX.3+</td>
                                            <td>1.8</td>
                                            <td>A</td>
                                        </tr>
                                        <tr class=""odd"" role=""row"">
                                            <td class=""sorting_1"">Gecko</td>
                                            <td>Netscape 7.2</td>
                                    ");
            WriteLiteral(@"        <td>Win 95+ / Mac OS 8.6-9.2</td>
                                            <td>1.7</td>
                                            <td>A</td>
                                        </tr>
                                        <tr class=""even"" role=""row"">
                                            <td class=""sorting_1"">Gecko</td>
                                            <td>Netscape Browser 8</td>
                                            <td>Win 98SE+</td>
                                            <td>1.7</td>
                                            <td>A</td>
                                        </tr>
                                        <tr class=""odd"" role=""row"">
                                            <td class=""sorting_1"">Gecko</td>
                                            <td>Netscape Navigator 9</td>
                                            <td>Win 98+ / OSX.2+</td>
                                            <td>1.8</td>
                       ");
            WriteLiteral(@"                     <td>A</td>
                                        </tr>
                                        <tr class=""even"" role=""row"">
                                            <td class=""sorting_1"">Gecko</td>
                                            <td>Mozilla 1.0</td>
                                            <td>Win 95+ / OSX.1+</td>
                                            <td>1</td>
                                            <td>A</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div><div class=""row""><div class=""col-sm-5""><div aria-live=""polite"" role=""status"" id=""example1_info"" class=""dataTables_info"">Showing 1 to 10 of 57 entries</div></div><div class=""col-sm-7""><div id=""example1_paginate"" class=""dataTables_paginate paging_simple_numbers""><ul class=""pagination""><li id=""example1_previous"" class=""paginate_button previous dis");
            WriteLiteral(@"abled""><a tabindex=""0"" data-dt-idx=""0"" aria-controls=""example1"" href=""#"">Previous</a></li><li class=""paginate_button active""><a tabindex=""0"" data-dt-idx=""1"" aria-controls=""example1"" href=""#"">1</a></li><li class=""paginate_button ""><a tabindex=""0"" data-dt-idx=""2"" aria-controls=""example1"" href=""#"">2</a></li><li class=""paginate_button ""><a tabindex=""0"" data-dt-idx=""3"" aria-controls=""example1"" href=""#"">3</a></li><li class=""paginate_button ""><a tabindex=""0"" data-dt-idx=""4"" aria-controls=""example1"" href=""#"">4</a></li><li class=""paginate_button ""><a tabindex=""0"" data-dt-idx=""5"" aria-controls=""example1"" href=""#"">5</a></li><li class=""paginate_button ""><a tabindex=""0"" data-dt-idx=""6"" aria-controls=""example1"" href=""#"">6</a></li><li id=""example1_next"" class=""paginate_button next""><a tabindex=""0"" data-dt-idx=""7"" aria-controls=""example1"" href=""#"">Next</a></li></ul></div></div></div>
                    </div>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->
     ");
            WriteLiteral("   </div>\r\n        <!-- /.col -->\r\n    </div>\r\n    <!-- /.row -->\r\n</section>\r\n<!-- /.content -->\r\n");
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
