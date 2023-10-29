using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using TP_Tankopedia_ASP.Data;
using TP_Tankopedia_ASP.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TankopediaDbContext>(options =>
 options.UseSqlServer(builder.Configuration.GetConnectionString("Tankopedia") ?? throw new InvalidOperationException("Connection string 'Tankopedia' not found."))
    .UseLazyLoadingProxies());
//Identity/Role
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<TankopediaDbContext>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 5;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
});

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false; //Lors du d�veloppement
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidAudience = "http://localhost:4200",
        ValidIssuer = "http://localhost:5145",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("AiciEunSirDeCaractereCareVaFiFolositPentruACodaCheia"))
    };
});

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
app.UseAuthentication();
app.UseAuthorization();
//app.MapControllers();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
