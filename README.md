# About ClintSharp

Provide an abstraction layer to C# to simplify some stuffs.

Install ClintSharp
---
Open Powershell or a terminal and enter this command:

```csharp
dotnet add package ClintSharp
```

String Functions:
---

```csharp
var name = "";
Console.WriteLine(name.IsNull()); // true
```

DateTime Functions:
---

```csharp
var date = DateTime.Now;
Console.WriteLine(date.ToTimestamp()); // 1558800650
```


Json Functions:
---
The Json methods use Newtonsoft.Json.

```csharp
var user = new List<User>() {};
...
Console.WriteLine(date.ToJson());
// Result: [{"username":"Clint","age":30},{"username":"John","age":19},{"username":"Jack","age":25}]
```

```csharp
var user = new List<User>() {};
...
Console.WriteLine(date.ToJsonF());
```

Result:

```json
[
  {
    "username": "Clint",
    "age": 30
  },
  {
    "username": "John",
    "age": 19
  },
  {
    "username": "Jack",
    "age": 25
  }
]
```
