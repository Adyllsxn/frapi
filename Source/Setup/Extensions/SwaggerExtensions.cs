

namespace Frapi.Source.Setup.Extensions;
public static class SwaggerExtensions
{
    public static void AddSwaggerExtensions(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen(
            c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo{
                        Title = "Frapi",
                        Version = "v1",
                        Description = "A ready-to-run mock API built with ASP.NET Core, designed for frontend developers to practice without setting up a backend. Offline. Simple. Fast. "
                    });
                }
        );
    }

    public static void UseSweggerExtensions(this WebApplication app)
    {
        if(app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Frapi v1");
                    c.ConfigObject.AdditionalItems["locale"] = "en";
                });
            }
    }
}