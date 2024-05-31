using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(options =>
{
	options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"),
		b => b.MigrationsAssembly("PersonalBlogApp"));
}	);

builder.Services.AddScoped<IRepositoryManager,RepositoryManager>();
builder.Services.AddScoped<IWritingRepository,WritingRepository>();
builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();

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

app.UseEndpoints(endpoints =>
{
	endpoints.MapAreaControllerRoute(
		name: "Admin",
		areaName: "Admin",
		pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
		
		);
	endpoints.MapControllerRoute(name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
});


app.Run();
