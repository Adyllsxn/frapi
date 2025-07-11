namespace Frapi.Source.Setup.Extensions;
public static class CorsExtensions
{
    #region AddCorsExtensions
        public static void AddCorsExtensions(this WebApplicationBuilder builder)
        {
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });
        }
    #endregion

    #region UseCorsExtensions
        public static void UseCorsExtensions(this WebApplication app)
        {
            app.UseCors("AllowAll");
        }
    #endregion
}
