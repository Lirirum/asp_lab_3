using WebApplication5;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();  

builder.Services.AddTransient<CalcService>();
builder.Services.AddTransient<TimeOfDayService>();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Calculator}/{action=Index}/{id?}");


app.Run();
