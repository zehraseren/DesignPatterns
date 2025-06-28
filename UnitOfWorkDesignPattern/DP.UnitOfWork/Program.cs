using Microsoft.EntityFrameworkCore;
using DP.UOW.BusinessLayer.Abstract;
using DP.UOW.BusinessLayer.Concrete;
using DP.UOW.DataAccessLayer.Concrete;
using DP.UOW.DataAccessLayer.Abstract;
using DP.UOW.DataAccessLayer.UnitOfWork;
using DP.UOW.EntityLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICustomerDAL, EFCustomerDAL>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();
builder.Services.AddScoped<IUnitOfWorkDAL, UnitOfWorkDAL>();
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<Context>(opt =>
opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
