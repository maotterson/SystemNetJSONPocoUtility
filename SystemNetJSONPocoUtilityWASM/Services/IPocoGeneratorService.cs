namespace SystemNetJSONPocoUtilityWASM.Services;

public interface IPocoGeneratorService
{
    string GeneratePoco(string pnamespace, string pclass, string json);
}
