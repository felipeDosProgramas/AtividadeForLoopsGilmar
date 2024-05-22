var builder = WebApplication.CreateSlimBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "mo fita");

app.Run();
