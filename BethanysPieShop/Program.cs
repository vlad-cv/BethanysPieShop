using BethanysPieShop.Models;

var builder = WebApplication.CreateBuilder(args);

// Add MVC services to the container.
builder.Services.AddControllersWithViews();

// Register application services for dependency injection.
builder.Services.AddScoped<IPieRepository, MockPieRepository>();
builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();


var app = builder.Build();


// if the app is in development mode, use the developer exception page
if (app.Environment.IsDevelopment())
{
    // In development environments, use the developer exception page to display detailed error information.
    app.UseDeveloperExceptionPage();
}
else
{
    // In non-development environments, use the exception handler middleware to handle exceptions.
    app.UseExceptionHandler("Home/Error");

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Add HTTPS redirection middleware to the request pipeline.
app.UseHttpsRedirection();

// Add static files middleware to the request pipeline.
app.UseStaticFiles();

// Add routing middleware to the request pipeline.
app.UseRouting();

// Add authentication middleware to the request pipeline.
app.UseAuthentication();

// Add authorization middleware to the request pipeline.
app.UseAuthorization();

// Add routing middleware to the request pipeline.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

#region  // Another options to map controller routes for mvc or apis development
// Another option to app.MapControllerRoute 
// app.MapDefaultControllerRoute();

// Map controller endpoints.
// app.MapControllers();

#endregion

app.Run();
