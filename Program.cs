using Frapi.Source.Setup.Pipeline;

var builder = WebApplication.CreateBuilder(args);
    builder.AddBuildPipelines();

var app = builder.Build();
    app.UseAppPipelines();
