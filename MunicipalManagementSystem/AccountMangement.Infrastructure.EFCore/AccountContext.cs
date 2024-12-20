using AccountManagement.Domain.AccountAgg;
using AccountManagement.Domain.AccountJobAgg;
using AccountManagement.Domain.JobsChartAgg;
using AccountManagement.Domain.LogAgg;
using AccountManagement.Domain.RoleAgg;
using AccountMangement.Infrastructure.EFCore.Mappings;
using Microsoft.EntityFrameworkCore;

namespace AccountMangement.Infrastructure.EFCore;

public class AccountContext : DbContext
{
    public DbSet<Permission> permissions { get; set; }
    public DbSet<Log> logs { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<JobsChart> tbljobschart { get; set; }
    public DbSet<AccountJob> tblaccountjob { get; set; }
    public AccountContext(DbContextOptions<AccountContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var assembly = typeof(AccountMapping).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        base.OnModelCreating(modelBuilder);
    }




}
