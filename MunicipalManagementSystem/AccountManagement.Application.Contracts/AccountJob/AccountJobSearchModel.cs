namespace AccountManagement.Application.Contracts.AccountJob;

public class AccountJobSearchModel
{
    public long AccountId { get; set; }
    public string AccountName { get; set; }
    public long JobId { get; set; }
    public string JobName { get; set; }
}
