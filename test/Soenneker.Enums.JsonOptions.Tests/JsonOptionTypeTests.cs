using Soenneker.Tests.HostedUnit;

namespace Soenneker.Enums.JsonOptions.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class JsonOptionTypeTests : HostedUnitTest
{
    public JsonOptionTypeTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
