using Microsoft.EntityFrameworkCore;
using MunicipalityManagement.Domain.DarkhastAgg;
using MunicipalityManagement.Domain.ListBoxAgg;
using MunicipalityManagement.Domain.ListBoxCategoryAgg;
using MunicipalityManagement.Domain.ListKarbariAgg;
using MunicipalityManagement.Domain.ListTabaghatAgg;
using MunicipalityManagement.Domain.MelkAgg;
using MunicipalityManagement.Domain.RequestAgg;
using MunicipalityManagement.Domain.SakhtemanAgg;
using MunicipalityManagement.Domain.SlideAgg;
using MunicipalityManagement.Domain.Title_RequestAgg;
using MunicipalityManagement.Infrastructure.EFCore.Mapping;

namespace MunicipalityManagement.Infrastructure.EFCore;

public class MunicipalityContext : DbContext
{
    public DbSet<Melk> tblmelk { get; set; }
    public DbSet<Sakhteman> tblsakteman { get; set; }
    public DbSet<ListBoxCategory> tbllistboxcategory { get; set; }
    public DbSet<ListBox> tbllistbox { get; set; }
    public DbSet<Slide> tblslid { get; set; }
    public DbSet<ListTabaghat> tbltabaghat { get; set; }
    public DbSet<ListKarbari> tblkarbari { get; set; }
    public DbSet<Darkhast> tbldarkhast { get; set; }
    public DbSet<Request> tblrequest { get; set; }
    public DbSet<TitleRequest> tbltitlerequest { get; set; }

    public MunicipalityContext(DbContextOptions<MunicipalityContext> option) : base(option)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var assembly = typeof(MelkMapping).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        base.OnModelCreating(modelBuilder);

    }

}
