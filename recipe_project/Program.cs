using BLL.function;
using BLL.interfaces;
using DAL.function;
using DAL.interfaces;
using DAL.models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IingredientForRecipeBLL, ingredientForRecipeBLL>();
builder.Services.AddScoped<IingredientBLL, ingredientBLL>();
builder.Services.AddScoped<IrecipeTableBLL, recipeTableBLL>();
builder.Services.AddScoped<IuserBLL, userBLL>();
builder.Services.AddScoped<IingredientForRecipeDAL, ingredientForRecipeDAL>();
builder.Services.AddScoped<IingredientDAL, ingredientDAL>();
builder.Services.AddScoped<IrecipeTableDAL, recipeTableDAL>();
builder.Services.AddScoped<IuserDAL, userDAL>();
builder.Services.AddDbContext<recipe_thContext>(y => y.UseSqlServer("Server=kitotSrv\\sql;Database=recipe_th;Trusted_Connection=True;TrustServerCertificate=True;"));
builder.Services.AddCors(p => p.AddPolicy("corspolicy", builder =>
{
    builder
     .AllowAnyOrigin()
    .AllowAnyMethod()
     .AllowAnyHeader();
}));


var app = builder.Build();
app.UseCors("corspolicy");
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}





app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
