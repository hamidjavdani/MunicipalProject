namespace _0_Framework.Infrastructure;

public static class Roles
{
    public const string Administrator = "1";
    public const string SystemUser = "2";
    public const string ContentUploader = "3";
    public const string ColleagueUser = "10002";
    public const string k1 = "10006";
    public const string k2 = "10007";
    public const string k3 = "10008";
    public const string k4 = "10009";
    public const string k5 = "10010";
    public const string k6 = "10011";
    public const string k7 = "10012";
    public const string k8 = "10013";
    public const string k9 = "10014";
    public const string k10 = "10015";
    public const string k11 = "10016";
    public const string k12 = "10017";
    public const string k13 = "10018";
    public const string k14 = "10019";
    public const string k15 = "10020";
    public const string k16 = "10021";
    public static string GetRoleBy(long id)
    {
        switch (id)
        {
            case 1:
                return "مدیرسیستم";
            case 2:
                return "کارشناس شهرسازی";
            case 3:
                return "محتوا گذار";
            case 10002:
                return " شهروند";
            case 10006:
                return "کارشناس ممیزی ";
            case 10007:
                return "کارشناس درآمد ";
            case 10008:
                return " کارشناس نوسازی";
            case 10009:
                return " کارشناس مشاغل";
            case 10010:
                return " کارشناس اجرائیات";
            case 10011:
                return " کارشناس دبیرخانه ماده صد";
            case 10012:
                return " کارشناس دبیرخانه ماده صد";
            case 10013:
                return " کارشناس دبیرخانه ماده صد";
            case 10014:
                return " کارشناس دبیرخانه ماده صد";
            case 10015:
                return " دبیر کمیسیون ماده صد";

            default:
                return "نا مشخص";
        }
    }
}
