using Microsoft.EntityFrameworkCore;
using MilesAhead.Components;
using MilesAhead.Web;
using MilesAhead.Web.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


// ~ benkimz: more custom services
builder.Services.AddDbContext<WireFramesDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AzureDB"), b => b.MigrationsAssembly("MilesAhead.Web"));
});

builder.Services.AddSingleton<WireframeParser>();
// ~ benkimz: end custom services

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
