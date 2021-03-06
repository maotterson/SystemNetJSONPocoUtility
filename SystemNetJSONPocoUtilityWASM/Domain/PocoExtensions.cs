namespace SystemNetJSONPocoUtilityWASM.Domain;

public static class PocoExtensions
{
    public static PocoBuilder AddNamespace(this PocoBuilder builder, string pnamespace)
    {
        builder.Output.Append($"namespace {pnamespace};\n");
        return builder;
    }
    public static PocoBuilder AddClass(this PocoBuilder builder, string pclass)
    {
        builder.Output.AppendLine($"public record {pclass};");
        return builder;
    }
    public static PocoBuilder AddJson(this PocoBuilder builder, string json)
    {
        var isValidJson = JsonParser.TryParse(json, out var parsedJson);
        if (!isValidJson)
        {
            builder.Output.Clear();
            builder.Output.Append("Invalid JSON");
            return builder;
        }

        builder.Output.AppendLine("{");
        builder.Output.Append(parsedJson);
        builder.Output.AppendLine("}");

        return builder;
    }
}