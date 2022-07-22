using System.Text.Json;

namespace SystemNetJSONPocoUtilityWASM.Domain;

public static class JsonParser
{
    public static bool TryParse(string rawJson, out string parsedPocoString)
    {
        parsedPocoString = "";
        try
        {
            var jsonAsDictionary = rawJson.DeserializeAndFlatten()!;
            foreach (var kvp in jsonAsDictionary)
            {
                var key = kvp.Key;
                var kind = kvp.Value.ValueKind;

                parsedPocoString += $"\t[JsonPropertyName(\"{key}\")] public {kind} {key} {{get; init;}}\n";
            }
                
            return true;
        }
        catch
        {
            parsedPocoString = "";
            return false;
        }
    }
}
public static class JsonParserExtensions
{
    public static Dictionary<string, JsonElement>? DeserializeAndFlatten(this string json)
    {
        var dict = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json);
        return dict;
    } 
}