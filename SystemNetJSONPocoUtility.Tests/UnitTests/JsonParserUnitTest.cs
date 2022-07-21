using FluentAssertions;
using SystemNetJSONPocoUtilityWASM.Domain;

namespace SystemNetJSONPocoUtility.Tests.UnitTests;

public class JsonParserUnitTest
{
    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { json, dict }
        };

    public static Dictionary<string, string> dict = new Dictionary<string, string>
    {
        { "name","john doe" }
    };
    const string json = @"{""name"":""john doe""}";

    [Theory]
    [MemberData(nameof(Data))]
    public void DeserializeAndFlatten_ShouldReturnPropertyKVP_WhenValidJsonProvided(string rawJson, Dictionary<string, string> expected)
    {
        // Arrange

        // Act
        var actual = rawJson.DeserializeAndFlatten();

        // Assert
        actual.Should().BeEquivalentTo(expected);

    }
}