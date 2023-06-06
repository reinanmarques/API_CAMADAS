using CRUD_ESTUDANTES.Entities;
using CRUD_ESTUDANTES.Persistence;
using CRUD_ESTUDANTES.Repositories;
using CRUD_ESTUDANTES.Repositories.Contract;
using CRUD_ESTUDANTES.Services;
using CRUD_ESTUDANTES.Services.Contract;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var conncetionString = builder.Configuration.GetConnectionString("CrudEstudentCs");
builder.Services.AddDbContext<RepositoryContext>(o => o.UseSqlServer(conncetionString));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddControllers();
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
