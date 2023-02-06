using API.Configurations;
using API.Context;
using API.Queries;
using API.Interfaces;
using API.Repository;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMailsRepository, MailsRepository>();
builder.Services.AddGraphQLServer().AddQueryType<QueryMails>();
builder.Services.AddDbContext<ApplicationDBContext>();
builder.Services.Configure<DatabaseOptionsConfig>(configuration.GetSection("ConnectionStrings"));

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

app.MapGraphQLHttp("/graphql");

app.Run();
