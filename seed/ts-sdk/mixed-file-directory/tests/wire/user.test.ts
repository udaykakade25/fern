/**
 * This file was auto-generated by Fern from our API Definition.
 */

import { mockServerPool } from "../mock-server/MockServerPool";
import { SeedMixedFileDirectoryClient } from "../../src/Client";

describe("User", () => {
    test("list", async () => {
        const server = mockServerPool.createServer();
        const client = new SeedMixedFileDirectoryClient({ environment: server.baseUrl });

        const rawResponseBody = [
            { id: "id", name: "name", age: 1 },
            { id: "id", name: "name", age: 1 },
        ];
        server.mockEndpoint().get("/users/").respondWith().statusCode(200).jsonBody(rawResponseBody).build();

        const response = await client.user.list({
            limit: 1,
        });
        expect(response).toEqual([
            {
                id: "id",
                name: "name",
                age: 1,
            },
            {
                id: "id",
                name: "name",
                age: 1,
            },
        ]);
    });
});
