using MinhaPrimeiraApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container (traditional controllers).
builder.Services.AddControllers();
builder.Services.AddScoped<IProdutoService, ProdutoService>();

// Add OpenAPI (Swagger).
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Map Controllers.
app.MapControllers();

app.Run();