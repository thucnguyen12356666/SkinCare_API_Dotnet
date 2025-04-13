var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

//app.Urls.Add("https://0.0.0.0:5000");

//app.ListenAnyIP(5000);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
