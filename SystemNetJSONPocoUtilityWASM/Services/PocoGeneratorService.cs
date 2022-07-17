using SystemNetJSONPocoUtilityWASM.Domain;

namespace SystemNetJSONPocoUtilityWASM.Services;

public class PocoGeneratorService : IPocoGeneratorService
{
    public string GeneratePoco(string pnamespace, string pclass, string json)
    {
        var poco = new PocoBuilder();

        poco.AddNamespace(pnamespace)
            .AddClass(pclass)
            .AddJson(json);

        return poco.BuildString();
    }
}

