using NUnit.Framework;
using SeedOauthClientCredentialsWithVariables;
using WireMock.Logging;
using WireMock.Server;
using WireMock.Settings;

namespace SeedOauthClientCredentialsWithVariables.Test.Unit.MockServer;

[SetUpFixture]
public class BaseMockServerTest
{
    protected static WireMockServer Server { get; set; } = null!;

    protected static SeedOauthClientCredentialsWithVariablesClient Client { get; set; } = null!;

    protected static RequestOptions RequestOptions { get; set; } = new();

    private void MockOAuthEndpoint()
    {
        const string requestJson = """
            {
              "client_id": "CLIENT_ID",
              "client_secret": "CLIENT_SECRET",
              "audience": "https://api.example.com",
              "grant_type": "client_credentials",
              "scope": "scope"
            }
            """;

        const string mockResponse = """
            {
              "access_token": "access_token",
              "expires_in": 1,
              "refresh_token": "refresh_token"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/token")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );
    }

    [OneTimeSetUp]
    public void GlobalSetup()
    {
        // Start the WireMock server
        Server = WireMockServer.Start(
            new WireMockServerSettings { Logger = new WireMockConsoleLogger() }
        );

        // Initialize the Client
        Client = new SeedOauthClientCredentialsWithVariablesClient(
            "CLIENT_ID",
            "CLIENT_SECRET",
            clientOptions: new ClientOptions { BaseUrl = Server.Urls[0], MaxRetries = 0 }
        );
        MockOAuthEndpoint();
    }

    [OneTimeTearDown]
    public void GlobalTeardown()
    {
        Server.Stop();
        Server.Dispose();
    }
}
