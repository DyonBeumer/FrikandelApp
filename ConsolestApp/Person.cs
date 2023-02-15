using System.Text.Json.Serialization;

public class Person
{
    public Meta Id { get; set; } = new();

    [JsonPropertyName("FirstName")]
    public string FirstName { get; set; } = string.Empty;

    [JsonPropertyName("LastName")]
    public string LastName { get; set; } = string.Empty;
}