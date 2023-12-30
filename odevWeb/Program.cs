using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using odevWeb.Data;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

var serviceProvider = builder.Services.BuildServiceProvider();
var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
var adminRole = new IdentityRole("Admin");
if (!roleManager.RoleExistsAsync("Admin").Result)
{
    roleManager.CreateAsync(adminRole).Wait();
}
var adminUser = new IdentityUser
{
    UserName = "admin@example.com",
    Email = "admin@example.com",
};
if (userManager.FindByEmailAsync("admin@example.com").Result == null)
{
    var result = userManager.CreateAsync(adminUser, "YourAdminPassword").Result;
    if (result.Succeeded)
    {
        userManager.AddToRoleAsync(adminUser, "Admin").Wait();
    }
}
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
app.MapRazorPages();

app.Run();
