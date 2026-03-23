namespace MinimalAPITemplate.Users;

public class GetUsers : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app) => app
        .MapGet("/{id}", Handle)
        .WithSummary("Get all users");

    public record Request(int Id);
    public record Response(int Id, string Username);

    private static async Task<Response> Handle([AsParameters] Request request)
    {
        // EF Core logic

        return new Response(1, "Test username");
    }
}