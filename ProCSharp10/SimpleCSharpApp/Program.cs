
Console.WriteLine("Ek C# ka console application");
Console.WriteLine("Hello, World!");

ShowEnvironmentDetails();

///print drives in this machine and other details
void ShowEnvironmentDetails()
{
    foreach (var drives in Environment.GetLogicalDrives())
    {
        Console.WriteLine($"Drive is {drives}");
    }
    Console.WriteLine($"OS is {Environment.OSVersion}");
    Console.WriteLine($"DotNet version is {Environment.Version}");
}

return -1;