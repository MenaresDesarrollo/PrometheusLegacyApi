using Microsoft.EntityFrameworkCore;
using PrometheusLegacyApi.Persistence;

var builder = WebApplication.CreateBuilder(args);
var serverVersion = new MySqlServerVersion(new Version(8, 0, 31));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AstorgaDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql("AstorgaConnection", serverVersion));

builder.Services.AddDbContext<InfanteDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql("InfanteConnection", serverVersion));

builder.Services.AddDbContext<LaFloridaDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql("LafloridaConnection", serverVersion));

builder.Services.AddDbContext<MaciverDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql("MaciverConnection", serverVersion));

builder.Services.AddDbContext<SanAntonioDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql("SanAntonioConnection", serverVersion));

builder.Services.AddDbContext<SanAntonioDosDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql("SanAntonio2Connection", serverVersion));

builder.Services.AddDbContext<SantaRosaDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql("SantaRosaConnection", serverVersion));

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
