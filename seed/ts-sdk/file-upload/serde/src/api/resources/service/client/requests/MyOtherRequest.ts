/**
 * This file was auto-generated by Fern from our API Definition.
 */

import * as core from "../../../../../core/index.js";
import * as SeedFileUpload from "../../../../index.js";

export interface MyOtherRequest {
    maybeString?: string;
    integer: number;
    file: core.FileLike;
    fileList: core.FileLike[];
    maybeFile?: core.FileLike | undefined;
    maybeFileList?: core.FileLike[] | undefined;
    maybeInteger?: number;
    optionalListOfStrings?: string[];
    listOfObjects: SeedFileUpload.MyObject[];
    optionalMetadata?: unknown;
    optionalObjectType?: SeedFileUpload.ObjectType;
    optionalId?: SeedFileUpload.Id;
    listOfObjectsWithOptionals: SeedFileUpload.MyObjectWithOptional[];
    aliasObject: SeedFileUpload.MyAliasObject;
    listOfAliasObject: SeedFileUpload.MyAliasObject[];
    aliasListOfObject: SeedFileUpload.MyCollectionAliasObject;
}
