using Soenneker.Coinbase.Runners.OpenApiClients.Cdp.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Coinbase.Runners.OpenApiClients.Cdp.Tests;

[Collection("Collection")]
public sealed class CoinbaseCdpOpenApiClientRunnerTests : FixturedUnitTest
{
    private readonly ICoinbaseCdpOpenApiClientRunner _openapirunner;

    public CoinbaseCdpOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _openapirunner = Resolve<ICoinbaseCdpOpenApiClientRunner>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
