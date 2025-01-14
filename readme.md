# C# code generator for AutoRest V3

<!-- TOC depthfrom:2 -->

- [Prerequisites](#prerequisites)
- [Build](#build)
- [Test](#test)
- [Use in azure-sdk-net repo](#use-in-azure-sdk-net-repo)
- [Use outside of the azure-sdk-net repo](#use-outside-of-the-azure-sdk-net-repo)
- [Customizing the generated code](#customizing-the-generated-code)
    - [Make a model internal](#make-a-model-internal)
    - [Rename a model class](#rename-a-model-class)
    - [Change a model namespace](#change-a-model-namespace)
    - [Make model property internal](#make-model-property-internal)
    - [Rename a model property](#rename-a-model-property)
    - [Change a model property type](#change-a-model-property-type)
    - [Preserve raw Json value of a property](#preserve-raw-json-value-of-a-property)
    - [Changing member doc comment](#changing-member-doc-comment)
    - [Customize serialization/deserialization methods](#customize-serializationdeserialization-methods)
    - [Renaming an enum](#renaming-an-enum)
    - [Renaming an enum member](#renaming-an-enum-member)
    - [Changing an enum to an extensible enum](#changing-an-enum-to-an-extensible-enum)
    - [Make a client internal](#make-a-client-internal)
    - [Rename a client](#rename-a-client)
    - [Replace any generated member](#replace-any-generated-member)
    - [Remove any generated member](#remove-any-generated-member)
    - [Change model namespace or accessability in bulk](#change-model-namespace-or-accessability-in-bulk)
    - [Exclude models from namespace](#exclude-models-from-namespace)

<!-- /TOC -->

## Prerequisites

- [NodeJS (14.x.x)](https://nodejs.org/en/) 
- [.NET Core SDK (3.1.301)](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- [PowerShell Core 7](https://github.com/PowerShell/PowerShell/releases/latest)
- [Java](https://www.java.com/en/download/) (for V2 testserver)
- `npm install` (at root)

## Build

- `dotnet build` (at root)

## Test

**`./eng/Generate.ps1` (at root in PowerShell Core)**

This command tests your change across many swagger definitions and samples.

These arguments change the behavior:
- `-fast` option skips Swagger -> YAML IL step. Much faster when only making codegen changes
- `-fast SWAGGER_NAME` (where SWAGGER_NAME is replaced with the name of the swagger) to run only one case

**`dotnet test` (at root)**

### Testing Details

[autorest.testserver](http://github.com/Azure/autorest.testserver/) provides a platform for automated testing of the code generators. 

It packages a bunch of test swagger files, along with a “mock” nodejs server. 

The swagger files are compiled, and then run, which pings the mock server (to verify behavior). This tests both the Modeler 4 and language specific codegen. 

This document contains some additional [technical details](https://github.com/Azure/autorest.csharp/blob/feature/v3/test/README.md).

### Testing generator changes against Azure SDK without a PR

These instructions are only a general outline, see [the script](https://github.com/Azure/autorest.csharp/blob/feature/v3/eng/UpdateAzureSdkForNet.ps1) for details:

- Use `dotnet pack` to package up a version of the generator
- `dotnet pack -o directory` (where directory is replaced with the name of the directory)
- Copy created nuget package to your local nuget source
- Update package.props
- `dotnet restore -S directory` (where directory is replaced with the name of the directory)

## Use in `azure-sdk-net` repo

Run `dotnet build /t:GenerateCode` in the directory that contains your `.csproj` file.

This executes [these targets](https://github.com/Azure/autorest.csharp/blob/feature/v3/src/AutoRest.CSharp/build/CodeGeneration.targets).

Refer also to [azure-sdk-for-net/CONTRIBUTING.md](https://github.com/Azure/azure-sdk-for-net/blob/master/CONTRIBUTING.md#on-boarding-new-generated-code-library) for more details.

### PR Integration with Azure SDK Repository

Merging a change in autorest.csharp will open a PR against azure-sdk-for-net with every project’s generated code staged for review.

Along with this, it also bumps the generator to the new version. 

This bump is done [here](https://github.com/Azure/azure-sdk-for-net/blob/master/eng/Packages.Data.props).

The generator is shipped as a NuGet package. 

This way, every binding stays in lockstep with the current generator


## Use outside of the `azure-sdk-net` repo

1. Add the `http://azuresdkartifacts.blob.core.windows.net/azure-sdk-tools/index.json` feed to your NuGet.config:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="Azure SDK Tools" value="https://azuresdkartifacts.blob.core.windows.net/azure-sdk-tools/index.json" protocolVersion="3" />
  </packageSources>
</configuration>
```

2. Add a package reference to `AutoRest.CSharp` version `1.0.0-alpha.20201013.3` or later:

```xml
<PackageReference Include="AutoRest.CSharp" Version="1.0.0-alpha.20201013.3" />
```

3. Add an `autorest.md` configuration file pointing to you swagger file:

~~~ markdown
``` yaml
input-file:
- $(this-folder)/swagger.json
# - http://example.com/swagger.json
```
~~~

Or reference an existing configuration file:
~~~ markdown
``` yaml
require: http://example.com/readme.md
```
~~~

4. Run `dotnet build /t:GenerateCode` in the directory that contains your `.csproj` file.

## Customizing the generated code

### Make a model internal

Define a class with the same namespace and name as generated model and use the desired accessibility.

<details>

**Generated code before (Generated/Models/Model.cs):**

``` C#
namespace Azure.Service.Models
{
    public partial class Model { }
}
```

**Add customized model (Model.cs)**

``` C#
namespace Azure.Service.Models
{
    internal partial class Model { }
}
```

**Generated code after (Generated/Models/Model.cs):**

``` diff
namespace Azure.Service.Models
{
-    public partial class Model { }
+    internal partial class Model { }
}
```

</details>

### Rename a model class

Define a class with a desired name and mark it with `[CodeGenModel("OriginalName")]`

<details>

**Generated code before (Generated/Models/Model.cs):**

``` C#
namespace Azure.Service.Models
{
    public partial class Model { }
}
```

**Add customized model (NewModelClassName.cs)**

``` C#
namespace Azure.Service.Models
{
    [CodeGenModel("Model")]
    public partial class NewModelClassName { }
}
```

**Generated code after (Generated/Models/NewModelClassName.cs):**

``` diff
namespace Azure.Service.Models
{
-    public partial class Model { }
+    public partial class NewModelClassName { }
}
```

</details>

### Change a model namespace

Define a class with a desired namespace and mark it with `[CodeGenModel("OriginalName")]`

<details>

**Generated code before (Generated/Models/Model.cs):**

``` C#
namespace Azure.Service.Models
{
    public partial class Model { }
}
```

**Add customized model (NewModelClassName.cs)**

``` C#
namespace Azure.Service
{
    [CodeGenModel("Model")]
    public partial class Model { }
}
```

**Generated code after (Generated/Models/NewModelClassName.cs):**

``` diff
- namespace Azure.Service.Models
+ namespace Azure.Service
{
    public partial class Model { }
}
```

</details>

### Make model property internal

Define a class with a property matching a generated property name but with desired accessibility.

<details>

**Generated code before (Generated/Models/Model.cs):**

``` C#
namespace Azure.Service.Models
{
    public partial class Model
    {
        public string Property { get; }
    }
}
```

**Add customized model (Model.cs)**

``` C#
namespace Azure.Service.Models
{
    public partial class Model
    {
        internal string Property { get; } 
    }
}
```

**Generated code after (Generated/Models/Model.cs):**

``` diff
namespace Azure.Service.Models
{
    public partial class Model
    {
-        public string Property { get; }
    }
}
```

</details>

### Rename a model property

Define a partial class with a new property name and mark it with `[CodeGenMember("OriginalName")]` attribute.

**NOTE:** you can also change a property to a field using this mapping.

<details>

**Generated code before (Generated/Models/Model.cs):**

``` C#
namespace Azure.Service.Models
{
    public partial class Model
    {
        public string Property { get; }
    }
}
```

**Add customized model (Model.cs)**

``` C#
namespace Azure.Service.Models
{
    public partial class Model
    {
        [CodeGenMember("Property")]
        public string RenamedProperty { get; } 
    }
}
```

**Generated code after (Generated/Models/Model.cs):**

``` diff
namespace Azure.Service.Models
{
    public partial class Model
    {
-        public string Property { get; }
+        // All original Property usages would reference a RenamedProperty
    }
}
```

</details>

### Change a model property type

:warning:

**NOTE: This is supported for a narrow set of cases where the underlying serialized type doesn't change**

Scenarios that would work:

1. String <-> TimeSpan (both represented as string in JSON)
2. Float <-> Int (both are numbers)
3. String <-> Enums (both strings) 
4. String -> Uri

Won't work:

1. String <-> Bool (different json type)
2. Changing model kinds

If you think you have a valid re-mapping scenario that's not supported file an issue.

:warning:

Define a property with different type than the generated one.

<details>

**Generated code before (Generated/Models/Model.cs):**

``` C#
namespace Azure.Service.Models
{
    public partial class Model
    {
        public string Property { get; }
    }
}
```

**Add customized model (Model.cs)**

``` C#
namespace Azure.Service.Models
{
    public partial class Model
    {
        public DateTime Property { get; }
    }
}
```

**Generated code after (Generated/Models/Model.Serializer.cs):**

``` diff
namespace Azure.Service.Models
{
    public partial class Model
    {
-        public string Property { get; }
+        // Serialization code now reads and writes DateTime value instead of string  
    }
}
```

</details>

### Preserve raw Json value of a property

Use the [Change a model property type](#Change-a-model-property-type) approach to change property type to `JsonElement`.

<details>

**Generated code before (Generated/Models/Model.cs):**

``` C#
namespace Azure.Service.Models
{
    public partial class Model
    {
        public string Property { get; }
    }
}
```

**Add customized model (Model.cs)**

``` C#
namespace Azure.Service.Models
{
    public partial class Model
    {
        public JsonElement Property { get; }
    }
}
```

**Generated code after (Generated/Models/Model.Serializer.cs):**

``` diff
namespace Azure.Service.Models
{
    public partial class Model
    {
-        public string Property { get; }
+        // Serialization code now reads and writes JsonElement value instead of string  
    }
}
```

</details>

### Changing member doc comment

Redefine a member in partial class with a new doc comment.

<details>

**Generated code before (Generated/Models/Model.cs):**

``` C#
namespace Azure.Service.Models
{
    public partial class Model
    {
        /// Subpar doc comment
        public string Property { get; }
    }
}
```

**Add customized model (Model.cs)**

``` C#
namespace Azure.Service.Models
{
    public partial class Model
    {
        /// Great doc comment
        public string Property { get; }
    }
}
```

**Generated code after (Generated/Models/Model.cs):**

``` diff
namespace Azure.Service.Models
{
    public partial class Model
    {
-        /// Subpar doc comment
-        public string Property { get; }  
    }
}
```

</details>

### Customize serialization/deserialization methods

Use the [Replace any generated member](#replace-any-generated-member) approach to replace Serialize/Deserialize method with a custom implementation.

<details>

**Generated code before (Generated/Models/Cat.Serialization.cs):**

``` C#
namespace Azure.Service.Models
{
  public partial class Cat
  {
      internal static Cat DeserializeCat(JsonElement element)
      {
          string color = default;
          string name = default;
          foreach (var property in element.EnumerateObject())
          {
              if (property.NameEquals("color"))
              {
                  if (property.Value.ValueKind == JsonValueKind.Null)
                  {
                      continue;
                  }
                  color = property.Value.GetString();
                  continue;
              }
              if (property.NameEquals("name"))
              {
                  if (property.Value.ValueKind == JsonValueKind.Null)
                  {
                      continue;
                  }
                  name = property.Value.GetString();
                  continue;
              }
          }
          return new Cat(id, name);
      }
  }
}
```

**Add customized model (Cat.cs)**

``` C#
namespace Azure.Service.Models
{
  public partial class Cat
  {
      internal static Cat DeserializeCat(JsonElement element)
      {
          string color = default;
          string name = default;
          foreach (var property in element.EnumerateObject())
          {
              if (property.NameEquals("name"))
              {
                  if (property.Value.ValueKind == JsonValueKind.Null)
                  {
                      continue;
                  }
                  name = property.Value.GetString();
                  continue;
              }
          }
          // WORKAROUND: server never sends color, default to black
          color = "black";
          return new Cat(name, color);
      }
  }
}
```

**Generated code after (Generated/Models/Model.cs):**

Generated code won't contain the DeserializeCat method and the custom one would be used for deserialization.

</details>

### Renaming an enum

Redefine an enum with a new name and all the members mark it with `[CodeGenModel("OriginEnumName")]`.

**NOTE: because enums can't be partial all values have to be copied**

<details>

**Generated code before (Generated/Models/Colors.cs):**

``` C#
namespace Azure.Service.Models
{
    public enum Colors
    {
        Red,
        Green,
        Blue
    }
}
```

**Add customized model (WallColors.cs)**

``` C#
namespace Azure.Service.Models
{
    [CodeGenModel("Colors")]
    public enum WallColors
    {
        Red,
        Green,
        Blue
    }
}
```

**Generated code after (Generated/Models/Model.cs):**

``` diff
-namespace Azure.Service.Models
-{
-    public enum Colors
-    {
-        Red,
-        Green,
-        Blue
-    }
-}
+// Serialization code uses the new WallColors type name
```

</details>

### Renaming an enum member

Redefine an enum with the same name and all the members, mark renamed member with `[CodeGenMember("OriginEnumMemberName")]`.

**NOTE: because enums can't be partial all values have to be copied but only the ones being renamed should be marked with an attributes**

<details>

**Generated code before (Generated/Models/Colors.cs):**

``` C#
namespace Azure.Service.Models
{
    public enum Colors
    {
        Red,
        Green,
        Blue
    }
}
```

**Add customized model (Colors.cs)**

``` C#
namespace Azure.Service.Models
{
    public enum Colors
    {
        Red,
        Green,
        [CodeGenMember("Blue")]
        SkyBlue
    }
}
```

**Generated code after (Generated/Models/Model.cs):**

``` diff
-namespace Azure.Service.Models
-{
-    public enum Colors
-    {
-        Red,
-        Green,
-        Blue
-    }
-}
+// Serialization code uses the new SkyBlue member name
```

</details>

### Changing an enum to an extensible enum

Redefine an enum into an extensible enum by creating an empty struct with the same name as original enum.

<details>

**Generated code before (Generated/Models/Colors.cs):**

``` C#
namespace Azure.Service.Models
{
    public enum Colors
    {
        Red,
        Green
    }
}
```

**Add customized model (Colors.cs)**

``` C#
namespace Azure.Service.Models
{
    public partial struct Colors
    {
    }
}
```

**Generated code after (Generated/Models/Model.cs):**

``` diff
namespace Azure.Service.Models
{
-    public enum Colors
-    {
-        Red,
-        Green
-    }
+    public readonly partial struct Colors : IEquatable<Colors>
+    {
+        private readonly string _value;

+        public Colors(string value)
+        {
+            _value = value ?? throw new ArgumentNullException(nameof(value));
+        }

+        private const string Red = "red";
+        private const string Green = "green";

+        public static Colors Red { get; } = new Colors(Red);
+        public static Colors Green { get; } = new Colors(Green);
+        public static bool operator ==(Colors left, Colors right) => left.Equals(right);
         ...
}
```

</details>

### Make a client internal

Define a class with the same namespace and name as generated client and use the desired accessibility.

<details>

**Generated code before (Generated/Operations/ServiceClient.cs):**

``` C#
namespace Azure.Service.Operations
{
    public partial class ServiceClient { }
}
```

**Add customized model (Model.cs)**

``` C#
namespace Azure.Service.Operations
{
    internal partial class ServiceClient { }
}
```

**Generated code after (Generated/Operations/ServiceClient.cs):**

``` diff
namespace Azure.Service.Operations
{
-    public partial class ServiceClient { }
+    internal partial class ServiceClient { }
}
```

</details>


### Rename a client

Define a partial client class with a new name and mark it with `[CodeGenClient("OriginalName")]`

<details>

**Generated code before (Generated/Operations/ServiceClient.cs):**

``` C#
namespace Azure.Service.Operations
{
    public partial class ServiceClient {}
}
```

**Add customized model (Model.cs)**

``` C#
namespace Azure.Service.Operations
{
    [CodeGenClient("ServiceClient")]
    public partial class TableClient { }
}
```

**Generated code after (Generated/Operations/ServiceClient.cs):**

``` diff
namespace Azure.Service.Operations
{
-    public partial class ServiceClient { }
+    public partial class TableClient { }
}
```

</details>


### Replace any generated member

Works for model and client properties, methods, constructors etc.

Define a partial class with member with the same name and for methods same parameters.

<details>

**Generated code before (Generated/Models/Model.cs):**

``` C#
namespace Azure.Service.Models
{
    public partial class Model
    {
        public Model()
        {  
            Property = "a";
        }

        public string Property { get; set; }
    }
}
```

**Add customized model (Model.cs)**

``` C#
namespace Azure.Service.Models
{
    public partial class Model
    {
        internal Model()
        {
            Property = "b";
        }
    }
}
```

**Generated code after (Generated/Models/Model.cs):**

``` diff
namespace Azure.Service.Models
{
    public partial class Model
    {
-        public Model()
-        {  
-            Property = "a";
-        }
    }
}
```

</details>

### Remove any generated member

Works for model and client properties, methods, constructors etc.

Define a partial class with `[CodeGenSuppress("NameOfMember", typeof(Parameter1Type), typeof(Parameter2Type))]` attribute.

<details>

**Generated code before (Generated/Models/Model.cs):**

``` C#
namespace Azure.Service.Models
{
    public partial class Model
    {
        public Model()
        {  
            Property = "a";
        }

        public Model(string property)
        {  
            Property = property;
        }

        public string Property { get; set; }
    }
}
```

**Add customized model (Model.cs)**

``` C#
namespace Azure.Service.Models
{
    [CodeGenSuppress("Model", typeof(string))]
    public partial class Model
    {
    }
}
```

**Generated code after (Generated/Models/Model.cs):**

``` diff
namespace Azure.Service.Models
{
    public partial class Model
    {
-        public Model(string property)
-        {  
-            Property = property;
-        }
    }
}
```

</details>

### Change model namespace or accessability in bulk

<details>

**Generated code before:**

``` C#
namespace Azure.Service.Models
{
    public partial class Model1 {}
    public partial class Model2 {}
    public partial class Model3 {}
    public partial class Model4 {}
}
```

**Add autorest.md transformation**

```
directive:
  from: swagger-document
  where: $.definitions.*
  transform: >
    $["x-namespace"] = "Azure.Search.Documents.Indexes.Models"
    $["x-accessibility"] = "internal"
```

**Generated code after:**

``` diff
-namespace Azure.Service.Models
+namespace Azure.Search.Documents.Indexes.Models
{
-    public partial class Model1 {}
+    internal partial class Model1 {}
-    public partial class Model2 {}
+    internal partial class Model2 {}
-    public partial class Model3 {}
+    internal partial class Model3 {}
-    public partial class Model4 {}
+    internal partial class Model4 {}
}
```

</details>

### Exclude models from namespace

<details>

**Generated code before (Generated/Models/Model.cs):**

``` C#
namespace Azure.Service.Models
{
    public partial class Model { }
}
```

**Add `model-namespace` in autorest.md**

```
model-namespace: false
input-file: "swagger-document"
```

**Generated code after (Generated/Models/Model.cs):**

``` diff
- namespace Azure.Service.Models
+ namespace Azure.Service
{
    public partial class Model { }
}
```
</details>

<details>
 <summary>Repository-specific pipeline configuration</summary>

```yaml
# autorest-core version
version: 3.0.6326
shared-source-folders:
  - $(this-folder)/src/assets/Generator.Shared
  - $(this-folder)/src/assets/Azure.Core.Shared
save-inputs: true
use: $(this-folder)/artifacts/bin/AutoRest.CSharp/Debug/netcoreapp3.0/
clear-output-folder: false
public-clients: true
pipeline:
  csharpproj:
    input: modelerfour/identity
  csharpproj/emitter:
    input: csharpproj
    scope: output-scope
```

</details>
