/**
 * This file was auto-generated by Fern from our API Definition.
 */

import { mockServerPool } from "../../mock-server/MockServerPool";
import { FiddleClient } from "../../../src/Client";

describe("Put", () => {
    test("add", async () => {
        const server = mockServerPool.createServer();
        const client = new FiddleClient({ token: "test", environment: server.baseUrl });

        const rawResponseBody = {
            errors: [
                { category: "API_ERROR", code: "INTERNAL_SERVER_ERROR", detail: "detail", field: "field" },
                { category: "API_ERROR", code: "INTERNAL_SERVER_ERROR", detail: "detail", field: "field" },
            ],
        };
        server.mockEndpoint().put("/id").respondWith().statusCode(200).jsonBody(rawResponseBody).build();

        const response = await client.endpoints.put.add({
            id: "id",
        });
        expect(response).toEqual({
            errors: [
                {
                    category: "API_ERROR",
                    code: "INTERNAL_SERVER_ERROR",
                    detail: "detail",
                    field: "field",
                },
                {
                    category: "API_ERROR",
                    code: "INTERNAL_SERVER_ERROR",
                    detail: "detail",
                    field: "field",
                },
            ],
        });
    });
});
