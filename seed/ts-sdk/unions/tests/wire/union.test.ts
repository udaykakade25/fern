/**
 * This file was auto-generated by Fern from our API Definition.
 */

import { mockServerPool } from "../mock-server/MockServerPool";
import { SeedUnionsClient } from "../../src/Client";

describe("Union", () => {
    test("get", async () => {
        const server = mockServerPool.createServer();
        const client = new SeedUnionsClient({ environment: server.baseUrl });

        const rawResponseBody = { type: "circle", radius: 1.1, id: "id" };
        server.mockEndpoint().get("/id").respondWith().statusCode(200).jsonBody(rawResponseBody).build();

        const response = await client.union.get("id");
        expect(response).toEqual({
            type: "circle",
            radius: 1.1,
        });
    });

    test("update", async () => {
        const server = mockServerPool.createServer();
        const client = new SeedUnionsClient({ environment: server.baseUrl });
        const rawRequestBody = { type: "circle", radius: 1.1, id: "id" };
        const rawResponseBody = true;
        server
            .mockEndpoint()
            .patch("")
            .jsonBody(rawRequestBody)
            .respondWith()
            .statusCode(200)
            .jsonBody(rawResponseBody)
            .build();

        const response = await client.union.update({
            type: "circle",
            radius: 1.1,
        });
        expect(response).toEqual(true);
    });
});
