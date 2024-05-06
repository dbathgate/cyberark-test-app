using Steeltoe.Common.Hosting;
using Steeltoe.Extensions.Configuration.CloudFoundry;
using Steeltoe.Management.Endpoint;

var builder = WebApplication.CreateBuilder(args);

builder.AddCloudFoundryConfiguration();
builder.UseCloudHosting();
builder.AddAllActuators();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapAllActuators(ep => ep.AllowAnonymous());

app.Run();
