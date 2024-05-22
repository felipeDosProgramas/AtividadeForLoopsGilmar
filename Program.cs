using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddRazorPages();
    builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(new StaticFileOptions {
    FileProvider = new PhysicalFileProvider(
        Path.Combine(builder.Environment.ContentRootPath, "Assets")
    ),
    RequestPath = "/assets"
});
app.UseHttpsRedirection();
app.UseRouting();
app.MapControllerRoute(
    "default",
    "{controller=ControllerGeral}/{action=Index}"
);
app.MapRazorPages();
app.Run();
