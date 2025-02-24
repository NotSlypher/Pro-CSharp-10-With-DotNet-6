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

//target for func<> delegate
static int Add(int x, int y)
{
    return x + y;
}

static string SumToString(int x, int y)
{
    return (x + y).ToString();
}

Func<int, int, int> addFunc = Add;
int result = addFunc(40, 60);
Console.WriteLine($"Addition: {result}");

Func<int, int, string> sumToStringFunc = SumToString;
string sum = sumToStringFunc(40, 60);
Console.WriteLine($"Sum to string: {sum}");
