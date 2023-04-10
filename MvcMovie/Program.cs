var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

//configure new map route
// app.MapControllerRoute(name: "selam", pattern: "/hi", defaults: new { controller = "HelloWorld", action = "Index" });
// app.UseEndpoints(endpoints =>
// {
//     endpoints.MapControllerRoute(
//         name: "MyRoute",
//         pattern: "hi/{name?}/{numTimes?}",
//         defaults: new { controller = "HelloWorld", action = "Welcome" });
// });

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
