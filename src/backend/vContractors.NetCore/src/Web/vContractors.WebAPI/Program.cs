using vContractors.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;
using vContractors.Infrastructure;
using vContractors.Infrastructure.Identity;
using vContractors.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

Dependencies.ConfigureServices(builder.Configuration, builder.Services);

// Add services to the container.
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<AppIdentityDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var scopedProvider = scope.ServiceProvider;
    try
    {
        var coreDbContext = scopedProvider.GetRequiredService<CoreDbContext>();
        await CoreDbContextSeed.SeedAsync(coreDbContext);

        var userManager = scopedProvider.GetRequiredService<UserManager<User>>();
        var roleManager = scopedProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var identityContext = scopedProvider.GetRequiredService<AppIdentityDbContext>();
        await AppIdentityDbContextSeed.SeedAsync(identityContext, userManager, roleManager);
    }
    catch (Exception ex)
    {
        app.Logger.LogError(ex, "An error occurred seeding the DB.");
    }
}

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
