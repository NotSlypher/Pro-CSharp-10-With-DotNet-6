## Actions and Function Delegates

### Actions

Actions are delegates that can be used to pass a method as a parameter without explicitly declaring a delegate. They are defined in the `System` namespace and can take up to 16 parameters. They can be used to pass a method as a parameter to another method. 
```csharp
static void DisplayMessage(string message, ConsoleColor txtColor, int printCount)
{
    ConsoleColor previousColor = Console.ForegroundColor;
    Console.ForegroundColor = txtColor;
    for (int i = 0; i < printCount; i++)
    {
        Console.WriteLine(message);
    }
    Console.ForegroundColor = previousColor;
}

Action<string, ConsoleColor, int> actionTarget = DisplayMessage;
actionTarget(actionTarget.Method.Name, ConsoleColor.DarkGreen, 3);
```

Action delegate types can only point to methods thata take a void return type. If you need to pass a method that returns a value, you can use the `Func` delegate.

### Func

Func is a generic delegate that can take up to 16 parameters and returns a value. The last parameter is the return type. 
```csharp
static int Add(int x, int y)
{
    return x + y;
}

static string sumToString(int x, int y)
{
    return (x + y).ToString();
}

Func<int, int, int> addFunc = Add;
Console.WriteLine(addFunc(3, 5));

Func<int, int, string> sumToStringFunc = sumToString;
string result = sumToStringFunc(3, 5);
Console.WriteLine(result);
```