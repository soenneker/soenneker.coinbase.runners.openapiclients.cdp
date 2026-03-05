using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Coinbase.Runners.OpenApiClients.Cdp.Tests;

[Collection("Collection")]
public sealed class CoinbaseCdpOpenApiClientRunnerTests : FixturedUnitTest
{
    public CoinbaseCdpOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
