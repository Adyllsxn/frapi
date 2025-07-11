namespace Frapi.Source.Setup.Extensions;
public static class DbExtensions
{
    #region AddDbExtensions
        public static void AddDbExtensions(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("FrapiDb"));
        }
    #endregion

    #region UseDbExtensions
        public static void UseDbExtensions(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                db.Database.EnsureCreated(); // Aplica o HasData
            }
        }
    #endregion
}
