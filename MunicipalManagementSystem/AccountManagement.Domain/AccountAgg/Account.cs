using _0_Framework.Domain;
using AccountManagement.Domain.AccountJobAgg;
using AccountManagement.Domain.LogAgg;
using AccountManagement.Domain.RoleAgg;
using System.Collections.Generic;
namespace AccountManagement.Domain.AccountAgg;

public class Account : EntityBase
{

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    //public string MelliCode { get; private set; }
    //public string ShomarehSh { get; private set; }
    //public string Address { get; private set; }
    //public string BirthDayDate { get; private set; }
    //public byte Gender { get; private set; }
    //public string ImagePath { get; private set; }
    //public string SignaturePath { get; private set; }
    //public byte IaActive { get; private set; }
    public string Fullname { get; private set; }
    //public string Lastname { get; private set; }
    public string Username { get; private set; }
    public string Password { get; private set; }
    public string Mobile { get; private set; }
    public long RoleId { get; private set; }
    public Role Role { get; private set; }

    //public string CardmeliPhoto { get; private set; }
    //public string ShenasnamehPhoto { get; private set; }
    //public string CardkhedmatPhoto { get; private set; }
    public string ProfilePhoto { get; private set; }
    //public string EmzaPhoto { get; private set; }
    //public string FingerPhoto { get; private set; }  //اثر انگشت
    //public string SanaPhoto { get; private set; }   //برگه ثنا
    //public string VekalatPhoto { get; private set; }

    //public string vCardmeliPhoto { get; private set; }
    //public string vShenasnamehPhoto { get; private set; }
    //public string vCardkhedmatPhoto { get; private set; }
    //public string vProfilePhoto { get; private set; }
    //public string vEmzaPhoto { get; private set; }
    //public string vFingerPhoto { get; private set; }  //اثر انگشت
    //public string vSanaPhoto { get; private set; }   //برگه ثنا

    public List<AccountJob> AccountJob { get; private set; }
    public List<Log> Log { get; private set; }

    //public List<JobsChart> AccountJob { get; private set; }
    public Account(string fullname, string username, string password, string mobile,
        long roleId, string profilePhoto)
    {
        Fullname = fullname;
        Username = username;
        Password = password;
        Mobile = mobile;
        RoleId = roleId;

        if (roleId == 0)
            RoleId = 1;

        ProfilePhoto = profilePhoto;
    }

    public void Edit(string fullname, string username, string mobile,
        long roleId, string profilePhoto)
    {
        Fullname = fullname;
        Username = username;
        Mobile = mobile;
        RoleId = roleId;

        if (!string.IsNullOrWhiteSpace(profilePhoto))
            ProfilePhoto = profilePhoto;
    }

    public void ChangePassword(string password)
    {
        Password = password;
    }
}
