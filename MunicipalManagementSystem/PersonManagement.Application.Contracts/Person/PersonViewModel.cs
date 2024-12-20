namespace PersonManagement.Application.Contracts.Person;

public class PersonViewModel
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MelliCode { get; set; }
    public string Shenasnameh { get; set; }
    public string CreationDate { get; set; }
    public string ImagePath { get; set; }
    public bool IsActive { get; set; }
}
