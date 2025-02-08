
using _1_CustomInterfaces;

Console.WriteLine("******** first look at interfaces *******");
//ClonableExample();
//var sq = new Square("Square");
//sq.Draw();
//Console.WriteLine($"{sq.PetName} has {sq.NumberOfSides} of length {sq.SideLength} and a perimeter of {((IRegularPointy)sq).Perimeter}");

Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };
for(int i = 0; i < myShapes.Length; i++)
{
    if (myShapes[i] is IDraw3D s)
        s.Draw3D();
}

static void ClonableExample()
{
    string mystr = "hello";
    OperatingSystem unixOs = new OperatingSystem(PlatformID.Unix, new Version());

    //Therefore they can all be passed into a method taking ICloneable
    CloneMe(mystr);
    CloneMe(unixOs);

    static void CloneMe(ICloneable c)
    {
        //Clone whatever we wnat and print the same
        object theClone = c.Clone();
        Console.WriteLine("Your lcone is a: {0}", theClone.GetType().Name);
    }
}