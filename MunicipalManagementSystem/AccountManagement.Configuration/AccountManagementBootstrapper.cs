using AccountManagement.Application;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Application.Contracts.AccountJob;
using AccountManagement.Application.Contracts.JobsChart;
using AccountManagement.Application.Contracts.Log;
using AccountManagement.Application.Contracts.Role;
using AccountManagement.Domain.AccountAgg;
using AccountManagement.Domain.AccountJobAgg;
using AccountManagement.Domain.JobsChartAgg;
using AccountManagement.Domain.LogAgg;
using AccountManagement.Domain.RoleAgg;
using AccountMangement.Infrastructure.EFCore;
using AccountMangement.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace AccountManagement.Configuration;

public class AccountManagementBootstrapper
{
    public static void Configure(IServiceCollection services, string connectionString)
    {
        services.AddTransient<IAccountApplication, AccountApplication>();
        services.AddTransient<IAccountRepository, AccountRepository>();

        services.AddTransient<IRoleApplication, RoleApplication>();
        services.AddTransient<IRoleRepository, RoleRepository>();

        services.AddTransient<IJobsChartApplication, JobsChartApplication>();
        services.AddTransient<IJobsChartRepository, JobsChartRepository>();

        services.AddTransient<IAccountJobApplication, AccountJobApplication>();
        services.AddTransient<IAccountJobRepository, AccountJobRepository>();

        services.AddTransient<ILogApplication, LogApplication>();
        services.AddTransient<ILogRepository, LogRepository>();


        services.AddDbContext<AccountContext>(x => x.UseSqlServer(connectionString));


    }

}
