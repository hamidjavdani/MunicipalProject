using _0_Framework.Infrastructure;
using _01_MunicipalQuery.Contracts.Slide;
using _01_MunicipalQuery.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MunicipalityManagement.Application;
using MunicipalityManagement.Application.Contracts.Darkhast;
using MunicipalityManagement.Application.Contracts.ListBox;
using MunicipalityManagement.Application.Contracts.ListBoxCategory;
using MunicipalityManagement.Application.Contracts.ListKarbari;
using MunicipalityManagement.Application.Contracts.ListTabaghat;
using MunicipalityManagement.Application.Contracts.Melk;
using MunicipalityManagement.Application.Contracts.Order;
using MunicipalityManagement.Application.Contracts.Request;
using MunicipalityManagement.Application.Contracts.Sakhteman;
using MunicipalityManagement.Application.Contracts.Slide;
using MunicipalityManagement.Application.Contracts.TitleRequest;
using MunicipalityManagement.Domain.DarkhastAgg;
using MunicipalityManagement.Domain.ListBoxAgg;
using MunicipalityManagement.Domain.ListBoxCategoryAgg;
using MunicipalityManagement.Domain.ListKarbariAgg;
using MunicipalityManagement.Domain.ListTabaghatAgg;
using MunicipalityManagement.Domain.MelkAgg;
using MunicipalityManagement.Domain.OrderAgg;
using MunicipalityManagement.Domain.RequestAgg;
using MunicipalityManagement.Domain.SakhtemanAgg;
using MunicipalityManagement.Domain.SlideAgg;
using MunicipalityManagement.Domain.Title_RequestAgg;
using MunicipalityManagement.Infrastructure.Configuration.Permissions;
using MunicipalityManagement.Infrastructure.EFCore;
using MunicipalityManagement.Infrastructure.EFCore.Repository;


namespace MunicipalityManagement.Configuration;

public class MunicipalityManagementBoostapper
{
    public static void Configure(IServiceCollection services, string connectionString)
    {
        services.AddTransient<IMelkApplication, MelkApplication>();
        services.AddTransient<IMelkRepository, MelkRepository>();

        services.AddTransient<ISakhtemanApplication, SakhtemanApplication>();
        services.AddTransient<ISakhtemanRepository, SakhtemanRepository>();

        services.AddTransient<IListBoxCategoryApplication, ListBoxCategoryApplication>();
        services.AddTransient<IListBoxCategoryRepository, ListBoxCategoryRepository>();

        services.AddTransient<IListBoxApplication, ListBoxApplication>();
        services.AddTransient<IListBoxRepository, ListBoxRepository>();


        services.AddTransient<IListTabaghatApplication, ListTabaghatApplication>();
        services.AddTransient<IListTabaghatRepository, ListTabaghatRepository>();


        services.AddTransient<IListKarbariApplication, ListKarbariApplication>();
        services.AddTransient<IListKarbariRepository, ListKarbariRepository>();


        services.AddTransient<ISlideApplication, SlideApplication>();
        services.AddTransient<ISlideRepository, SlideRepository>();


        services.AddTransient<IDarkhastApplication, DarkhastApplication>();
        services.AddTransient<IDarkhastRepository, DarkhastRepository>();

        services.AddTransient<IOrderApplication, OrderApplication>();
        services.AddTransient<IOrderRepository, OrderRepository>();


        services.AddTransient<ITitleRequestApplication, TitleRequestApplication>();
        services.AddTransient<ITitleRequestRepository, TitleRequestRepository>();


        services.AddTransient<IRequestApplication, RequestApplication>();
        services.AddTransient<IRequestRepository, RequestRepository>();



        services.AddTransient<ISlideQuery, SlideQuery>();

        services.AddTransient<IPermissionExposer, MunicipalityPermissionExposer>();

        services.AddDbContext<MunicipalityContext>(x => x.UseSqlServer(connectionString));
    }
}
