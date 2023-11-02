using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
//using TP_Tankopedia_ASP.DbInitializer;
using TP_Tankopedia_ASP.Data;
using TP_Tankopedia_ASP.Models;
using TP_Tankopedia_ASP.Services;
using TP_Tankopedia_ASP.Utility;

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
    options.RequireHttpsMetadata = false; //Lors du développement
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidAudience = builder.Configuration["JWT:ValidAudience"],
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:SecretKey"]))
    };
});
builder.Services.AddScoped<ITankopediaUsersService, TankopediaUsersService>();
builder.Services.AddScoped<IUploadImageService, UploadImageService>();
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
void SeedDatabase()
{
    using (var scope = app.Services.CreateScope())
    {
        var initUserRole = scope.ServiceProvider.GetRequiredService<ITankopediaUsersService>();
        initUserRole.AssignRolesToUser("admin@tankopedia.ca", AppConstants.AdminRole);
        initUserRole.AssignRolesToUser("commander@tankopedia.ca", AppConstants.TankCommander);
        initUserRole.AssignRolesToUser("visitor@tankopedia.ca", AppConstants.Visitor);
    }
}
SeedDatabase();

//CreateRoles(ServiceProvider);
//app.MapControllers();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
