namespace Frapi.Source.Setup.Extensions;
public static class DIExtensions
{
    public static void AddDIExtensions(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IPublicUserRepository, PublicUserRepository>();
    }
}
