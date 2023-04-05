var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

var isDevelopment = builder.Environment.IsDevelopment();

string environmentName = null;
#if DEBUG
environmentName = "Development";
#elif RELEASE
environmentName = "Development";
#elif TESTING
environmentName = "Testing";
#elif STAGING 
environmentName = "Staging";
#else
environmentName = "Production";
#endif

builder.Configuration.AddJsonFile($"appsettings.{environmentName}.json", optional: true);
builder.Configuration.AddEnvironmentVariables();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
