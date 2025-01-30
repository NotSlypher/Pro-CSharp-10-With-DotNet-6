# Value and reference types

- Unlike arrays, strings, or enumerations, C# structures do not have an identically named representation in the .NET Core library (i.e., there is no System.Structure class) but are implicitly derived from System.
- Value types are stored in the stack, while reference types are stored in the heap.

```csharp
Console.WriteLine("Assigning value types\n");
Point p1 = new Point(10, 10); Point p2 = p1;

// Print both points. 
p1.Display(); 
p2.Display();

// Change p1.X and print again. p2.X is not changed. 
p1.X = 100;
Console.WriteLine("\n=> Changed p1.X\n"); p1.Display();
p2.Display();
```
## Value type containing reference type

- Assume you have the following reference (class) type that maintains an informational string that can be set using a custom constructor:

```csharp
class ShapeInfo
{
    public string InfoString; 
    public ShapeInfo(string info){
        InfoString = info;
    }
}
```

- Now assume that you want to contain a variable of this class type within a value type named Rectangle. 

```csharp
struct Rectangle
{
// The Rectangle structure contains a reference type member. 
    public ShapeInfo RectInfo;
    public int RectTop, RectLeft, RectBottom, RectRight;
    public Rectangle(string info, int top, int left, int bottom, int right) {
        RectInfo = new ShapeInfo(info);
        RectTop = top; RectBottom = bottom;
        RectLeft = left; RectRight = right;
    }
    public void Display()
    {
        Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " + "Left = {3}, Right = {4}", RectInfo.InfoString, RectTop, RectBottom, RectLeft, RectRight);
    } 
}
```

- “What happens if you assign one Rectangle variable to another?”

```csharp
static void ValueTypeContainingRefType()
{
    // Create the first Rectangle. 
    Console.WriteLine("-> Creating r1"); 
    Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);
    // Now assign a new Rectangle to r1. 
    Console.WriteLine("-> Assigning r2 to r1"); 
    Rectangle r2 = r1;
    // Change some values of r2. 
    Console.WriteLine("-> Changing values of r2"); 
    r2.RectInfo.InfoString = "This is new info!"; 
    r2.RectBottom = 4444;

    //print values of both rectangles
    r1.Display();
    r2.Display();
}
```

- The output of the ValueTypeContainingRefType method is as follows:

---
```
-> Creating r1
-> Assigning r2 to r1
-> Changing values of r2
String = This is new info!, Top = 10, Bottom = 50, Left = 10, Right = 50 
String = This is new info!, Top = 10, Bottom = 4444, Left = 10, Right = 50
```

- As you can see, when you change the value of the informational string using the `r2` reference, the `r1` reference displays the same value. By default, when a value type contains other reference types, assignment results in a copy of the references. 
- In this way, you have two independent structures, each of which contains a reference pointing to the same object in memory