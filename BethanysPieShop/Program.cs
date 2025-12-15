var builder = WebApplication.CreateBuilder(args);

// Add MVC services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Add static files middleware to the request pipeline.
app.UseStaticFiles();

// 
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();
 
app.Run();
