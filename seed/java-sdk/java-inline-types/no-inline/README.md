# Seed Java Library

[![fern shield](https://img.shields.io/badge/%F0%9F%8C%BF-Built%20with%20Fern-brightgreen)](https://buildwithfern.com?utm_source=github&utm_medium=github&utm_campaign=readme&utm_source=Seed%2FJava)
[![Maven Central](https://img.shields.io/maven-central/v/com.fern/java-inline-types)](https://central.sonatype.com/artifact/com.fern/java-inline-types)

The Seed Java library provides convenient access to the Seed API from Java.

## Installation

### Gradle

Add the dependency in your `build.gradle` file:

```groovy
dependencies {
  implementation 'com.fern:java-inline-types'
}
```

### Maven

Add the dependency in your `pom.xml` file:

```xml
<dependency>
  <groupId>com.fern</groupId>
  <artifactId>java-inline-types</artifactId>
  <version>0.0.1</version>
</dependency>
```

## Usage

Instantiate and use the client with the following:

```java
package com.example.usage;

import com.seed.object.SeedObjectClient;
import com.seed.object.requests.PostRootRequest;
import com.seed.object.types.RequestTypeInlineType1;

public class Example {
    public static void main(String[] args) {
        SeedObjectClient client = SeedObjectClient
            .builder()
            .build();

        client.getRoot(
            PostRootRequest
                .builder()
                .bar(
                    RequestTypeInlineType1
                        .builder()
                        .foo("foo")
                        .build()
                )
                .foo("foo")
                .build()
        );
    }
}
```

## Base Url

You can set a custom base URL when constructing the client.

```java
import com.seed.object.SeedObjectClient;

SeedObjectClient client = SeedObjectClient
    .builder()
    .url("https://example.com")
    .build();
```

## Exception Handling

When the API returns a non-success status code (4xx or 5xx response), an API exception will be thrown.

```java
import com.seed.object.core.SeedObjectApiException;

try {
    client.getRoot(...);
} catch (SeedObjectApiException e) {
    // Do something with the API exception...
}
```

## Advanced

### Custom Client

This SDK is built to work with any instance of `OkHttpClient`. By default, if no client is provided, the SDK will construct one. 
However, you can pass your own client like so:

```java
import com.seed.object.SeedObjectClient;
import okhttp3.OkHttpClient;

OkHttpClient customClient = ...;

SeedObjectClient client = SeedObjectClient
    .builder()
    .httpClient(customClient)
    .build();
```

### Retries

The SDK is instrumented with automatic retries with exponential backoff. A request will be retried as long
as the request is deemed retryable and the number of retry attempts has not grown larger than the configured
retry limit (default: 2).

A request is deemed retryable when any of the following HTTP status codes is returned:

- [408](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) (Timeout)
- [429](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) (Too Many Requests)
- [5XX](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) (Internal Server Errors)

Use the `maxRetries` client option to configure this behavior.

```java
import com.seed.object.SeedObjectClient;

SeedObjectClient client = SeedObjectClient
    .builder()
    .maxRetries(1)
    .build();
```

### Timeouts

The SDK defaults to a 60 second timeout. You can configure this with a timeout option at the client or request level.

```java
import com.seed.object.SeedObjectClient;
import com.seed.object.core.RequestOptions;

// Client level
SeedObjectClient client = SeedObjectClient
    .builder()
    .timeout(10)
    .build();

// Request level
client.getRoot(
    ...,
    RequestOptions
        .builder()
        .timeout(10)
        .build()
);
```

## Contributing

While we value open-source contributions to this SDK, this library is generated programmatically.
Additions made directly to this library would have to be moved over to our generation code,
otherwise they would be overwritten upon the next generated release. Feel free to open a PR as
a proof of concept, but know that we will not be able to merge it as-is. We suggest opening
an issue first to discuss with us!

On the other hand, contributions to the README are always very welcome!