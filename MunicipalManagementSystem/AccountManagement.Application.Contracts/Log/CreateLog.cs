namespace AccountManagement.Application.Contracts.Log;

public class CreateLog
{
    public long PermissionId { get; set; }

    public long AccountId { get; set; }

    public string Type { get; set; }
}
