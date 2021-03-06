#pragma checksum "C:\Users\Dev\Desktop\Proyecto RRHH\Proyecto RRHH\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9764857170b799a75104333043ff770d273c5058"
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
#line 1 "C:\Users\Dev\Desktop\Proyecto RRHH\Proyecto RRHH\Views\_ViewImports.cshtml"
using Proyecto_RRHH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dev\Desktop\Proyecto RRHH\Proyecto RRHH\Views\_ViewImports.cshtml"
using Proyecto_RRHH.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9764857170b799a75104333043ff770d273c5058", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e569634f7e76218d544b00e050bbe4b7fc63fe2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Candidatos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Dev\Desktop\Proyecto RRHH\Proyecto RRHH\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_StartLayout.cshtml";

    ViewData["Title"] = "Home Page";
    List<Proyecto_RRHH__Datos_.Models.EstadosCandidato> estadosCandidatos = ViewBag.estadosd;
    Dictionary<string, int> estados = ViewBag.Estados;
    List<string> EstadosName = new List<string>() { "Visto", "Preseleccionado", "Entrevistado", "Finalizado", "Descartado", "Uso en un futuro" };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"content\">\r\n        <div class=\"container-fluid\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 13 "C:\Users\Dev\Desktop\Proyecto RRHH\Proyecto RRHH\Views\Home\Index.cshtml"
                 foreach (var names in EstadosName)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-3 col-md-6 col-sm-6"">
                        <div class=""card card-stats"">
                            <div class=""card-header card-header-warning card-header-icon"">
                                <div class=""card-icon"">
                                    <i class=""material-icons"">people</i>
                                </div>
                                <p class=""card-category"">");
#nullable restore
#line 21 "C:\Users\Dev\Desktop\Proyecto RRHH\Proyecto RRHH\Views\Home\Index.cshtml"
                                                    Write(names);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                <h3 class=\"card-title\">\r\n                                    ");
#nullable restore
#line 23 "C:\Users\Dev\Desktop\Proyecto RRHH\Proyecto RRHH\Views\Home\Index.cshtml"
                               Write(estados.FirstOrDefault(x => x.Key == names).Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h3>\r\n                            </div>\r\n                            <div class=\"card-footer\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9764857170b799a75104333043ff770d273c50586276", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"estado\" id=\"estado\"");
                BeginWriteAttribute("value", " value=\"", 1476, "\"", 1545, 1);
