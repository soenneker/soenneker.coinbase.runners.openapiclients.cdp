using Soenneker.Tests.HostedUnit;

namespace Soenneker.Coinbase.Runners.OpenApiClients.Cdp.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CoinbaseCdpOpenApiClientRunnerTests : HostedUnitTest
{
    public CoinbaseCdpOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
