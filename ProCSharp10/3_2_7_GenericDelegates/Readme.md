## Generic Delegate

```csharp

static void IntTarget(int value)
{
    Console.WriteLine($"IntTarget: {value}");
}
static void IntTarget1(int value)
{
    Console.WriteLine($"IntTarget: {value}");
}

GenericDelegate<int> intDelegate = new GenericDelegate<int>(IntTarget);
intDelegate += IntTarget1;
intDelegate(9);

public delegate void GenericDelegate<T>(T arg);
```