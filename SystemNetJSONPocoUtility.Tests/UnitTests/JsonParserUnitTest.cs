using FluentAssertions;
using System.Text.Json;
using System.Text.Json.Nodes;
using SystemNetJSONPocoUtilityWASM.Domain;

namespace SystemNetJSONPocoUtility.Tests.UnitTests;

public class JsonParserUnitTest
{
    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { json, dict }
        };

    public static Dictionary<string, JsonElement> dict = new Dictionary<string, JsonElement>
    {
        { "name", JsonSerializer.SerializeToElement("john doe") }
    };
    const string json = @"{""name"":""john doe""}";

    [Theory]
    [MemberData(nameof(Data))]
    public void DeserializeAndFlatten_ShouldReturnPropertyKVP_WhenValidJsonProvided(string rawJson, Dictionary<string, JsonElement> expected)
    {
        // Arrange

        // Act
        var actual = rawJson.DeserializeAndFlatten();

        // Assert
        actual.Should().Equal(expected);

    }
}