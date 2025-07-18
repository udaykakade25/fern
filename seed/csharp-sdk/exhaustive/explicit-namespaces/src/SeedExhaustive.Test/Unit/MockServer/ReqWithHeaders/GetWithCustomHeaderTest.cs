using NUnit.Framework;
using SeedExhaustive.Test.Unit.MockServer;

namespace SeedExhaustive.Test.Unit.MockServer.ReqWithHeaders;

[TestFixture]
public class GetWithCustomHeaderTest : BaseMockServerTest
{
    [Test]
    public void MockServerTest()
    {
        const string requestJson = """
            "string"
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/test-headers/custom-header")
                    .WithHeader("X-TEST-SERVICE-HEADER", "X-TEST-SERVICE-HEADER")
                    .WithHeader("X-TEST-ENDPOINT-HEADER", "X-TEST-ENDPOINT-HEADER")
                    .UsingPost()
                    .WithBody(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.ReqWithHeaders.GetWithCustomHeaderAsync(
                new SeedExhaustive.ReqWithHeaders.ReqWithHeaders
                {
                    XTestEndpointHeader = "X-TEST-ENDPOINT-HEADER",
                    XTestServiceHeader = "X-TEST-SERVICE-HEADER",
                    Body = "string",
                }
            )
        );
    }
}
