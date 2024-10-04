using EmptyObjectRepro;
using System.Text.Json.Serialization;

[JsonSerializable(typeof(GetVersionResponse))]

internal sealed partial class ApiJsonSerializerContext : JsonSerializerContext
{
}
