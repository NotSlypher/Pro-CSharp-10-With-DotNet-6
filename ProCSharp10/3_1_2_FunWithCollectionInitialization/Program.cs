using _3_1_2_FunWithCollection;
using _3_1_2_FunWithCollectionInitialization;
using System.Collections;
using System.Drawing;

int[] myArrayOfInts = { 1, 2, 3, 4, 5 };
List<int> myGenericList = new List<int> { 1, 2, 3, 4, 5 };
ArrayList myArrayList = new ArrayList { 1, 2, 3, 4, 5 };

List<Point> myPointList = new List<Point> { new Point(1, 2), new Point(3, 4) };
foreach (Point p in myPointList)
{
    Console.WriteLine(p);
}

UseGenericsList();

static void UseGenericsList()
{
    List<Person> myList = new List<Person>(){
        new Person { Age = 23, FirstName = "ram", LastName = "mukherjee" },
        new Person { Age = 23, FirstName = "sam", LastName = "mukherjee" },
        new Person { Age = 23, FirstName = "dam", LastName = "mukherjee" },
        new Person { Age = 23, FirstName = "pam", LastName = "mukherjee" }
    };

    Console.WriteLine("there are {0} persons in the list", myList.Count);

    foreach (var person in myList)
    {
        Console.WriteLine(person);
    }

    myList.Add(new Person { Age = 23, LastName = "das", FirstName = "yam" });

    Console.WriteLine("there are {0} persons in the list", myList.Count);

    foreach (var person in myList)
        Console.WriteLine(person);
}

static void UseGenericStack()
{
    Stack<Person> stack = new Stack<Person>();
    stack.Push(new Person { FirstName = "ram", Age = 23, LastName = "ds" });
    stack.Push(new Person { FirstName = "dam", Age = 23, LastName = "ds" });
    stack.Push(new Person { FirstName = "eam", Age = 23, LastName = "ds" });

    Console.WriteLine("First person in the stack is {0}", stack.Peek();
    Console.WriteLine("Popped off {0}", stack.Pop());
    Console.WriteLine("First person in the stack is {0}", stack.Peek();
    Console.WriteLine("Popped off {0}", stack.Pop());
    Console.WriteLine("First person in the stack is {0}", stack.Peek();
    Console.WriteLine("Popped off {0}", stack.Pop());
}

static void UseGenericSortedSet()
{
    SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge)
    {
        new Person { FirstName = "dam", Age = 23, LastName = "ds" },
        new Person { FirstName = "eam", Age = 23, LastName = "ds" },
        new Person { FirstName = "ram", Age = 23, LastName = "ds" }
    };

    // Note the items are sorted by age!
    foreach (Person p in setOfPeople)
    {
        Console.WriteLine(p);
    }
    Console.WriteLine();
    // Add a few new people, with various ages.
    setOfPeople.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
    setOfPeople.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });
    // Still sorted by age!
    foreach (Person p in setOfPeople) { Console.WriteLine(p); }
}