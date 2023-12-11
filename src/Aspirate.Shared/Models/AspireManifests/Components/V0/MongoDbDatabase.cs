
namespace Aspirate.Shared.Models.AspireManifests.Components.V0;

[ExcludeFromCodeCoverage]
public class MongoDbDatabase : Resource
{
    /// <summary>
    /// The parent server of the database.
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }
}