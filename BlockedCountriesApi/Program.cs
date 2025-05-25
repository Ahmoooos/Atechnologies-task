using BlockedCountriesApi.Interfaces;
using BlockedCountriesApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Enable Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    var xmlFilename = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});



// Register services (from previous steps)
builder.Services.AddSingleton<IBlockedCountriesService, BlockedCountriesService>();
builder.Services.AddHttpClient<BlockedCountriesApi.Services.IpLookupService, BlockedCountriesApi.Services.IpLookupService>();

var app = builder.Build();

// Swagger middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapGet("/", context =>
{
    context.Response.Redirect("/swagger");
    return Task.CompletedTask;
});

app.Run();
