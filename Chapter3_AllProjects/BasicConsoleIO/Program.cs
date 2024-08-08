
Console.WriteLine("***********Basic Console I/O**********");

///user input output
//GetUserData();

//numerical formatting
FormatNumericalData();

//variable defaulting
NewingDataTypes();

//verbatim stringa
VerbatimStrings();

string s1 = "Hello!";
string s2 = "HELLO!"; 
Console.WriteLine("s1 = {0}", s1); 
Console.WriteLine("s2 = {0}", s2); 
Console.WriteLine();
// Check the results of changing the default compare rules.
Console.WriteLine("Default rules: s1={0},s2={1}s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
Console.WriteLine("Ignore case, Invariant Culture: s1.Equals(s2, StringComparison. InvariantCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
Console.WriteLine();
Console.WriteLine("Default rules: s1={0},s2={1} s1.IndexOf(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase)); Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\", StringComparison. InvariantCultureIgnoreCase): {0}", s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
Console.WriteLine();

void FormatNumericalData()
{
    int num = 999999;
    Console.WriteLine($"number {num} in various formats");
    Console.WriteLine($"currency: {num:c}");
    Console.WriteLine($"digit pad of 9: {num:d9}");
    Console.WriteLine($"decimal of 3: {num:f3}");
    Console.WriteLine($"comma separated: {num:n}");
}

//variable defaulting (can also be done using "default" keyword or just new())
static void NewingDataTypes()
{
    Console.WriteLine("=> Using new to create variables:");
    bool b = new bool();              // Set to false.
    int i = new();                // Set to 0.
    double d = default;          // Set to 0.
    DateTime dt = new DateTime();     // Set to 1/1/0001 12:00:00 AM
    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
}


static void GetUserData()
{
    //get input data
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();
    Console.Write("Please enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    //Change echo color
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Green;

    //output data
    Console.WriteLine($"Your name is {name} and your age is {age}");

    Console.ForegroundColor = prevColor;

}

static void VerbatimStrings()
{
    // The following string is printed verbatim, // thus all escape characters are displayed.
    Console.WriteLine(@"C:\MyApp\bin\Debug");

    // Whitespace is preserved with verbatim strings.
    string myLongString = @"This is a very very
    very
    long string"; Console.WriteLine(myLongString);

    string interp = "interpolation"; 
    string myLongString2 = $@"This is a very very
    long string with {interp}";
}