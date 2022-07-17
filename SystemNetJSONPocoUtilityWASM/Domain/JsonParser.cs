using System.Text.Json;

namespace SystemNetJSONPocoUtilityWASM.Domain;

public static class JsonParser
{
    public static bool TryParse(string rawJson, out string parsedPocoString)
    {
        parsedPocoString = "";
        try
        {
            var flatJson = rawJson.DeserializeAndFlatten();
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
    public static Dictionary<string, object> DeserializeAndFlatten(this string json)
    {
        Dictionary<string, object> dict = new Dictionary<string, object>();
        JsonDocument document = JsonDocument.Parse(json);
        return dict;
    }
}