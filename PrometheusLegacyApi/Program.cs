using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PrometheusLegacyApi.Persistence;

var builder = WebApplication.CreateBuilder(args);
var serverVersion = new MySqlServerVersion(new Version(5, 6, 45));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AstorgaDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(builder.Configuration.GetConnectionString("AstorgaConnection"), serverVersion));

builder.Services.AddDbContext<InfanteDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(builder.Configuration.GetConnectionString("InfanteConnection"), serverVersion));

builder.Services.AddDbContext<LaFloridaDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(builder.Configuration.GetConnectionString("LafloridaConnection"), serverVersion));

builder.Services.AddDbContext<MaciverDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(builder.Configuration.GetConnectionString("MaciverConnection"), serverVersion));

builder.Services.AddDbContext<SanAntonioDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(builder.Configuration.GetConnectionString("SanAntonioConnection"), serverVersion));

builder.Services.AddDbContext<SanAntonioDosDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(builder.Configuration.GetConnectionString("SanAntonio2Connection"), serverVersion));

builder.Services.AddDbContext<SantaRosaDbContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(builder.Configuration.GetConnectionString("SantaRosaConnection"), serverVersion));

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
