using FastEndpoints;

namespace EmptyObjectRepro
{
    internal sealed class GetVersionEndpoint : EndpointWithoutRequest<GetVersionResponse>
    {
        private static readonly GetVersionResponse ApiVersion = new("22");
        public override void Configure()
        {
            AllowAnonymous();
            Get("/info/version");
            Description(x => x.WithDescription("Use this endpoint to check current application version."));
        }

        public override Task<GetVersionResponse> ExecuteAsync(CancellationToken ct)
            => Task.FromResult(ApiVersion);
    }
}
