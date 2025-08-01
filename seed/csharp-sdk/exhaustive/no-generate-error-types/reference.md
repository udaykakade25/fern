# Reference
## Endpoints Container
<details><summary><code>client.Endpoints.Container.<a href="/src/SeedExhaustive/Endpoints/Container/ContainerClient.cs">GetAndReturnListOfPrimitivesAsync</a>(IEnumerable<string> { ... }) -> IEnumerable<string></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Container.GetAndReturnListOfPrimitivesAsync(
    new List<string>() { "string", "string" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IEnumerable<string>` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Container.<a href="/src/SeedExhaustive/Endpoints/Container/ContainerClient.cs">GetAndReturnListOfObjectsAsync</a>(IEnumerable<Types.ObjectWithRequiredField> { ... }) -> IEnumerable<Types.ObjectWithRequiredField></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Container.GetAndReturnListOfObjectsAsync(
    new List<ObjectWithRequiredField>()
    {
        new ObjectWithRequiredField { String = "string" },
        new ObjectWithRequiredField { String = "string" },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IEnumerable<Types.ObjectWithRequiredField>` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Container.<a href="/src/SeedExhaustive/Endpoints/Container/ContainerClient.cs">GetAndReturnSetOfPrimitivesAsync</a>(HashSet<string> { ... }) -> HashSet<string></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Container.GetAndReturnSetOfPrimitivesAsync(
    new HashSet<string>() { "string" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `HashSet<string>` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Container.<a href="/src/SeedExhaustive/Endpoints/Container/ContainerClient.cs">GetAndReturnSetOfObjectsAsync</a>(HashSet<Types.ObjectWithRequiredField> { ... }) -> HashSet<Types.ObjectWithRequiredField></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Container.GetAndReturnSetOfObjectsAsync(
    new HashSet<ObjectWithRequiredField>() { new ObjectWithRequiredField { String = "string" } }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `HashSet<Types.ObjectWithRequiredField>` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Container.<a href="/src/SeedExhaustive/Endpoints/Container/ContainerClient.cs">GetAndReturnMapPrimToPrimAsync</a>(Dictionary<string, string> { ... }) -> Dictionary<string, string></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Container.GetAndReturnMapPrimToPrimAsync(
    new Dictionary<string, string>() { { "string", "string" } }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Dictionary<string, string>` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Container.<a href="/src/SeedExhaustive/Endpoints/Container/ContainerClient.cs">GetAndReturnMapOfPrimToObjectAsync</a>(Dictionary<string, Types.ObjectWithRequiredField> { ... }) -> Dictionary<string, Types.ObjectWithRequiredField></code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Container.GetAndReturnMapOfPrimToObjectAsync(
    new Dictionary<string, ObjectWithRequiredField>()
    {
        {
            "string",
            new ObjectWithRequiredField { String = "string" }
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Dictionary<string, Types.ObjectWithRequiredField>` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Container.<a href="/src/SeedExhaustive/Endpoints/Container/ContainerClient.cs">GetAndReturnOptionalAsync</a>(Types.ObjectWithRequiredField? { ... }) -> Types.ObjectWithRequiredField?</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Container.GetAndReturnOptionalAsync(
    new ObjectWithRequiredField { String = "string" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Types.ObjectWithRequiredField?` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Endpoints ContentType
<details><summary><code>client.Endpoints.ContentType.<a href="/src/SeedExhaustive/Endpoints/ContentType/ContentTypeClient.cs">PostJsonPatchContentTypeAsync</a>(Types.ObjectWithOptionalField { ... })</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.ContentType.PostJsonPatchContentTypeAsync(
    new ObjectWithOptionalField
    {
        String = "string",
        Integer = 1,
        Long = 1000000,
        Double = 1.1,
        Bool = true,
        Datetime = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        Date = new DateOnly(2023, 1, 15),
        Uuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Base64 = "SGVsbG8gd29ybGQh",
        List = new List<string>() { "list", "list" },
        Set = new HashSet<string>() { "set" },
        Map = new Dictionary<int, string>() { { 1, "map" } },
        Bigint = "1000000",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Types.ObjectWithOptionalField` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.ContentType.<a href="/src/SeedExhaustive/Endpoints/ContentType/ContentTypeClient.cs">PostJsonPatchContentWithCharsetTypeAsync</a>(Types.ObjectWithOptionalField { ... })</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.ContentType.PostJsonPatchContentWithCharsetTypeAsync(
    new ObjectWithOptionalField
    {
        String = "string",
        Integer = 1,
        Long = 1000000,
        Double = 1.1,
        Bool = true,
        Datetime = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        Date = new DateOnly(2023, 1, 15),
        Uuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Base64 = "SGVsbG8gd29ybGQh",
        List = new List<string>() { "list", "list" },
        Set = new HashSet<string>() { "set" },
        Map = new Dictionary<int, string>() { { 1, "map" } },
        Bigint = "1000000",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Types.ObjectWithOptionalField` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Endpoints Enum
<details><summary><code>client.Endpoints.Enum.<a href="/src/SeedExhaustive/Endpoints/Enum/EnumClient.cs">GetAndReturnEnumAsync</a>(Types.WeatherReport { ... }) -> Types.WeatherReport</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Enum.GetAndReturnEnumAsync(WeatherReport.Sunny);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Types.WeatherReport` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Endpoints HttpMethods
<details><summary><code>client.Endpoints.HttpMethods.<a href="/src/SeedExhaustive/Endpoints/HttpMethods/HttpMethodsClient.cs">TestGetAsync</a>(id) -> string</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.HttpMethods.TestGetAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.HttpMethods.<a href="/src/SeedExhaustive/Endpoints/HttpMethods/HttpMethodsClient.cs">TestPostAsync</a>(Types.ObjectWithRequiredField { ... }) -> Types.ObjectWithOptionalField</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.HttpMethods.TestPostAsync(new ObjectWithRequiredField { String = "string" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Types.ObjectWithRequiredField` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.HttpMethods.<a href="/src/SeedExhaustive/Endpoints/HttpMethods/HttpMethodsClient.cs">TestPutAsync</a>(id, Types.ObjectWithRequiredField { ... }) -> Types.ObjectWithOptionalField</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.HttpMethods.TestPutAsync(
    "id",
    new ObjectWithRequiredField { String = "string" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Types.ObjectWithRequiredField` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.HttpMethods.<a href="/src/SeedExhaustive/Endpoints/HttpMethods/HttpMethodsClient.cs">TestPatchAsync</a>(id, Types.ObjectWithOptionalField { ... }) -> Types.ObjectWithOptionalField</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.HttpMethods.TestPatchAsync(
    "id",
    new ObjectWithOptionalField
    {
        String = "string",
        Integer = 1,
        Long = 1000000,
        Double = 1.1,
        Bool = true,
        Datetime = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        Date = new DateOnly(2023, 1, 15),
        Uuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Base64 = "SGVsbG8gd29ybGQh",
        List = new List<string>() { "list", "list" },
        Set = new HashSet<string>() { "set" },
        Map = new Dictionary<int, string>() { { 1, "map" } },
        Bigint = "1000000",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Types.ObjectWithOptionalField` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.HttpMethods.<a href="/src/SeedExhaustive/Endpoints/HttpMethods/HttpMethodsClient.cs">TestDeleteAsync</a>(id) -> bool</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.HttpMethods.TestDeleteAsync("id");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**id:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Endpoints Object
<details><summary><code>client.Endpoints.Object.<a href="/src/SeedExhaustive/Endpoints/Object/ObjectClient.cs">GetAndReturnWithOptionalFieldAsync</a>(Types.ObjectWithOptionalField { ... }) -> Types.ObjectWithOptionalField</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Object.GetAndReturnWithOptionalFieldAsync(
    new ObjectWithOptionalField
    {
        String = "string",
        Integer = 1,
        Long = 1000000,
        Double = 1.1,
        Bool = true,
        Datetime = new DateTime(2024, 01, 15, 09, 30, 00, 000),
        Date = new DateOnly(2023, 1, 15),
        Uuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
        Base64 = "SGVsbG8gd29ybGQh",
        List = new List<string>() { "list", "list" },
        Set = new HashSet<string>() { "set" },
        Map = new Dictionary<int, string>() { { 1, "map" } },
        Bigint = "1000000",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Types.ObjectWithOptionalField` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Object.<a href="/src/SeedExhaustive/Endpoints/Object/ObjectClient.cs">GetAndReturnWithRequiredFieldAsync</a>(Types.ObjectWithRequiredField { ... }) -> Types.ObjectWithRequiredField</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Object.GetAndReturnWithRequiredFieldAsync(
    new ObjectWithRequiredField { String = "string" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Types.ObjectWithRequiredField` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Object.<a href="/src/SeedExhaustive/Endpoints/Object/ObjectClient.cs">GetAndReturnWithMapOfMapAsync</a>(Types.ObjectWithMapOfMap { ... }) -> Types.ObjectWithMapOfMap</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Object.GetAndReturnWithMapOfMapAsync(
    new ObjectWithMapOfMap
    {
        Map = new Dictionary<string, Dictionary<string, string>>()
        {
            {
                "map",
                new Dictionary<string, string>() { { "map", "map" } }
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Types.ObjectWithMapOfMap` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Object.<a href="/src/SeedExhaustive/Endpoints/Object/ObjectClient.cs">GetAndReturnNestedWithOptionalFieldAsync</a>(Types.NestedObjectWithOptionalField { ... }) -> Types.NestedObjectWithOptionalField</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Object.GetAndReturnNestedWithOptionalFieldAsync(
    new NestedObjectWithOptionalField
    {
        String = "string",
        NestedObject = new ObjectWithOptionalField
        {
            String = "string",
            Integer = 1,
            Long = 1000000,
            Double = 1.1,
            Bool = true,
            Datetime = new DateTime(2024, 01, 15, 09, 30, 00, 000),
            Date = new DateOnly(2023, 1, 15),
            Uuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            Base64 = "SGVsbG8gd29ybGQh",
            List = new List<string>() { "list", "list" },
            Set = new HashSet<string>() { "set" },
            Map = new Dictionary<int, string>() { { 1, "map" } },
            Bigint = "1000000",
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Types.NestedObjectWithOptionalField` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Object.<a href="/src/SeedExhaustive/Endpoints/Object/ObjectClient.cs">GetAndReturnNestedWithRequiredFieldAsync</a>(string_, Types.NestedObjectWithRequiredField { ... }) -> Types.NestedObjectWithRequiredField</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Object.GetAndReturnNestedWithRequiredFieldAsync(
    "string",
    new NestedObjectWithRequiredField
    {
        String = "string",
        NestedObject = new ObjectWithOptionalField
        {
            String = "string",
            Integer = 1,
            Long = 1000000,
            Double = 1.1,
            Bool = true,
            Datetime = new DateTime(2024, 01, 15, 09, 30, 00, 000),
            Date = new DateOnly(2023, 1, 15),
            Uuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            Base64 = "SGVsbG8gd29ybGQh",
            List = new List<string>() { "list", "list" },
            Set = new HashSet<string>() { "set" },
            Map = new Dictionary<int, string>() { { 1, "map" } },
            Bigint = "1000000",
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**string_:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Types.NestedObjectWithRequiredField` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Object.<a href="/src/SeedExhaustive/Endpoints/Object/ObjectClient.cs">GetAndReturnNestedWithRequiredFieldAsListAsync</a>(IEnumerable<Types.NestedObjectWithRequiredField> { ... }) -> Types.NestedObjectWithRequiredField</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Object.GetAndReturnNestedWithRequiredFieldAsListAsync(
    new List<NestedObjectWithRequiredField>()
    {
        new NestedObjectWithRequiredField
        {
            String = "string",
            NestedObject = new ObjectWithOptionalField
            {
                String = "string",
                Integer = 1,
                Long = 1000000,
                Double = 1.1,
                Bool = true,
                Datetime = new DateTime(2024, 01, 15, 09, 30, 00, 000),
                Date = new DateOnly(2023, 1, 15),
                Uuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                Base64 = "SGVsbG8gd29ybGQh",
                List = new List<string>() { "list", "list" },
                Set = new HashSet<string>() { "set" },
                Map = new Dictionary<int, string>() { { 1, "map" } },
                Bigint = "1000000",
            },
        },
        new NestedObjectWithRequiredField
        {
            String = "string",
            NestedObject = new ObjectWithOptionalField
            {
                String = "string",
                Integer = 1,
                Long = 1000000,
                Double = 1.1,
                Bool = true,
                Datetime = new DateTime(2024, 01, 15, 09, 30, 00, 000),
                Date = new DateOnly(2023, 1, 15),
                Uuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
                Base64 = "SGVsbG8gd29ybGQh",
                List = new List<string>() { "list", "list" },
                Set = new HashSet<string>() { "set" },
                Map = new Dictionary<int, string>() { { 1, "map" } },
                Bigint = "1000000",
            },
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `IEnumerable<Types.NestedObjectWithRequiredField>` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Endpoints Params
<details><summary><code>client.Endpoints.Params.<a href="/src/SeedExhaustive/Endpoints/Params/ParamsClient.cs">GetWithPathAsync</a>(param) -> string</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

GET with path param
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Params.GetWithPathAsync("param");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**param:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Params.<a href="/src/SeedExhaustive/Endpoints/Params/ParamsClient.cs">GetWithInlinePathAsync</a>(Endpoints.GetWithInlinePath { ... }) -> string</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

GET with path param
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Params.GetWithInlinePathAsync(new GetWithInlinePath { Param = "param" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Endpoints.GetWithInlinePath` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Params.<a href="/src/SeedExhaustive/Endpoints/Params/ParamsClient.cs">GetWithQueryAsync</a>(Endpoints.GetWithQuery { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

GET with query param
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Params.GetWithQueryAsync(new GetWithQuery { Query = "query", Number = 1 });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Endpoints.GetWithQuery` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Params.<a href="/src/SeedExhaustive/Endpoints/Params/ParamsClient.cs">GetWithAllowMultipleQueryAsync</a>(Endpoints.GetWithMultipleQuery { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

GET with multiple of same query param
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Params.GetWithAllowMultipleQueryAsync(
    new GetWithMultipleQuery { Query = ["query"], Number = [1] }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Endpoints.GetWithMultipleQuery` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Params.<a href="/src/SeedExhaustive/Endpoints/Params/ParamsClient.cs">GetWithPathAndQueryAsync</a>(param, Endpoints.GetWithPathAndQuery { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

GET with path and query params
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Params.GetWithPathAndQueryAsync(
    "param",
    new GetWithPathAndQuery { Query = "query" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**param:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `Endpoints.GetWithPathAndQuery` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Params.<a href="/src/SeedExhaustive/Endpoints/Params/ParamsClient.cs">GetWithInlinePathAndQueryAsync</a>(Endpoints.GetWithInlinePathAndQuery { ... })</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

GET with path and query params
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Params.GetWithInlinePathAndQueryAsync(
    new GetWithInlinePathAndQuery { Param = "param", Query = "query" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Endpoints.GetWithInlinePathAndQuery` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Params.<a href="/src/SeedExhaustive/Endpoints/Params/ParamsClient.cs">ModifyWithPathAsync</a>(param, string { ... }) -> string</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

PUT to update with path param
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Params.ModifyWithPathAsync("param", "string");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**param:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Params.<a href="/src/SeedExhaustive/Endpoints/Params/ParamsClient.cs">ModifyWithInlinePathAsync</a>(Endpoints.ModifyResourceAtInlinedPath { ... }) -> string</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

PUT to update with path param
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Params.ModifyWithInlinePathAsync(
    new ModifyResourceAtInlinedPath { Param = "param", Body = "string" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Endpoints.ModifyResourceAtInlinedPath` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Endpoints Primitive
<details><summary><code>client.Endpoints.Primitive.<a href="/src/SeedExhaustive/Endpoints/Primitive/PrimitiveClient.cs">GetAndReturnStringAsync</a>(string { ... }) -> string</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Primitive.GetAndReturnStringAsync("string");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Primitive.<a href="/src/SeedExhaustive/Endpoints/Primitive/PrimitiveClient.cs">GetAndReturnIntAsync</a>(int { ... }) -> int</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Primitive.GetAndReturnIntAsync(1);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `int` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Primitive.<a href="/src/SeedExhaustive/Endpoints/Primitive/PrimitiveClient.cs">GetAndReturnLongAsync</a>(long { ... }) -> long</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Primitive.GetAndReturnLongAsync(1000000);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `long` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Primitive.<a href="/src/SeedExhaustive/Endpoints/Primitive/PrimitiveClient.cs">GetAndReturnDoubleAsync</a>(double { ... }) -> double</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Primitive.GetAndReturnDoubleAsync(1.1);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `double` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Primitive.<a href="/src/SeedExhaustive/Endpoints/Primitive/PrimitiveClient.cs">GetAndReturnBoolAsync</a>(bool { ... }) -> bool</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Primitive.GetAndReturnBoolAsync(true);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `bool` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Primitive.<a href="/src/SeedExhaustive/Endpoints/Primitive/PrimitiveClient.cs">GetAndReturnDatetimeAsync</a>(DateTime { ... }) -> DateTime</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Primitive.GetAndReturnDatetimeAsync(
    new DateTime(2024, 01, 15, 09, 30, 00, 000)
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DateTime` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Primitive.<a href="/src/SeedExhaustive/Endpoints/Primitive/PrimitiveClient.cs">GetAndReturnDateAsync</a>(DateOnly { ... }) -> DateOnly</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Primitive.GetAndReturnDateAsync(new DateOnly(2023, 1, 15));
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `DateOnly` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Primitive.<a href="/src/SeedExhaustive/Endpoints/Primitive/PrimitiveClient.cs">GetAndReturnUuidAsync</a>(string { ... }) -> string</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Primitive.GetAndReturnUuidAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.Endpoints.Primitive.<a href="/src/SeedExhaustive/Endpoints/Primitive/PrimitiveClient.cs">GetAndReturnBase64Async</a>(string { ... }) -> string</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Primitive.GetAndReturnBase64Async("SGVsbG8gd29ybGQh");
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `string` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Endpoints Put
<details><summary><code>client.Endpoints.Put.<a href="/src/SeedExhaustive/Endpoints/Put/PutClient.cs">AddAsync</a>(Endpoints.PutRequest { ... }) -> Endpoints.PutResponse</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Put.AddAsync(new PutRequest { Id = "id" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Endpoints.PutRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## Endpoints Union
<details><summary><code>client.Endpoints.Union.<a href="/src/SeedExhaustive/Endpoints/Union/UnionClient.cs">GetAndReturnUnionAsync</a>(Types.Animal { ... }) -> Types.Animal</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.Endpoints.Union.GetAndReturnUnionAsync(
    new Animal(new Animal.Dog(new Dog { Name = "name", LikesToWoof = true }))
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `Types.Animal` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## InlinedRequests
<details><summary><code>client.InlinedRequests.<a href="/src/SeedExhaustive/InlinedRequests/InlinedRequestsClient.cs">PostWithObjectBodyandResponseAsync</a>(PostWithObjectBody { ... }) -> Types.ObjectWithOptionalField</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

POST with custom object in request body, response is an object
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.InlinedRequests.PostWithObjectBodyandResponseAsync(
    new PostWithObjectBody
    {
        String = "string",
        Integer = 1,
        NestedObject = new ObjectWithOptionalField
        {
            String = "string",
            Integer = 1,
            Long = 1000000,
            Double = 1.1,
            Bool = true,
            Datetime = new DateTime(2024, 01, 15, 09, 30, 00, 000),
            Date = new DateOnly(2023, 1, 15),
            Uuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
            Base64 = "SGVsbG8gd29ybGQh",
            List = new List<string>() { "list", "list" },
            Set = new HashSet<string>() { "set" },
            Map = new Dictionary<int, string>() { { 1, "map" } },
            Bigint = "1000000",
        },
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `PostWithObjectBody` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## NoAuth
<details><summary><code>client.NoAuth.<a href="/src/SeedExhaustive/NoAuth/NoAuthClient.cs">PostWithNoAuthAsync</a>(object { ... }) -> bool</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

POST request with no auth
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NoAuth.PostWithNoAuthAsync(new Dictionary<object, object?>() { { "key", "value" } });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `object` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## NoReqBody
<details><summary><code>client.NoReqBody.<a href="/src/SeedExhaustive/NoReqBody/NoReqBodyClient.cs">GetWithNoRequestBodyAsync</a>() -> Types.ObjectWithOptionalField</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NoReqBody.GetWithNoRequestBodyAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.NoReqBody.<a href="/src/SeedExhaustive/NoReqBody/NoReqBodyClient.cs">PostWithNoRequestBodyAsync</a>() -> string</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.NoReqBody.PostWithNoRequestBodyAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

## ReqWithHeaders
<details><summary><code>client.ReqWithHeaders.<a href="/src/SeedExhaustive/ReqWithHeaders/ReqWithHeadersClient.cs">GetWithCustomHeaderAsync</a>(ReqWithHeaders { ... })</code></summary>
<dl>
<dd>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ReqWithHeaders.GetWithCustomHeaderAsync(
    new ReqWithHeaders
    {
        XTestEndpointHeader = "X-TEST-ENDPOINT-HEADER",
        XTestServiceHeader = "X-TEST-SERVICE-HEADER",
        Body = "string",
    }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ReqWithHeaders` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>
