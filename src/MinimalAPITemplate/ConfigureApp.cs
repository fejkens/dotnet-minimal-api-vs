namespace MinimalAPITemplate;

public static class ConfigureApp
{
    public static void Configure(this WebApplication app)
    {
        app.MapOpenApi();
        app.UseHttpsRedirection();
    }
}