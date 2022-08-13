
using Microsoft.EntityFrameworkCore;
using BooksLibrary.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LibraryBooksContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BooksLibraryContext"));
});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var services =scope.ServiceProvider;
    SeedData.Initialize(services);
}

    app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
