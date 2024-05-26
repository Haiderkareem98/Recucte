using Microsoft.EntityFrameworkCore;
using Recruit_Form.Data;
using Recruit_Form.Repository;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Recruit_Form.Mapper;
using Recruit_Form.Model;
using Microsoft.AspNetCore.Identity;
using Recruit.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DbContextApp1>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")));
builder.Services.AddScoped<IInformationRepository, RepoInformtoin>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

// Add Identity services

builder.Services.AddIdentity<AppUsers, IdentityRole>()
                .AddEntityFrameworkStores<DbContextApp1>()
                .AddDefaultTokenProviders();

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
