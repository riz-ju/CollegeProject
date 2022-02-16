//using CollegeProjectAPI;
using AutoMapper;
using CollegeProjectAPI;
using CollegeProjectRepository.Interface;
using CollegeProjectRepository.Repository;
using CollegeProjectServices.Interface;
using CollegeProjectServices.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.RegisterServices();
//builder.Services.AddSingleton<IStudentService, StudentService>();
//builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var mapperConfig = new MapperConfiguration(mc => {
    mc.AddProfile(new MappingProfile());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

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
