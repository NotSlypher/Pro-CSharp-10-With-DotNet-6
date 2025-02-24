Console.WriteLine("Generic Delegate");


static void IntTarget(int value)
{
    Console.WriteLine($"IntTarget: {value}");
}
static void IntTarget1(int value)
{
    Console.WriteLine($"IntTarget: {value}");
}

static void StringTarget(string value)
{
    Console.WriteLine($"StringTarget: {value}");
}

GenericDelegate<int> intDelegate = new GenericDelegate<int>(IntTarget);
intDelegate += IntTarget1;
intDelegate(9);

GenericDelegate<string> stringDelegate = StringTarget;
stringDelegate("Hello, World!");

public delegate void GenericDelegate<T>(T value);
