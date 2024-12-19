using CoffeeShop.Models;

var builder = WebApplication.CreateBuilder(args);

// Register services (equivalent to ConfigureServices in Startup.cs)
builder.Services.AddRazorPages();
builder.Services.AddSingleton<List<CoffeeProduct>>();  // In-memory storage for coffee products
builder.Services.AddSingleton<List<Order>>();  // In-memory storage for orders

// Listen on port 8080 and all network interfaces
builder.WebHost.UseUrls("http://0.0.0.0:8080");

var app = builder.Build();

// Configure middleware (equivalent to Configure in Startup.cs)
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();

app.Run();
