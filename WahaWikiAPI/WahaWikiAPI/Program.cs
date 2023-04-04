using Microsoft.EntityFrameworkCore;
using WahaWikiAPI.Database;
using WahaWikiAPI.Services;

var builder = WebApplication.CreateBuilder(args);

var myAllowSpecificOrigins = "myAllowSpecificOrigins";


// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<WahaDbContext>(
    options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

builder.Services.AddTransient<IWeaponService, WeaponService>();
builder.Services.AddTransient<IUnitService, UnitService>();
builder.Services.AddTransient<IAbilityService, AbilityService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins, builder =>
    {
        builder.WithOrigins("http://localhost:4200")
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(myAllowSpecificOrigins);
app.UseAuthorization();
app.MapControllers();

app.Run();
