#pragma checksum "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\Administration\Pages\Municipality\ListBoxCategory\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "206eef793d39f2105f36763078e775e3aaf1c2c6cec8fd5f6fc61eb88c66a24c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Areas.Administration.Pages.Municipality.ListBoxCategory.Areas_Administration_Pages_Municipality_ListBoxCategory_Index), @"mvc.1.0.razor-page", @"/Areas/Administration/Pages/Municipality/ListBoxCategory/Index.cshtml")]
namespace ServiceHost.Areas.Administration.Pages.Municipality.ListBoxCategory
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
#line 2 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\Administration\Pages\Municipality\ListBoxCategory\Index.cshtml"
 using MunicipalityManagement.Infrastructure.Configuration.Permissions

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"206eef793d39f2105f36763078e775e3aaf1c2c6cec8fd5f6fc61eb88c66a24c", @"/Areas/Administration/Pages/Municipality/ListBoxCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"189d3d85c0c1fdda55977a46599cfaff80a5965bc83fc09d3fcd259d064b0ede", @"/Areas/Administration/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Administration_Pages_Municipality_ListBoxCategory_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pull-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary waves-effect waves-light m-l-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning pull-right m-rl-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminTheme/assets/datatables/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminTheme/assets/datatables/dataTables.bootstrap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::ServiceHost.PermissionTagHelper __ServiceHost_PermissionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\Administration\Pages\Municipality\ListBoxCategory\Index.cshtml"
  
    Layout = "Shared/_AdminLayout";
    ViewData["title"] = "مدیریت عنوان گروه لیست  ";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n        <h4 class=\"page-title pull-right\">");
            Write(
#nullable restore
#line 13 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\Administration\Pages\Municipality\ListBoxCategory\Index.cshtml"
                                           ViewData["title"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h4>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "206eef793d39f2105f36763078e775e3aaf1c2c6cec8fd5f6fc61eb88c66a24c8089", async() => {
                WriteLiteral("\r\n            <a class=\"btn btn-success btn-lg\"");
                BeginWriteAttribute("href", "\r\n               href=\"", 523, "\"", 587, 2);
                WriteAttributeValue("", 546, "#showmodal=", 546, 11, true);
                WriteAttributeValue("", 557, 
#nullable restore
#line 16 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\Administration\Pages\Municipality\ListBoxCategory\Index.cshtml"
                                 Url.Page("./Index", "Create")

#line default
#line hidden
#nullable disable
                , 557, 30, false);
                EndWriteAttribute();
                WriteLiteral(">ایجاد عنوان گروه لیست جدید</a>\r\n        ");
            }
            );
            __ServiceHost_PermissionTagHelper = CreateTagHelper<global::ServiceHost.PermissionTagHelper>();
            __tagHelperExecutionContext.Add(__ServiceHost_PermissionTagHelper);
            __ServiceHost_PermissionTagHelper.Permission = 
#nullable restore
#line 14 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\Administration\Pages\Municipality\ListBoxCategory\Index.cshtml"
                        MunicipalityPermissions.CreatelistBoxCategory

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("Permission", __ServiceHost_PermissionTagHelper.Permission, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">جستجو عنوان گروه لیست</h3>
            </div>
            <div class=""panel-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "206eef793d39f2105f36763078e775e3aaf1c2c6cec8fd5f6fc61eb88c66a24c10695", async() => {
                WriteLiteral(@"

                    <div class=""row"">


                        <div class=""col-md-4"">
                            <div class=""form-group"">

                                <input type=""text"" class=""form-control"" placeholder=""  عنوان گروه لیست "" onchange=""makeSlug('Name', 'Slug')"">
                                <span class=""error""></span>
                            </div>
                        </div>


                        <button type=""submit"" class=""btn btn-success waves-effect waves-light m-l-10"">جستجو</button>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "206eef793d39f2105f36763078e775e3aaf1c2c6cec8fd5f6fc61eb88c66a24c11564", async() => {
                    WriteLiteral("مشاهده همه");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n                    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<div class=""row"" id=""ProductCategoriesDiv"">
    <div class=""col-md-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">گروه لیست   </h3>
            </div>
            <div class=""panel-body"">
                <div class=""row"">
                    <div class=""col-md-12 col-sm-12 col-xs-12"">
                        <table id=""datatable"" class=""table table-striped table-bordered"" border=""1"">
                            <thead>
                                <tr>
                                    <th>ردیف</th>
                                    <th>عنوان لیست  </th>


                                    <th></th>
                                     <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 81 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\Administration\Pages\Municipality\ListBoxCategory\Index.cshtml"
                                 foreach (var item in Model.listboxcategories)
                                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                    <tr>\r\n                                        <td>");
            Write(
#nullable restore
#line 84 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\Administration\Pages\Municipality\ListBoxCategory\Index.cshtml"
                                             item.Id

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n");
            WriteLiteral("\r\n                                        <td>");
            Write(
#nullable restore
#line 89 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\Administration\Pages\Municipality\ListBoxCategory\Index.cshtml"
                                             item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "206eef793d39f2105f36763078e775e3aaf1c2c6cec8fd5f6fc61eb88c66a24c16643", async() => {
                WriteLiteral("\r\n                                                <i class=\"fa fa-edit\"></i> ویرایش\r\n                                            ");
            }
            );
            __ServiceHost_PermissionTagHelper = CreateTagHelper<global::ServiceHost.PermissionTagHelper>();
            __tagHelperExecutionContext.Add(__ServiceHost_PermissionTagHelper);
            __ServiceHost_PermissionTagHelper.Permission = 
#nullable restore
#line 92 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\Administration\Pages\Municipality\ListBoxCategory\Index.cshtml"
                                                            MunicipalityPermissions.EditListBoxCategory

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("Permission", __ServiceHost_PermissionTagHelper.Permission, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3410, "#showmodal=", 3410, 11, true);
            AddHtmlAttributeValue("", 3421, 
#nullable restore
#line 93 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\Administration\Pages\Municipality\ListBoxCategory\Index.cshtml"
                                                                 Url.Page("./Index", "Edit", new { id = item.Id})

#line default
#line hidden
#nullable disable
            , 3421, 49, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <a class=\"btn btn-warning pull-right m-rl-5\"");
            BeginWriteAttribute("href", "\r\n                                               href=\"", 3788, "\"", 3903, 2);
            WriteAttributeValue("", 3843, "#showmodal=", 3843, 11, true);
            WriteAttributeValue("", 3854, 
#nullable restore
#line 99 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\Administration\Pages\Municipality\ListBoxCategory\Index.cshtml"
                                                                 Url.Page("./Index", "Edit", new { id = item.Id})

#line default
#line hidden
#nullable disable
            , 3854, 49, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <i class=\"fa fa-remove\"></i> حذف\r\n                                            </a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 104 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\Administration\Pages\Municipality\ListBoxCategory\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable

            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "206eef793d39f2105f36763078e775e3aaf1c2c6cec8fd5f6fc61eb88c66a24c20844", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "206eef793d39f2105f36763078e775e3aaf1c2c6cec8fd5f6fc61eb88c66a24c21968", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\'#datatable\').dataTable();\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Areas.Administration.Pages.Municipality.ListBoxCategory.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Areas.Administration.Pages.Municipality.ListBoxCategory.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Areas.Administration.Pages.Municipality.ListBoxCategory.IndexModel>)PageContext?.ViewData;
        public ServiceHost.Areas.Administration.Pages.Municipality.ListBoxCategory.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
