var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();

if(!app.Environment.IsDevelopment()) {
 app.UseHsts();
 Console.WriteLine("Modo Produccion");
}
app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();
app.MapRazorPages();
app.MapGet("/hola", () => "Hola Mundo!");

app.Run();
Console.WriteLine("Finalizando ejecución");
