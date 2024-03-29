using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WireFrames.Core;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ~ benkimz: add custiom services for required operations
builder.Services.AddDbContext<WireFramesDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AzureDB"), b => b.MigrationsAssembly("MilesAhead.Web"));
});
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<IWireFramesRepository, WireFramesRepository>();
builder.Services.AddTransient<IPrimeRootRepository, PrimeRootRepository>();
builder.Services.AddTransient<IRecursiveReader, RecursiveReader>();
builder.Services.AddScoped<WireFramesRepository>();
builder.Services.AddScoped<PrimeRootRepository>();
builder.Services.AddScoped<RecursiveReader>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/wfs/{id}", (int id) =>
{
    using (var serviceScope = app.Services.CreateScope())
    {
        var recursor = serviceScope.ServiceProvider.GetRequiredService<RecursiveReader>();
        if (recursor == null) return null;
        return recursor.GetWfsById(id);
    }
})
.WithName("GetWireFrameById")
.WithOpenApi();

app.MapPost("/wfs", async ([FromBody] WireFrame wireFrame) =>
{
    using (var serviceScope = app.Services.CreateScope())
    {
        var wfsRepo = serviceScope.ServiceProvider.GetRequiredService<WireFramesRepository>();
        if (wfsRepo == null) return null;
        return await wfsRepo.Add(wireFrame);
    }
})
.WithName("AddWireFrame")
.WithOpenApi();

app.MapPut("/wfs", async ([FromBody] WireFrame wireFrame) =>
{
    using (var serviceScope = app.Services.CreateScope())
    {
        var wfsRepo = serviceScope.ServiceProvider.GetRequiredService<WireFramesRepository>();
        if (wfsRepo == null) return null;
        return await wfsRepo.Update(wireFrame);
    }
})
.WithName("UpdateWireFrame")
.WithOpenApi();

app.MapDelete("/wfs/{id}", (int id) =>
{
    using (var serviceScope = app.Services.CreateScope())
    {
        var recursor = serviceScope.ServiceProvider.GetRequiredService<RecursiveReader>();
        if (recursor == null) return null;
        recursor.DeleteWfsById(id);
        return new { Message = "Deleted" };
    }
})
.WithName("DeleteWireFrame")
.WithOpenApi();

app.MapGet("/prs/{id}", (int id) =>
{
    using (var serviceScope = app.Services.CreateScope())
    {
        var recursor = serviceScope.ServiceProvider.GetRequiredService<RecursiveReader>();
        if (recursor == null) return null;
        return recursor.GetRootById(id);
    }
})
.WithName("GetPrimeRootById")
.WithOpenApi();

app.MapPost("/prs", async ([FromBody] PrimeRoot primeRoot) =>
{
    using (var serviceScope = app.Services.CreateScope())
    {
        var prsRepo = serviceScope.ServiceProvider.GetRequiredService<PrimeRootRepository>();
        if (prsRepo == null) return null;
        return await prsRepo.Add(primeRoot);
    }
})
.WithName("AddPrimeRoot")
.WithOpenApi();

app.MapPut("/prs", async ([FromBody] PrimeRoot primeRoot) =>
{
    using (var serviceScope = app.Services.CreateScope())
    {
        var prsRepo = serviceScope.ServiceProvider.GetRequiredService<PrimeRootRepository>();
        if (prsRepo == null) return null;
        return await prsRepo.Update(primeRoot);
    }
})
.WithName("UpdatePrimeRoot")
.WithOpenApi();

app.MapDelete("/prs/{id}", (int id) =>
{
    using (var serviceScope = app.Services.CreateScope())
    {
        var recursor = serviceScope.ServiceProvider.GetRequiredService<RecursiveReader>();
        if (recursor == null) return null;
        recursor.DeleteRootById(id);
        return new { Message = "Deleted" };
    }
})
.WithName("DeletePrimeRoot")
.WithOpenApi();

app.Run();