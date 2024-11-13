using FastEndpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddFastEndpoints();

var app = builder.Build();

app.UseFastEndpoints(c =>
{
    c.Serializer.CharacterEncoding = null;
    c.Serializer.Options.TypeInfoResolverChain.Add(ApiJsonSerializerContext.Default);
});
app.Run();
