using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TP_Tankopedia_ASP.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TankopediaDbContext>(options =>
 options.UseSqlServer(builder.Configuration.GetConnectionString("Tankopedia") ?? throw new InvalidOperationException("Connection string 'Tankopedia' not found."))
    .UseLazyLoadingProxies());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "TP_Tankopedia_ASP", Version = "v1" });
});
//CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("Allow all", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TP_Tankopedia_ASP v1"));
}
//CORS
app.UseRouting();
app.UseCors("Allow all");
app.UseHttpsRedirection();

app.UseAuthorization();
//app.MapControllers();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
