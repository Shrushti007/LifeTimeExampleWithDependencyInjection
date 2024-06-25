using LifeTimeExampleWithDependencyInjection.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient(typeof(ISupplierRepository), typeof(SupplierRepository));
builder.Services.AddSession();
//builder.Services.AddSingleton(typeof(ISupplierRepository), typeof(SupplierRepository));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();

app.UseAuthorization();
SessionOptions options = new SessionOptions();
//options.Cookie.Expiration= TimeSpan.FromMinutes(10);
options.IdleTimeout= TimeSpan.FromMinutes(2);
options.IOTimeout= TimeSpan.FromMinutes(1);
app.UseSession(options);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
