# Interfaces

- An interface is a reference type in C# that is similar to a class, but it is a completely abstract class that contains only abstract members.
- An interface does not specify any base class, not even `System.Object`, so an interface cannot have any constructors, but it can have base interfaces.

## Interfaces vs Abstract Base Classes

- Abstract classes are used when you want to provide a common base class implementation for all derived classes, but you do not want to allow the instantiation of the base class itself, abstract classes can define the following
	- Abstract methods
	- Virtual methods
	- Any number of constructors
	- field data
	- non-abstract methods etc
- Interfaces are used when you want to define a contract that all derived classes must follow, interfaces can define the following
	- Methods
	- Properties
	- Events
	- Indexers
	- Interfaces cannot define field data, constructors, or destructors
	- static constructor
- ex.
```csharp
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
```
- In the above example, the `CloneMe` method takes an `ICloneable` interface as a parameter, and both `string` and `OperatingSystem` classes implement the `ICloneable` interface, so they can be passed into the `CloneMe` method.

### Problems with abstract base classes

1. A class can inherit from only one abstract base class
	- If a class needs to inherit from multiple abstract base classes, it is not possible
	- ex. if a class wants to inherit from the `ClonableType` abstract class to have clonable property class it cannot because it is already inheriting from another abstract class `Shape`.

2.  each derived type must contend with the set of abstract members and provide an implementation
	- If a class inherits from an abstract class, it must provide an implementation for all the abstract members of the base class
	- ex. 
	```csharp
		abstract class Shape
		{
			public abstract byte SidesCount();
		}
	```
	- Lets say we have a abstract class `Shape` where a new method `SidesCount` is added, now all the derived classes must provide an implementation for the `SidesCount` method, and we have derived classes `Circle` and `Rectangle` which do not have sides, so we have to provide a dummy implementation for the `SidesCount` method in the derived classes like `Circle` which is not a good practice.
	- This is where interfaces come into play, we can define an interface `IHasSides` which has the `SidesCount` method and only the `rectangle` class can implement the `IHasSides` interface and provide an implementation for the `SidesCount` method.

## Checking if an object implements an interface

### Using explicit casting

- We can use explicit casting to check if an object implements an interface
- if it doesnt not implement the interface, it will throw an exception which can be gracefully caught using try - catch block.
- ex.
```csharp
static void CheckIfObjectImplementsInterface()
{
	//Create a new object
	object myObj = new object();

	//Catch possible InvalidCastException
	try
	{
		//Explicitly cast the object to the interface
		ICloneable cloneable = (ICloneable)myObj;
	}
	catch (InvalidCastException ex)
	{
		Console.WriteLine("The object does not implement the ICloneable interface");
	}
}
```
- In the above example, we are trying to cast an object to the `ICloneable` interface, if the object does not implement the `ICloneable` interface, an `InvalidCastException` will be thrown, which can be caught using a `try-catch` block.
- This method is not recommended because it is not type-safe and can throw an exception at runtime.

### Using the `as` keyword

- We can use the `as` keyword to check if an object implements an interface
- The `as` keyword returns `null` if the object does not implement the interface
- ex.
```csharp
static void CheckIfObjectImplementsInterface()
{
	//Create a new object
	object myObj = new object();

	//Check if the object implements the ICloneable interface
	ICloneable cloneable = myObj as ICloneable;

	//If the object does not implement the ICloneable interface, the cloneable variable will be null
	if (cloneable == null)
	{
		Console.WriteLine("The object does not implement the ICloneable interface");
	}
}
```
- In the above example, we are using the `as` keyword to check if an object implements the `ICloneable` interface, if the object does not implement the `ICloneable` interface, the `cloneable` variable will be `null`.
- This method is recommended because it is type-safe and does not throw an exception at runtime.

### Using the `is` keyword

- We can use the `is` keyword to check if an object implements an interface
- The `is` keyword returns `true` if the object implements the interface, otherwise it returns `false`
- if you supply a variable name in the `is` keyword, it will also assign the value to the variable.
- ex.
```csharp
static void CheckIfObjectImplementsInterface()
{
	//Create a new object
	object myObj = new object();

	//Check if the object implements the ICloneable interface
	if (myObj is ICloneable cloneable)
	{
		Console.WriteLine("The object implements the ICloneable interface");
	}
	else
	{
		Console.WriteLine("The object does not implement the ICloneable interface");
	}
}
```
- In the above example, we are using the `is` keyword to check if an object implements the `ICloneable` interface, if the object implements the `ICloneable` interface, `myObj` will be assigned to the `cloneable` variable, otherwise, the `myObj` will not be assigned to the `cloneable` variable.
- This method is recommended because it is type-safe and does not throw an exception at runtime.

