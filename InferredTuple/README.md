# Inferred Tuple element names

> This feature is a small enhancement to the tuples feature introduced in C# 7.0. Many times when you initialize a tuple, the variables used for the right side of the assignment are the same as the names you'd like for the tuple elements.

```csharp
//Previous version
var detail = (name: name, version: version);
```

> The names of tuple elements can be inferred from the variables used to initialize the tuple.

```csharp
//Previous version
var detail = (name, version);
```
