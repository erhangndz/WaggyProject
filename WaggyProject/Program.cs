using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;
using WaggyProject.Context;
using WaggyProject.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<WaggyContext>();

builder.Services.AddIdentity<AppUser, AppRole>(option =>
{
    option.User.RequireUniqueEmail = true;
})
                .AddEntityFrameworkStores<WaggyContext>();

builder.Services.AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters()
                .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

builder.Services.AddControllersWithViews();

builder.Services.ConfigureApplicationCookie(config =>
{
    config.LoginPath = "/Login/Index";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
