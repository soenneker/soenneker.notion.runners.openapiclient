using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Notion.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class NotionOpenApiClientRunnerTests : FixturedUnitTest
{
    public NotionOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
