using Microsoft.EntityFrameworkCore;
using PostgreWithEFCore.Domains;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

//builder.Services.AddEntityFrameworkNpgsql().AddDbContext<AppDbContext>(options =>
//    options.UseNpgsql(builder.Configuration.GetConnectionString("dbConnection"))
//);


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("dbConnection"))
);


var app = builder.Build();



app.UseAuthorization();

app.MapControllers();

app.Run();
