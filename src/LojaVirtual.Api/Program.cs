using LojaVirtual.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<LojaVirtualContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleConnection")));


builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
