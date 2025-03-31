using PersonData.DatabaseLayer;
using PersonRestService.BusinesslogicLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register services for DI
builder.Services.AddSingleton<IPersonAccess, PersonDatabaseAccess>();
builder.Services.AddSingleton<IPersonData, PersonDataLogic>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
