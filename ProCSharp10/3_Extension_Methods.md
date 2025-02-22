# Extension methods

- Extension methods are a way to add new methods to existing types without modifying the original type.

## Defining Extension Methods

- Extension methods are defined as static methods in a static class.
- all extension methods are marked as such by using the `this` keyword before the first parameter.

```csharp
static class MyExtensions
    {
        // this method allows any object to display the assembly it is in
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine($"{obj.GetType().Name} lives here: => {obj.GetType().Assembly.GetName().Name}");
        }

        public static int ReverseDigits(this int i)
        {
            char[] digits = i.ToString().ToCharArray();
            Array.Reverse(digits);
            string newDigits = new string(digits);
            return int.Parse(newDigits);
        }
    }
```