/**
 * This file was auto-generated by Fern from our API Definition.
 */
import * as errors from "../../../../../../errors/index.mjs";
import * as SeedExhaustive from "../../../../../index.mjs";
import * as core from "../../../../../../core/index.mjs";
export declare class ObjectWithOptionalFieldError extends errors.SeedExhaustiveError {
    constructor(body: SeedExhaustive.types.ObjectWithOptionalField, rawResponse?: core.RawResponse);
}
