#pragma checksum "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\UserArea\Pages\Shared\_sidebarPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "829cf9346a3124156f35a1ef257b89af98062e8b87e7d3bc9418412f6fde0c7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Areas.UserArea.Pages.Shared.Areas_UserArea_Pages_Shared__sidebarPartial), @"mvc.1.0.view", @"/Areas/UserArea/Pages/Shared/_sidebarPartial.cshtml")]
namespace ServiceHost.Areas.UserArea.Pages.Shared
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"829cf9346a3124156f35a1ef257b89af98062e8b87e7d3bc9418412f6fde0c7f", @"/Areas/UserArea/Pages/Shared/_sidebarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"046a2f7341f3e39fbae5f992ca3d65fad593592515db7b3a46631f7012a35123", @"/Areas/UserArea/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_UserArea_Pages_Shared__sidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""sidebar sidebar-main"" style=""background-color:#d4d1d1;"">
    <div class=""sidebar-content"">

        <!-- START - User menu -->
        <div class=""sidebar-user"">
            <div class=""category-content"">
                <div class=""media"">
                    <a href=""#"" class=""media-left"">
                    </a>
                    <div class=""media-body"">
                        <span class=""media-heading text-semibold"">----</span>
                        <div class=""text-size-mini text-muted"">
                            <i class=""icon-pin text-size-small""></i> &nbsp;پنل کاربران ( -- - )
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- END - User menu -->
        <!-- START - Main navigation -->
        <div class=""sidebar-category sidebar-category-visible"">
            <div class=""category-content no-padding"">

                <!-- START - Item Navigation -->
                <ul class=""nav");
            WriteLiteral(@"igation navigation-main"" style=""color:black;"">

                    <!-- START - Item Navigation Header -->
                    <li class=""navigation-header"">
                        <span> داشبورد اختصاصی کاربران</span> <i class=""icon-menu""
                                                                 title=""صفحه اصلی""></i>
                    </li>
                    <li class=""active"">
");
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "829cf9346a3124156f35a1ef257b89af98062e8b87e7d3bc9418412f6fde0c7f5003", async() => {
                WriteLiteral(" \r\n                            <i class=\"icon-home4\"></i>\r\n                            <span>پیشخوان</span>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>
                    <li>
                    </li>
                    <!-- END - Item Navigation Header -->
                    <!-- START - مطالب و محتوا -->
                    <li>
                        <a href=""#""><i class=""icon-bookmark""></i><span>کارتابل</span></a>

                        <ul>
                            <li>
                                <a href=""#""><i class=""icon-book2""></i> <span>همه نامه های وارده</span></a>

                            </li>
                            <li>
                                <a href=""#""><i class=""icon-book""></i> <span>نامه های خوانده شده</span></a>

                            </li>
                            <li>
                                <a href=""#""><i class=""icon-envelop""></i> <span>نامه های خوانده نشده</span></a>
                            </li>
                            <li>
                                <a href=""#""><i class=""icon-forrst""></i> <span>نامه های اقدام فوری</span></a>");
            WriteLiteral(@"
                            </li>
                            <li>
                                <a href=""#""><i class=""icon-forrst2""></i> <span>نامه های محرمانه</span></a>
                            </li>
                            <li>
                                <a href=""#""><i class=""icon-notebook""></i> <span>یادداشت های رسیده</span></a>
                            </li>
                            <li>
                                <a href=""#""><i class=""icon-book3""></i> <span>نامه های ارجاع داده شده</span></a>
                            </li>

                            <li>
                                <a href=""#""><i class=""icon-reminder""></i> <span>نمایش یادآوری ها</span></a>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <a href=""#""><i class=""icon-forward""></i><span>بازیافت</span></a>

                        <ul>
                            <li>
                              ");
            WriteLiteral(@"  <a href=""#""><i class=""icon-forward2""></i><span>نامه های ارسالی</span></a>
                            </li>

                            <li>
                                <a href=""#""><i class=""icon-grab""></i><span>پیگیری</span></a>
                            </li>

                            <li>
                                <a href=""#""><i class=""icon-notebook""></i><span>یادداشت های ارسالی</span></a>
                            </li>
                            <li>
                                <a href=""#""><i class=""icon-repo-forked""></i><span>نامه های ارجاع داده شده</span></a>
                            </li>
                        </ul>
                    </li>

                    <!-- END - مطالب و محتوا -->
                    <!-- START - اسناد، پرونده ها و پروژه ها -->
                    <li>
                        <a href=""#""><i class=""icon-forward""></i><span>عملیات</span></a>

                        <ul>
                            <li>
                      ");
            WriteLiteral(@"          <a href=""#""><i class=""icon-printer""></i><span>ایجاد نامه</span></a>
                            </li>

                            <li>
                                <a href=""#""><i class=""icon-notebook""></i><span>ایجاد یادداشت</span></a>
                            </li>

                            <li>
                                <a href=""#""><i class=""icon-reminder""></i><span>ثبت یادآوری</span></a>
                            </li>
                            <li>
                                <a href=""#""><i class=""icon-bubble7""></i><span>پیش نویس</span></a>
                            </li>
                            <li>
                                <a href=""#""><i class=""icon-codepen""></i><span>ثبت اسناد خارجه</span></a>
                            </li>
                        </ul>
                    </li>

                    <!-- END - اسناد، پرونده ها و پروژه ها -->
                    <!-- START - مدیریت مالی -->
                    <li>
                 ");
            WriteLiteral(@"       <a href=""#""><i class=""icon-paperplane""></i><span>خبرنامه</span></a>

                        <ul>
                            <li>
                                <a href=""#""><i class=""icon-new""></i><span>اخبار و اطلاعیه ها</span></a>
                            </li>
                        </ul>
                    </li>
                    <!-- END - مدیریت مالی -->
                    <!-- START - مدیریت کاربران -->
                    <li>
                        <a href=""#""><i class=""icon-forward""></i><span>ارزشیابی پرسنل</span></a>

                        <ul>
                            <li>
                                <a href=""#""><i class=""icon-point-up""></i><span>ثبت کارکرد روزانه</span></a>
                            </li>

                            <li>
                                <a href=""#""><i class=""icon-chart""></i><span>نمایش کارکرد پرسنل</span></a>
                            </li>
                        </ul>
                    </li>
              ");
            WriteLiteral(@"      <!-- END - مدیریت کاربران -->
                    <!-- START - پیکربندی سیستم -->
                    <li>
                        <a href=""#""><i class=""icon-shrink5""></i><span>تنظیمات</span></a>

                        <ul>
                            <li>
                                <a href=""#""><i class=""icon-key""></i><span>تغییر رمز عبور</span></a>
                            </li>

                            <li>
                                <a href=""#""><i class=""icon-user""></i><span>پروفایل</span></a>
                            </li>
                        </ul>
                    </li>
                    <!-- END - پیکربندی سیستم -->

                </ul>
                <!-- END - Item Navigation -->

            </div>
        </div>
        <!-- END - Main navigation -->

    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
