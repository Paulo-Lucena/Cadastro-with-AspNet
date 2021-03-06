using AutoMapper;
using LucenaSolutions.Intern.APICadastro.Web.Data;
using LucenaSolutions.Intern.APICadastro.Web.DTOs.Mappings;
using LucenaSolutions.Intern.APICadastro.Web.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container and Json Serelializer.

builder.Services.AddControllers().AddJsonOptions(options =>
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

//ConnectionString
var mySqlConnection = builder.Configuration.GetConnectionString("ConexaoPadraoMySQL");

builder.Services.AddDbContext<AppDBContext>(options =>
    options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)));

//Unit Of Work 
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//Mapper
var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

IMapper mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
