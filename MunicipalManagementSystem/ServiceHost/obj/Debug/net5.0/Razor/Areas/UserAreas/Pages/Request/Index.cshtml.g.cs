#pragma checksum "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\UserAreas\Pages\Request\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5af8ae8687af064917267c27094dc4205c96cdefdd18b4512059a665b034b20f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Areas.UserAreas.Pages.Request.Areas_UserAreas_Pages_Request_Index), @"mvc.1.0.razor-page", @"/Areas/UserAreas/Pages/Request/Index.cshtml")]
namespace ServiceHost.Areas.UserAreas.Pages.Request
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\UserAreas\Pages\Request\Index.cshtml"
 using MunicipalityManagement.Infrastructure.Configuration.Permissions

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5af8ae8687af064917267c27094dc4205c96cdefdd18b4512059a665b034b20f", @"/Areas/UserAreas/Pages/Request/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3604dde244dcc5115345d0cba71efbe3076b0889cb3827a2aa1a03ce27e91316", @"/Areas/UserAreas/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_UserAreas_Pages_Request_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning pull-right m-rl-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminTheme/assets/datatables/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminTheme/assets/datatables/dataTables.bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/api/JavaScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::ServiceHost.PermissionTagHelper __ServiceHost_PermissionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\UserAreas\Pages\Request\Index.cshtml"
  
    Layout = "Shared/_UsersLayout";
    ViewData["title"] = "مدیریت درخواست ها";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n<div class=\"col-md-12 col-sm-12 col-xs-12\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5af8ae8687af064917267c27094dc4205c96cdefdd18b4512059a665b034b20f6319", async() => {
                WriteLiteral("\r\n        <input type=\"text\" class=\"form-control\" onchange=\"GetEngineers(4,3000)\">\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n        <h4 class=\"page-title pull-right\">");
            Write(
#nullable restore
#line 23 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\UserAreas\Pages\Request\Index.cshtml"
                                           ViewData["title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h4>\r\n        <p class=\"pull-left\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5af8ae8687af064917267c27094dc4205c96cdefdd18b4512059a665b034b20f8377", async() => {
                WriteLiteral(" درخواست جدید");
            }
            );
            __ServiceHost_PermissionTagHelper = CreateTagHelper<global::ServiceHost.PermissionTagHelper>();
            __tagHelperExecutionContext.Add(__ServiceHost_PermissionTagHelper);
            __ServiceHost_PermissionTagHelper.Permission = 
#nullable restore
#line 25 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\UserAreas\Pages\Request\Index.cshtml"
                            MunicipalityPermissions.CreatelistBoxCategory

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("Permission", __ServiceHost_PermissionTagHelper.Permission, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 698, "#showmodal=", 698, 11, true);
            AddHtmlAttributeValue("", 709, 
#nullable restore
#line 26 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\UserAreas\Pages\Request\Index.cshtml"
                                                                Url.Page("./Index", "Create")

#line default
#line hidden
#nullable disable
            , 709, 30, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </p>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">لیست درخواست ها</h3>
            </div>
            <div class=""panel-body"">
                <div class=""row"">
                    <div class=""col-md-12 col-sm-12 col-xs-12"">
                        <table id=""datatable"" class=""table table-striped table-bordered"">
                            <thead>
                                <tr>
                                    <th>کد نوسازی ملک</th>
                                    <th>مالک</th>
                                    <th>عنوان درخواست</th>

                                    <th></th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>

                                                           



");
#nullable restore
#line 57 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\UserAreas\Pages\Request\Index.cshtml"
                                 foreach (var item in Model.Request)
                                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                <tr>\r\n                                    <td>");
            Write(
#nullable restore
#line 60 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\UserAreas\Pages\Request\Index.cshtml"
                                         item.Codenosazi

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                    <td>");
            Write(
#nullable restore
#line 61 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\UserAreas\Pages\Request\Index.cshtml"
                                         item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                    <td>");
            Write(
#nullable restore
#line 62 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\UserAreas\Pages\Request\Index.cshtml"
                                         item.Onvandarkhast

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n\r\n                                      <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5af8ae8687af064917267c27094dc4205c96cdefdd18b4512059a665b034b20f13271", async() => {
                WriteLiteral("\r\n                                            <i class=\"fa fa-edit\"></i> ویرایش\r\n                                        ");
            }
            );
            __ServiceHost_PermissionTagHelper = CreateTagHelper<global::ServiceHost.PermissionTagHelper>();
            __tagHelperExecutionContext.Add(__ServiceHost_PermissionTagHelper);
            __ServiceHost_PermissionTagHelper.Permission = 
#nullable restore
#line 65 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\UserAreas\Pages\Request\Index.cshtml"
                                                        MunicipalityPermissions.EditListBoxCategory

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("Permission", __ServiceHost_PermissionTagHelper.Permission, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2333, "#showmodal=", 2333, 11, true);
            AddHtmlAttributeValue("", 2344, 
#nullable restore
#line 66 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\UserAreas\Pages\Request\Index.cshtml"
                                                             Url.Page("./Index1", "Edit", new { id = item.AccountId})

#line default
#line hidden
#nullable disable
            , 2344, 57, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5af8ae8687af064917267c27094dc4205c96cdefdd18b4512059a665b034b20f15829", async() => {
                WriteLiteral("\r\n                                            <i class=\"fa fa-remove\"></i> حذف\r\n                                        ");
            }
            );
            __ServiceHost_PermissionTagHelper = CreateTagHelper<global::ServiceHost.PermissionTagHelper>();
            __tagHelperExecutionContext.Add(__ServiceHost_PermissionTagHelper);
            __ServiceHost_PermissionTagHelper.Permission = 
#nullable restore
#line 71 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\UserAreas\Pages\Request\Index.cshtml"
                                                        MunicipalityPermissions.DeleteListBoxCategory

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("Permission", __ServiceHost_PermissionTagHelper.Permission, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2811, "#showmodal=", 2811, 11, true);
            AddHtmlAttributeValue("", 2822, 
#nullable restore
#line 72 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\UserAreas\Pages\Request\Index.cshtml"
                                                             Url.Page("./Index1", "Edit", new { id = item.AccountId})

#line default
#line hidden
#nullable disable
            , 2822, 57, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 77 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\UserAreas\Pages\Request\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5af8ae8687af064917267c27094dc4205c96cdefdd18b4512059a665b034b20f18941", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5af8ae8687af064917267c27094dc4205c96cdefdd18b4512059a665b034b20f20065", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5af8ae8687af064917267c27094dc4205c96cdefdd18b4512059a665b034b20f21189", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\'#datatable\').dataTable();\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Areas.UserAreas.Pages.Request.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Areas.UserAreas.Pages.Request.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Areas.UserAreas.Pages.Request.IndexModel>)PageContext?.ViewData;
        public ServiceHost.Areas.UserAreas.Pages.Request.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
