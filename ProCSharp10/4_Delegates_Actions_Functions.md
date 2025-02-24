# Delegates

A delegate type is a type that represents references to methods with a particular parameter list and return type. When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type. You can invoke (or call) the method through the delegate instance.

It is perfectly acceptable to pass a delegate as a parameter, and the delegate can be invoked on any thread. If the delegate is invoked on a different thread, the call is marshaled to the proper thread.

It is particularly useful to pass a delegate to a method that will call the delegate at a later time. This is a common pattern in .NET programming for raising events.

## Delegate Declaration

A delegate declaration defines a reference type that can be used to encapsulate a method with a specific signature. The following example shows a delegate declaration:
```csharp
delegate int PerformCalculation(int x, int y);
```

The delegate declaration specifies a method signature that can be encapsulated by the delegate. The method can have any return type and any number of parameters of any type. The following example shows a method that matches the delegate signature:
```csharp
int Add(int x, int y)
{
	return x + y;
}
```

The following example shows how to create an instance of the delegate and associate it with the Add method:
```csharp
PerformCalculation calculation = Add;
```

The delegate instance can then be invoked in the same way that you invoke the encapsulated method:
```csharp
int result = calculation(10, 20);
```

***Lack of notes pls refer to the code***

```csharp
public void RegisterWithCarEngine(CarEngineHandler methodToCall)
{
    _listOfHandlers += methodToCall;
}

public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
{
    _listOfHandlers -= methodToCall;
}
```

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