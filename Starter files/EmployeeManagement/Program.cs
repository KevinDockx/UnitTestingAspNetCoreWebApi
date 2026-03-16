using EmployeeManagement;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 
// add HttpClient support
builder.Services.AddHttpClient("TopLevelManagementAPIClient");

// register AutoMapper-related services
builder.Services.AddAutoMapper(config => { },
    AppDomain.CurrentDomain.GetAssemblies());

// add other services
builder.Services.RegisterBusinessServices();
builder.Services.RegisterDataServices(builder.Configuration); 

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
