using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

var isDevelopment = builder.Environment.IsDevelopment();

string environmentName = null;
#if DEBUG
environmentName = "Development";
#elif RELEASE
environmentName = "Development";
#elif TEST
environmentName = "Test";
#elif STAGING
environmentName = "Staging";
#else
environmentName = "Production";
#endif

builder.Configuration.AddJsonFile($"appsettings.{environmentName}.json", optional: true);
builder.Configuration.AddEnvironmentVariables();


var app = builder.Build();

var indexUI = builder.Configuration["UI:Index:Header"];

Debug.WriteLine("Header is: " + indexUI);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//alii

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
