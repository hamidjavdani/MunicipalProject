#pragma checksum "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\Administration\Pages\JobsCharts\JobsChart\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9d502d3ba1b5a78fe3f1d0c2afbed7ff5dc2d13bef9c4dda1acb9bf8b1bccb31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Areas.Administration.Pages.JobsCharts.JobsChart.Areas_Administration_Pages_JobsCharts_JobsChart_Index), @"mvc.1.0.razor-page", @"/Areas/Administration/Pages/JobsCharts/JobsChart/Index.cshtml")]
namespace ServiceHost.Areas.Administration.Pages.JobsCharts.JobsChart
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9d502d3ba1b5a78fe3f1d0c2afbed7ff5dc2d13bef9c4dda1acb9bf8b1bccb31", @"/Areas/Administration/Pages/JobsCharts/JobsChart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"189d3d85c0c1fdda55977a46599cfaff80a5965bc83fc09d3fcd259d064b0ede", @"/Areas/Administration/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Administration_Pages_JobsCharts_JobsChart_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\Administration\Pages\JobsCharts\JobsChart\Index.cshtml"
  
    ViewData["Title"] = "چارت مشاغل سازمان";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""content"">

    <div class=""panel panel-heading"" style=""box-shadow:3px 1px 1px 0 gray; border-radius:2px;"">
        <span style=""font-weight:bold;"">
            <i class=""icon-office""></i>
            چارت مشاغل سازمانی
        </span>
    </div>

    <div style=""margin-bottom:5px;"">
        <div style=""margin-bottom:5px;"">

            <a class=""btn btn-warning waves-effect waves-light m-b-5"" href=""#"" id=""navigationtoadd"">
                <i class=""glyphicon glyphicon-plus""></i>
                افزودن شغل
            </a>

            <a class=""btn btn-warning waves-effect waves-light m-b-5"" href=""#"" id=""navigationtoedit"">
                <i class=""glyphicon glyphicon-edit""></i>
                ویرایش شغل
            </a>
            <a class=""btn btn-warning waves-effect waves-light m-b-5"" href=""#"" id=""navigationtodelete"">
                <i class=""glyphicon glyphicon-remove-circle""></i>
                حذف شغل
            </a>
        </div>
      
    
       

 ");
            WriteLiteral(@"   </div>

    <div class=""alert"" style=""border:1px solid gray; font-weight:bold; margin-top:15px;
                                text-align:center; font-size:15px; background-color:#d1cccc;"">
        جهت افزودن و ویرایش مشاغل ابتدا یک شغل را از درخت مشاغل انتخاب نمایید.
    </div>

    <div class=""panel panel-body container-fluid overflow-auto"" style=""border-radius:2px; height:450px;
                    box-shadow:3px 1px 1px 0 gray; background-color:#e6e2e2;"">
        <div id=""jstreejobs"">

        </div>
    </div>

</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        var idparentnode = 0;
        $(function () {
            $(""#jstreejobs"").on(""changed.jstree"", function (e, data) {
                var i, j;

                var postedItems = [];
                j = data.selected.length;
                for (var i = 0; i < j; i++) {
                    postedItems.push({
                        text: data.instance.get_node(data.selected[i]).text,
                        id: data.selected[i],
                        parent: data.node.parents[0]
                    });
                   // alert(postedItems[0].id + '' + postedItems[0].text);
                    idparentnode = postedItems[0].id;
                }

                if (data.selected.length) {
                    $('#navigationtoadd ,#navigationtoedit,#navigationtodelete').click(function () {
                        if (this.id == 'navigationtoadd') {
                            ///Add
                            var id = postedItems[0].id;
                         ");
                WriteLiteral(@"   var parentname = postedItems[0].text;
                            $('#navigationtoadd').attr(""href"", ""/Administration/JobsCharts/JobsChart/Create?id="" + id +
                                ""&parentname="" + parentname);


                        }
                        else if (this.id == 'navigationtoedit') {
                            ///Edit
                            var id = postedItems[0].id;
                            var parentname = postedItems[0].text;
                            $('#navigationtoedit').attr(""href"", ""/Administration/JobsCharts/JobsChart/Edit?id="" + id +
                                ""&parentname="" + parentname);
                        }
                        else if (this.id == 'navigationtodelete') {
                            ///Edit
                            var id = postedItems[0].id;
                            var parentname = postedItems[0].text;
                            $('#navigationtodelete').attr(""href"", ""/Administration/JobsCharts/JobsC");
                WriteLiteral(@"hart/Delete?id="" + id +
                                ""&parentname="" + parentname);
                        }
                    });
                }
                else {
                    alert(""عنوان شغلی انتخاب شود"");

                }

            }).jstree({
                ""core"": {
                    ""themes"": {
                        ""variant"":""large""
                    },
                    ""data"":  ");
                Write(
#nullable restore
#line 110 "D:\file_software\MunicipalProject\File_2022\MunicipalManagementSystem\ServiceHost\Areas\Administration\Pages\JobsCharts\JobsChart\Index.cshtml"
                              Html.Raw(Model.nodedata)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@" ,
                },
                ""checkbox"": {
                    ""Keep_selected_style"":false
                },
            }).on(""loaded.jstree"", function () {
                $.jstree.reference('#jstreejobs').open_all();
            });
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Areas.Administration.Pages.JobsCharts.JobsChart.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Areas.Administration.Pages.JobsCharts.JobsChart.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Areas.Administration.Pages.JobsCharts.JobsChart.IndexModel>)PageContext?.ViewData;
        public ServiceHost.Areas.Administration.Pages.JobsCharts.JobsChart.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591