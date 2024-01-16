var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLogging(opt =>
{
    opt.AddConsole();
});

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.PropertyNamingPolicy = null;
});
builder.Services.AddSingleton<IServiceCRUD<WeatherForecast>, WeatherForecastService>();
builder.Services.AddSingleton<IServiceCRUD<Carro>, CarroService>();
builder.Services.AddSingleton<DesignPatternsLogger>();

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
