using Soenneker.Tests.HostedUnit;

namespace Soenneker.Notion.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class NotionOpenApiClientRunnerTests : HostedUnitTest
{
    public NotionOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
