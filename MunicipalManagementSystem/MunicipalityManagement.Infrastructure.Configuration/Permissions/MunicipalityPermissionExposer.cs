using _0_Framework.Infrastructure;
using System.Collections.Generic;

namespace MunicipalityManagement.Infrastructure.Configuration.Permissions;

public class MunicipalityPermissionExposer : IPermissionExposer
{
    public Dictionary<string, List<PermissionDto>> Expose()
    {
        return new Dictionary<string, List<PermissionDto>>
        {
            {
                "page_user", new List<PermissionDto>
                {
                    new(MunicipalityPermissions.ViewPageUser, "مشاهدصفحه "),
                    new(MunicipalityPermissions.CreateUser, "ثبت کاربر"),
                    new(MunicipalityPermissions.EditUser, "ویرایش کاربر "),
                    new(MunicipalityPermissions.EditPassword, "ویرایش پسورد"),
                    new(MunicipalityPermissions.DeleteUser, "حذف کاربر"),
                    new(MunicipalityPermissions.OneSearchUser, "جستجو"),
                    new(MunicipalityPermissions.AllSearchUser, "جستجو همه"),


                }
            }
            ,

            {
                "page_role ", new List<PermissionDto>
                {
                    new(MunicipalityPermissions.ViewPageRole, "مشاهد صفحه "),
                    new(MunicipalityPermissions.ViewPageRole, "ثبت نقش"),
                    new(MunicipalityPermissions.CreateRole, "ثبت نقش"),
                    new(MunicipalityPermissions.EditRole, "ویرایش نقش"),
                    new(MunicipalityPermissions.DeleteRole, "حذف نقش"),
                    new(MunicipalityPermissions.OneSearchRole, "جستجو"),
                    new(MunicipalityPermissions.AllSearchRole, "جستجو همه "),

                }
                }

            ,

            {
                "page_arseold", new List<PermissionDto>
                {
                    new(MunicipalityPermissions.sabtmomayezi, " ثبت ممیزی"),
                    new(MunicipalityPermissions.sabtmelk, "ثبت پرونده ملکی "),
                    new(MunicipalityPermissions.hazfmelk, " حذف پرونده ملکی "),

                    new(MunicipalityPermissions.sabtayan, "ثبت اعیان ملک"),
                    new(MunicipalityPermissions.hazfayan, "حذف اعیان ملک"),


                    new(MunicipalityPermissions.sabttafkik, "ثبت تفکیک آپارتمان"),
                    new(MunicipalityPermissions.hazftafkik, "حذف تفکیک آپارتمان"),

                    new(MunicipalityPermissions.sabtsenf, "ثبت مشاغل "),
                    new(MunicipalityPermissions.hazfsenf, "حذف مشاغل "),


                   new(MunicipalityPermissions.viewskan, "مشاهده اسکن"),
                   new(MunicipalityPermissions.sabtskan, "ثبت اسکن"),
                   new(MunicipalityPermissions.hazfeskan, "حذف اسکن"),

                    new(MunicipalityPermissions.avareznosazi, "محاسه عوارض نوسازی"),
                    new(MunicipalityPermissions.pardakhtinosazi, "ثبت پرداختی نوسازی"),
                    new(MunicipalityPermissions.ghabznosazi, "صدور فیش نوسازی"),


                    new(MunicipalityPermissions.avarezpasmand, "محاسه عوارض پسماند"),
                    new(MunicipalityPermissions.pardakhtipasmand, "ثبت پرداختی پسماند"),
                    new(MunicipalityPermissions.ghabzpasmand, "صدور فیش پسماند"),
                    new(MunicipalityPermissions.takhfifpasmand, "تخفیف پسماند"),



                    new(MunicipalityPermissions.avarezsenfi, "محاسه عوارض مشاغل"),
                    new(MunicipalityPermissions.pardakhtisenfi, "ثبت پرداختی مشاغل"),
                    new(MunicipalityPermissions.ghabzsenfi, "صدور فیش مشاغل"),
                    new(MunicipalityPermissions.takhfifsenfi, "تخفیف  مشاغل"),


                }
                }
                ,
            {
                 "page_bazdidold", new List<PermissionDto>
                {

                   new(MunicipalityPermissions.sabtedarkhast, "ثبت درخواست"),
                    new(MunicipalityPermissions.sabtebzdid, "ثبت گزارش بازدید "),
                    new(MunicipalityPermissions.viewgozaresh, "مشاهد گزارش"),
                    new(MunicipalityPermissions.hazfebazdid, "حذف گزارش بازدید"),
                }
            }
            ,
            {
                  "page_madesadold", new List<PermissionDto>
                {
                    new(MunicipalityPermissions.sabtecodemadesad, "ثبت کد ماده صد"),
                    new(MunicipalityPermissions.eslahcodemadesad, "اصلاح کد ماده صد"),
                    new(MunicipalityPermissions.daryaftsabegheold, "دریافت سابقه رای"),
                    new(MunicipalityPermissions.eskanfilemadesad, "اسکن رای ماده صد"),
                    new(MunicipalityPermissions.sabteray, "ثبت رای"),
                    new(MunicipalityPermissions.eslahray, "اصلاح رای"),
                    new(MunicipalityPermissions.taeidray, "تایید رای"),
                    new(MunicipalityPermissions.laghveray, "لغو رای"),
                    new(MunicipalityPermissions.hazfray,  "حذف رای"),
                    new(MunicipalityPermissions.printray,  "جاپ رای"),
                    new(MunicipalityPermissions.ViewTedadShoab,  " مشاهده لیست شعب"),
                    new(MunicipalityPermissions.ViewShoabList,  "چاپ لیست شعب"),

                }
            }

             ,
            {
                  "page_mohasebat", new List<PermissionDto>
                {
                    new(MunicipalityPermissions.sabtekhorujinezam, "ثبت تاییدیه نظام مهندسی"),
                    new(MunicipalityPermissions.mohasebatavpar, "محاسبات عوارض"),
                    new(MunicipalityPermissions.Taeidmohasebat, "تایید محاسبات "),
                    new(MunicipalityPermissions.Laghvtaeidmohasebat, "لغو محاسبات "),


                }
            }


        };
    }
}
