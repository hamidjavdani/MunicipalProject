using Microsoft.AspNetCore.Http;

namespace PersonManagement.Application.Contracts.Person;

public class CreatePerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MelliCode { get; set; }
    public string Shenasnameh { get; set; }
    public string Parent { get; set; }
    public string BirthDayDate { get; set; }
    public string Mobile { get; set; }
    public byte Gender { get; set; }
    public IFormFile ImagePath { get; set; }
    public string SignaturePath { get; set; }
    public bool IsActive { get; set; }

}