## Default implementations

- In C# 8.0, interfaces can have default implementations for methods, properties, and indexers
- Default implementations allow you to provide a default implementation for a method, property, or indexer in an interface
- ex.
```csharp
interface IRegularPointy
{
int Perimeter => 0;
}

class Square : IRegularPointy
{
// The Square class does not need to provide an implementation for the Perimeter property
}
```
- One problem with default implementations is that if not defined in the `Square` class, and the reference used while creating the object is of `Square` class, the method wont be accessible as it is not defined in the `Square` class. If the reference is of the interface type, then the default implementation will be used.

## Interface Name Clash

This example demonstrates how to handle interface name clashes in a single module.

- The class `Octagone` implements 3 interfaces: `IDrawToForm`, `IDrawToMemory` and `IDrawToPrinter`, where all three have the same method `Draw()`.
- Octagon class can implement only one Draw method, which is ambiguous and doesnt really make sense to implement all three interfaces.
- To resolve this, we can explicitly implement the interfaces, which allows us to implement the same method with different signatures.

```csharp
void IDrawToForm.Draw()
{
	Console.WriteLine("Drawing to form...");
}
void IDrawToMemory.Draw()
{
	Console.WriteLine("Drawing to memory...");
}
void IDrawToPrinter.Draw()
{
	Console.WriteLine("Drawing to printer...");
}
```
- Note we cannot use access modifier here as it is not allowed in explicit interface implementation, because explicitly implemented interface members are implicitly private. That is they are no longer accesible from the object level.
- You must use explicit interface implementation or explicit casing to access the members of the interface.

## Custom Enumerator

- This is a custom enumerator that can be used to iterate over a collection of items, like we do in case of built in enumerators like array, list etc using foreach loop.
- This custom enumerator is implemented using the IEnumerable and IEnumerator interfaces.
- The class that we need to be iterated over must implement the IEnumerable interface. This interface has a method GetEnumerator() which returns an object of IEnumerator interface.
- 
```charp
public interface IEnumerable
{
	IEnumerator GetEnumerator();
}
```

- The IEnumerator interface has three properties: Current, MoveNext and Reset.
```charp
public interface IEnumerator
{
	object Current { get; }
	bool MoveNext();
	void Reset();
}
```

- The class that implements the IEnumerable interface must have a method GetEnumerator() which returns an object of IEnumerator interface. This can either be done using a class that already implements the IEnumerator interface like array or by implementing the IEnumerator interface in the class itself.
```charp
    public class Garage: IEnumerable
    {
        private Car[] carArray = new Car[4];
        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        public IEnumerator GetEnumerator() => carArray.GetEnumerator();
    }
```

- The GetEnumerator() method of the Garage class returns an object of the IEnumerator interface. The GetEnumerator() method of the array class returns an object of the IEnumerator interface. So, the Garage class can return the object of the IEnumerator interface returned by the array class.
- The foreach loop can be used to iterate over the collection of items in the Garage class.
```charp
	Garage garage = new Garage();
	foreach (Car car in garage)
	{
		Console.WriteLine($"{car.PetName} is going {car.CurrentSpeed} MPH");
	}
```

### yield return

- The `yield` keyword is used to specify the value(values) to be reuturned to the caller's foreach loop.
- Whwn the yield return statement is executed, the current location in the code is remembered, and the execution is restarted from this location the next time the iterator is called.
- The `yield` keyword is used to return the value to the caller and the `return` keyword is used to return the value to the caller and exit the method.

#### Guard clause

- None of the code in GetEnumerator() is executed until the first time that the items are iterated over (or any element is accessed). That means if there is an exception prior to the `yield` statement, it will nbot get thrown when the method is first called, but only when the first `MoveNext()` is called.
- Suppose the enumerator list is gathered from a database. You might want to check that the database connection can be opened at the time the method is called, not when the list is itereated over.

```charp
public IEnumerator GetEnumerator()
        {
            throw new Exception("This won't get called");
            return actualImplementation();

            IEnumerator actualImplementation()
            {
                yield return carArray[0];
                yield return carArray[1];
                yield return carArray[2];
                yield return carArray[3];
            }
        }
```

### Named Iterators

- The `yield` keyword can be can be used with any method that returns an `IEnumerable` or `IEnumerable<T>`, regardless of its name.