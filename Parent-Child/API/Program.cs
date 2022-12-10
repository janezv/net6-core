using API.Models;
using Microsoft.EntityFrameworkCore;
using API.Controllers;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ParentChildrenContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddCors(options => options.AddPolicy(name: "Parent-Child-Appi",
  policy =>
  {
      policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
  }));

var app = builder.Build();

app.UseCors("Parent-Child-Appi");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.UseExceptionHandler();
}
app.UseDeveloperExceptionPage();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//app.MapParentEndpoints();

app.Run();
