var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//allows us to use static files
app.UseStaticFiles();

app.MapGet("/", () => "Hello World!");

app.Run();
