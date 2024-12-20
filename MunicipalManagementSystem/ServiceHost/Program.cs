using _0_Framework.Application;
using _0_Framework.Infrastructure;
using AccountManagement.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MunicipalityManagement.Configuration;
using PersonManagement.Configuration;
using ServiceHost;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Unicode;



var builder = WebApplication.CreateBuilder(args);

//register servicse


builder.Services.AddHttpContextAccessor();

var connectionString = builder.Configuration.GetConnectionString("MunicipalDb");

MunicipalityManagementBoostapper.Configure(builder.Services, connectionString);

AccountManagementBootstrapper.Configure(builder.Services, connectionString);

PersonManagementBootstrapper.Configure(builder.Services, connectionString);

builder.Services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Arabic));

builder.Services.AddSingleton<IPasswordHasher, PasswordHasher>();
builder.Services.AddTransient<IFileUploader, FileUploader>();
builder.Services.AddTransient<IAuthHelper, AuthHelper>();


builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.Lax;
});


builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, o =>
    {
        o.LoginPath = new PathString("/Account");
        o.LogoutPath = new PathString("/Account");
        o.AccessDeniedPath = new PathString("/AccessDenied");
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminArea",

        builder => builder.RequireRole(new List<string> { Roles.Administrator, Roles.SystemUser, Roles.k1 ,
                    Roles.k2 , Roles.k3, Roles.k4, Roles.k5, Roles.k6, Roles.k7,
                    Roles.k8, Roles.k9, Roles.k10, Roles.k11, Roles.k12, Roles.k13, Roles.k14, Roles.k15 }));

});

builder.Services.AddRazorPages()
    .AddRazorPagesOptions(options =>
    {
        _ = options.Conventions.AuthorizeAreaFolder("Administration", "/", "AdminArea");
    });




var app = builder.Build();


//Create http pipline

if (builder.Environment.IsDevelopment())
{
    _ = app.UseDeveloperExceptionPage();
}
else
{
    _ = app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    _ = app.UseHsts();
}

app.UseAuthentication();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCookiePolicy();
app.UseRouting();

app.UseAuthorization();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapRazorPages();
//    endpoints.MapDefaultControllerRoute();
//    endpoints.MapControllers();
//});

app.MapRazorPages();
app.MapControllers();

app.Run();