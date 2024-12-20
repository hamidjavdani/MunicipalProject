using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PersonManagement.Application;
using PersonManagement.Application.Contracts.Person;
using PersonManagement.Domain.PersonAgg;
using PersonMangement.Infrastructure.EFCore;
using PersonMangement.Infrastructure.EFCore.Repository;

namespace PersonManagement.Configuration;

public class PersonManagementBootstrapper
{
    public static void Configure(IServiceCollection services, string connectionString)
    {
        services.AddTransient<IPersonApplication, PersonApplication>();
        services.AddTransient<IPersonRepository, PersonRepository>();

        //services.AddTransient<IRoleApplication, RoleApplication>();
        //services.AddTransient<IRoleRepository, RoleRepository>();

        services.AddDbContext<PersonContext>(x => x.UseSqlServer(connectionString));

    }
}
