# Async main

> As `async main` enables you to use `await` in `Main` method.
In C# previous version doesn't support `async ` in `Main` method. So need to call `GetAwaiter()` and `GetResult()` method explicitly.

```csharp
static int Main(string[] args)
    => Display().GetAwaiter().GetResult();

static async Task<int> Display()
{
    Console.WriteLine("Hello World");
    return await Task.FromResult(1);
}
````

In C# 7.1
```csharp
static async Task<int> Main(string[] args) => await Display();        

static async Task<int> Display()
{
    Console.WriteLine("Hello World");            
    return await Task.FromResult(1);
}        
```