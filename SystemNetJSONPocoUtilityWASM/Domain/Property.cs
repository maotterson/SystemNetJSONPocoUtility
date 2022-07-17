namespace SystemNetJSONPocoUtilityWASM.Domain;

public class Property
{
    public string JsonName { get; init; } = default!;
    public string PropType { get; init; } = default!;
    public bool IsCollection { get; init; } = default!;
    public string PropName { get; init; } = default!;

}