#nullable restore
#line 28 "C:\Users\Dev\Desktop\Proyecto RRHH\Proyecto RRHH\Views\Home\Index.cshtml"
WriteAttributeValue("", 1484, estadosCandidatos.FirstOrDefault(x=>x.Descripcion==names).Id, 1484, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <input type=\"hidden\" name=\"vacante\" id=\"vacante\"");
                BeginWriteAttribute("value", " value=\"", 1635, "\"", 1643, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                                    <button type=""submit"" class=""btn btn-success"">
                                        <i class=""material-icons"">arrow_forward</i>Mas detalle
                                    </button>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 37 "C:\Users\Dev\Desktop\Proyecto RRHH\Proyecto RRHH\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""row"">
                <div class=""col-md-4"">
                    <div class=""card card-chart"">
                        <div class=""card-header card-header-success"">
                            <div class=""ct-chart"" id=""dailySalesChart""></div>
                        </div>
                        <div class=""card-body"">
                            <h4 class=""card-title"">Daily Sales</h4>
                            <p class=""card-category"">
                                <span class=""text-success""><i class=""fa fa-long-arrow-up""></i> 55% </span> increase in today sales.
                            </p>
                        </div>
                        <div class=""card-footer"">
                            <div class=""stats"">
                                <i class=""material-icons"">access_time</i> updated 4 minutes ago
                            </div>
                        </div>
                    </div>
                </div>
           ");
            WriteLiteral(@"     <div class=""col-md-4"">
                    <div class=""card card-chart"">
                        <div class=""card-header card-header-warning"">
                            <div class=""ct-chart"" id=""websiteViewsChart""></div>
                        </div>
                        <div class=""card-body"">
                            <h4 class=""card-title"">Email Subscriptions</h4>
                            <p class=""card-category"">Last Campaign Performance</p>
                        </div>
                        <div class=""card-footer"">
                            <div class=""stats"">
                                <i class=""material-icons"">access_time</i> campaign sent 2 days ago
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""card card-chart"">
                        <div class=""card-header card-header-danger"">
                            <div clas");
            WriteLiteral(@"s=""ct-chart"" id=""completedTasksChart""></div>
                        </div>
                        <div class=""card-body"">
                            <h4 class=""card-title"">Completed Tasks</h4>
                            <p class=""card-category"">Last Campaign Performance</p>
                        </div>
                        <div class=""card-footer"">
                            <div class=""stats"">
                                <i class=""material-icons"">access_time</i> campaign sent 2 days ago
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-6 col-md-12"">
                    <div class=""card"">
                        <div class=""card-header card-header-tabs card-header-primary"">
                            <div class=""nav-tabs-navigation"">
                                <div class=""nav-tabs-wrapper"">
                                ");
            WriteLiteral(@"    <span class=""nav-tabs-title"">Tasks:</span>
                                    <ul class=""nav nav-tabs"" data-tabs=""tabs"">
                                        <li class=""nav-item"">
                                            <a class=""nav-link active"" href=""#profile"" data-toggle=""tab"">
                                                <i class=""material-icons"">bug_report</i> Bugs
                                                <div class=""ripple-container""></div>
                                            </a>
                                        </li>
                                        <li class=""nav-item"">
                                            <a class=""nav-link"" href=""#messages"" data-toggle=""tab"">
                                                <i class=""material-icons"">code</i> Website
                                                <div class=""ripple-container""></div>
                                            </a>
                                        </li>
         ");
            WriteLiteral(@"                               <li class=""nav-item"">
                                            <a class=""nav-link"" href=""#settings"" data-toggle=""tab"">
                                                <i class=""material-icons"">cloud</i> Server
                                                <div class=""ripple-container""></div>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""card-body"">
                            <div class=""tab-content"">
                                <div class=""tab-pane active"" id=""profile"">
                                    <table class=""table"">
                                        <tbody>
                                            <tr>
                                                <td>
                                                   ");
            WriteLiteral(" <div class=\"form-check\">\r\n                                                        <label class=\"form-check-label\">\r\n                                                            <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 7376, "\"", 7384, 0);
            EndWriteAttribute();
            WriteLiteral(@" checked>
                                                            <span class=""form-check-sign"">
                                                                <span class=""check""></span>
                                                            </span>
                                                        </label>
                                                    </div>
                                                </td>
                                                <td>Sign contract for ""What are conference organizers afraid of?""</td>
                                                <td class=""td-actions text-right"">
                                                    <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                                        <i class=""material-icons"">edit</i>
                                                    </button>
                                                    <button type=""butto");
            WriteLiteral(@"n"" rel=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                                        <i class=""material-icons"">close</i>
                                                    </button>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class=""form-check"">
                                                        <label class=""form-check-label"">
                                                            <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 9123, "\"", 9131, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <span class=""form-check-sign"">
                                                                <span class=""check""></span>
                                                            </span>
                                                        </label>
                                                    </div>
                                                </td>
                                                <td>Lines From Great Russian Literature? Or E-mails From My Boss?</td>
                                                <td class=""td-actions text-right"">
                                                    <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                                        <i class=""material-icons"">edit</i>
                                                    </button>
                                                    <button type=""button"" rel=""");
            WriteLiteral(@"tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                                        <i class=""material-icons"">close</i>
                                                    </button>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class=""form-check"">
                                                        <label class=""form-check-label"">
                                                            <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 10862, "\"", 10870, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <span class=""form-check-sign"">
                                                                <span class=""check""></span>
                                                            </span>
                                                        </label>
                                                    </div>
                                                </td>
                                                <td>
                                                    Flooded: One year later, assessing what was lost and what was found when a ravaging rain swept through metro Detroit
                                                </td>
                                                <td class=""td-actions text-right"">
                                                    <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                                        <i class=""material-");
            WriteLiteral(@"icons"">edit</i>
                                                    </button>
                                                    <button type=""button"" rel=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                                        <i class=""material-icons"">close</i>
                                                    </button>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class=""form-check"">
                                                        <label class=""form-check-label"">
                                                            <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 12760, "\"", 12768, 0);
            EndWriteAttribute();
            WriteLiteral(@" checked>
                                                            <span class=""form-check-sign"">
                                                                <span class=""check""></span>
                                                            </span>
                                                        </label>
                                                    </div>
                                                </td>
                                                <td>Create 4 Invisible User Experiences you Never Knew About</td>
                                                <td class=""td-actions text-right"">
                                                    <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                                        <i class=""material-icons"">edit</i>
                                                    </button>
                                                    <button type=""button"" re");
            WriteLiteral(@"l=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                                        <i class=""material-icons"">close</i>
                                                    </button>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <div class=""tab-pane"" id=""messages"">
                                    <table class=""table"">
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <div class=""form-check"">
                                                        <label class=""form-check-label"">
                                                            <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 14816, "\"", 14824, 0);
            EndWriteAttribute();
            WriteLiteral(@" checked>
                                                            <span class=""form-check-sign"">
                                                                <span class=""check""></span>
                                                            </span>
                                                        </label>
                                                    </div>
                                                </td>
                                                <td>
                                                    Flooded: One year later, assessing what was lost and what was found when a ravaging rain swept through metro Detroit
                                                </td>
                                                <td class=""td-actions text-right"">
                                                    <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                                        <i class=""m");
            WriteLiteral(@"aterial-icons"">edit</i>
                                                    </button>
                                                    <button type=""button"" rel=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                                        <i class=""material-icons"">close</i>
                                                    </button>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class=""form-check"">
                                                        <label class=""form-check-label"">
                                                            <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 16722, "\"", 16730, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <span class=""form-check-sign"">
                                                                <span class=""check""></span>
                                                            </span>
                                                        </label>
                                                    </div>
                                                </td>
                                                <td>Sign contract for ""What are conference organizers afraid of?""</td>
                                                <td class=""td-actions text-right"">
                                                    <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                                        <i class=""material-icons"">edit</i>
                                                    </button>
                                                    <button type=""button"" rel=""");
            WriteLiteral(@"tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                                        <i class=""material-icons"">close</i>
                                                    </button>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <div class=""tab-pane"" id=""settings"">
                                    <table class=""table"">
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <div class=""form-check"">
                                                        <label class=""form-check-label"">
                                                            <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 18775, "\"", 18783, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <span class=""form-check-sign"">
                                                                <span class=""check""></span>
                                                            </span>
                                                        </label>
                                                    </div>
                                                </td>
                                                <td>Lines From Great Russian Literature? Or E-mails From My Boss?</td>
                                                <td class=""td-actions text-right"">
                                                    <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                                        <i class=""material-icons"">edit</i>
                                                    </button>
                                                    <button type=""button"" rel=""");
            WriteLiteral(@"tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                                        <i class=""material-icons"">close</i>
                                                    </button>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class=""form-check"">
                                                        <label class=""form-check-label"">
                                                            <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 20514, "\"", 20522, 0);
            EndWriteAttribute();
            WriteLiteral(@" checked>
                                                            <span class=""form-check-sign"">
                                                                <span class=""check""></span>
                                                            </span>
                                                        </label>
                                                    </div>
                                                </td>
                                                <td>
                                                    Flooded: One year later, assessing what was lost and what was found when a ravaging rain swept through metro Detroit
                                                </td>
                                                <td class=""td-actions text-right"">
                                                    <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                                        <i class=""m");
            WriteLiteral(@"aterial-icons"">edit</i>
                                                    </button>
                                                    <button type=""button"" rel=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                                        <i class=""material-icons"">close</i>
                                                    </button>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <div class=""form-check"">
                                                        <label class=""form-check-label"">
                                                            <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 22420, "\"", 22428, 0);
            EndWriteAttribute();
            WriteLiteral(@" checked>
                                                            <span class=""form-check-sign"">
                                                                <span class=""check""></span>
                                                            </span>
                                                        </label>
                                                    </div>
                                                </td>
                                                <td>Sign contract for ""What are conference organizers afraid of?""</td>
                                                <td class=""td-actions text-right"">
                                                    <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                                        <i class=""material-icons"">edit</i>
                                                    </button>
                                                    <button type=""butto");
            WriteLiteral(@"n"" rel=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                                        <i class=""material-icons"">close</i>
                                                    </button>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6 col-md-12"">
                    <div class=""card"">
                        <div class=""card-header card-header-warning"">
                            <h4 class=""card-title"">Employees Stats</h4>
                            <p class=""card-category"">New employees on 15th September, 2016</p>
                        </div>
                        <div class=""card-body table-responsive"">
     ");
            WriteLiteral(@"                       <table class=""table table-hover"">
                                <thead class=""text-warning"">
                                <th>ID</th>
                                <th>Name</th>
                                <th>Salary</th>
                                <th>Country</th>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>1</td>
                                        <td>Dakota Rice</td>
                                        <td>$36,738</td>
                                        <td>Niger</td>
                                    </tr>
                                    <tr>
                                        <td>2</td>
                                        <td>Minerva Hooper</td>
                                        <td>$23,789</td>
                                        <td>Curaçao</td>
                                    </tr>");
            WriteLiteral(@"
                                    <tr>
                                        <td>3</td>
                                        <td>Sage Rodriguez</td>
                                        <td>$56,142</td>
                                        <td>Netherlands</td>
                                    </tr>
                                    <tr>
                                        <td>4</td>
                                        <td>Philip Chaney</td>
                                        <td>$38,735</td>
                                        <td>Korea, South</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

");
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
