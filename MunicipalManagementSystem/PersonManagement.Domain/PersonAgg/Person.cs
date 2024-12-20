using _0_Framework.Domain;

namespace PersonManagement.Domain.PersonAgg;

public class Person : EntityBase
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string MelliCode { get; private set; }
    public string Shenasnameh { get; private set; }
    public string Parent { get; private set; }
    public string BirthDayDate { get; private set; }
    public string Mobile { get; private set; }
    public byte Gender { get; private set; }
    public string ImagePath { get; private set; }
    public string SignaturePath { get; private set; }
    public bool IsActive { get; private set; }
    //public List<AccountJob> AccountJob { get; private set; }
    public Person(string firstName,
        string lastName,
        string melliCode,
        string shenasnameh,
        string parent,
        string birthDayDate,
        string mobile,
        byte gender,
        string imagePath,
        string signaturePath
        )
    {
        FirstName = firstName;
        LastName = lastName;
        MelliCode = melliCode;
        Shenasnameh = shenasnameh;
        Parent = parent;
        BirthDayDate = birthDayDate;
        Mobile = mobile;
        Gender = gender;
        ImagePath = imagePath;
        SignaturePath = signaturePath;
        IsActive = true;
    }


    public void Edit(
        string firstName,
        string lastName,
        string melliCode,
        string shenasnameh,
        string parent,
        string birthDayDate,
        string mobile,
        byte gender,
        string imagePath,
        string signaturePath

        )
    {
        FirstName = firstName;
        LastName = lastName;
        MelliCode = melliCode;
        Shenasnameh = shenasnameh;
        Parent = parent;
        BirthDayDate = birthDayDate;
        Mobile = mobile;
        Gender = gender;
        SignaturePath = signaturePath;


        if (!string.IsNullOrWhiteSpace(imagePath))
            ImagePath = imagePath;


    }
    public void Remove()
    {
        IsActive = false;
    }

    public void Restore()
    {
        IsActive = true;
    }

}
