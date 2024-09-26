using Microsoft.EntityFrameworkCore;
using DP.Repo.BusinessLayer.Abstract;
using DP.Repo.BusinessLayer.Concrete;
using DP.Repo.DataAccessLayer.Abstract;
using DP.Repo.DataAccessLayer.Concrete;
using DP.Repo.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICategoryDAL, EFCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductDAL, EFProductDal>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddEntityFrameworkNpgsql().AddDbContext<Context>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
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
