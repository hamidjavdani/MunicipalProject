using _0_Framework.Domain;
using AccountManagement.Domain.AccountAgg;
using AccountManagement.Domain.PermissionAgg;

namespace AccountManagement.Domain.LogAgg;

public class Log : EntityBase
{

    public TitelPermission TitelPermission { get; private set; }
    public Account Account { get; private set; }
    public long PermissionId { get; private set; }

    public long AccountId { get; private set; }

    public string Type { get; private set; }
    public Log(long accountId, long permissionId, string type)
    {
        AccountId = accountId;
        PermissionId = permissionId;
        Type = type;

    }
}