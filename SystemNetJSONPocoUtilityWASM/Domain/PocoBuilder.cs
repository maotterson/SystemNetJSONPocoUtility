using System.Text;

namespace SystemNetJSONPocoUtilityWASM.Domain;

public class PocoBuilder
{
    public StringBuilder Output { get; set; } = new StringBuilder();
    public string BuildString()
    {
        return Output.ToString();
    }
}
