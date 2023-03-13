using BolsaEmpleo;
using BolsaEmpleo.BIL.LANDING;
using BolsaEmpleo.DAL.DBContext;
using BolsaEmpleo.DAL.LANDING;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Configuration;
using System.Globalization;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();


builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders =
        ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("EnableCORS", build =>
    {
        var listCords = new List<string>();
        builder.Configuration.GetSection("cords").Bind(listCords);
        listCords.ForEach(x => build.WithOrigins(x).Build());
        build.AllowAnyHeader().Build();
        build.AllowAnyMethod().Build();
        build.AllowCredentials().Build();
    });
});


BolsaEmpleoSystem.addInstanceSystem(builder.Services);
var app = builder.Build();
ConfigurationManager configuration = builder.Configuration; // allows both to access and to set up the config
IHostEnvironment environment = builder.Environment;
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("EnableCORS");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

if (!app.Environment.IsDevelopment())
    app.Run("http://localhost:5050");//desarrollo
else
    app.Run();

var cultureInfo = new CultureInfo("es-EC");

CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

