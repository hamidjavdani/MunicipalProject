using Microsoft.EntityFrameworkCore;
using PersonManagement.Domain.PersonAgg;
using PersonMangement.Infrastructure.EFCore.Mapping;

namespace PersonMangement.Infrastructure.EFCore;

public class PersonContext : DbContext
{

    public DbSet<Person> Persons { get; set; }
    //public DbSet<Role> Roles { get; set; }

    public PersonContext(DbContextOptions<PersonContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var assembly = typeof(PersonMapping).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        base.OnModelCreating(modelBuilder);
    }
}



