using AccountManagement.Domain.LogAgg;
using System.Collections.Generic;

namespace AccountManagement.Domain.PermissionAgg
{
    public class TitelPermission
    {
        public TitelPermission(long id, string name)
        {
            Id = id;
            Name = name;
        }

        public List<Log> Log { get; private set; }
        public long Id { get; private set; }
        public string Name { get; private set; }
    }
}
