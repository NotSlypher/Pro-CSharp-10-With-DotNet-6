# Inheritance

Inheritance is a mechanism in which one class acquires the properties and behavior of another class. It represents a relationship between two classes (IS-A Relationship).

## Constructors in Inheritance

- In C#, when a class is derived from another class, the constructor of the base class is not inherited by the derived class.
- When a class is instantiated, the constructor of the base class is called first (default constructor if not specified otherwise), then the constructor of the derived class is called.
- If the base class does not have a default constructor, the derived class must explicitly call the parameterized constructor of the base class using the `base` keyword.
- This will reduce the redundancy of code and will also help in code reusability.

## Containment

Containment is a relationship between two classes where one class contains the other class. The contained class is a part of the container class. The contained class is created and destroyed along with the container class. The contained class is not shared with any other class. The contained class is not aware.

- This relationship is also known as the **has-a** relationship.

```CSharp
Class Container
{
	Contained obj = new Contained();
}
```

## Delegation

Delegation is a relationship between two classes where one class delegates some of its responsibilities to another class. The class that delegates the responsibility is called the delegator and the class that accepts the responsibility is called the delegatee.

- This relationship is also known as the **uses-a** relationship.
- Since now we have success contained a class, exposing the functionality of the contained class to the outside world is called delegation.
- Delegation is simply the act of adding public members to the container class that call the contained objects functionality.

```CSharp
Class Container
{
	Contained obj = new Contained();
	
	public void DelegatedMethod()
	{
		obj.ContainedMethod();
	}
}
```

## Base Class/ Derived Class casting rules

- A derived class reference cannot refer to a base class object.
- A base class reference can refer to a derived class object, but it can only access the members of the base class.
- Every class in C# is derived from the Object class. So, an object reference can refer to any class object.
- `Implicit cast` is the casting of a derived class reference to a base class reference. It is done automatically by the compiler.
- `Explicit cast` is the casting of a base class reference to a derived class reference. It is done manually by the programmer.
- `is` operator is used to check whether an object is compatible with a given type or not.\
- `as` operator is used to perform explicit castings. If the cast is not successful, it returns null.
- Explicit casting is evaluated at `runtime`, not `compile` time. So, it may throw an `InvalidCastException` exception if the cast is not successful.
- Implicit casting is evaluated at `compile` time.

```CSharp
class Base
{
	public void BaseMethod()
	{
		Console.WriteLine("Base Method");
	}
}

class Derived : Base
{
	public void DerivedMethod()
	{
		Console.WriteLine("Derived Method");
	}
}

class Program
{
	static void Main()
	{
		Base b = new Base();
		Derived d = new Derived();
		
		Base b1 = d; // Implicit cast
		b1.BaseMethod();
		
		Derived d1 = (Derived)b; // Explicit cast
		d1.DerivedMethod();
	}
}
```

- `as` operator provides a way to cast a base class reference to a derived class reference without throwing an exception. If the cast is not successful, it returns `null`.

```CSharp
object[] things = new object[4];
things[0] = new Hexagon();
things[1] = false;
things[2] = new Manager();
things[3] = "Last thing";

foreach (object item in things)
{
    Hexagon h = item as Hexagon;
    if (h == null)
    {
        Console.WriteLine("Item is not a hexagon");
    }
    else
    {
        h.Draw();
    }
}
```

- `is` operator returns `false` if the cast is not successful. It performs a `runtime` check to determine if the object is compatible with the given type.

```CSharp
static void GivePromotion(Employee emp)
{
    Console.WriteLine("{0} was promoted!", emp.Name);
    if (emp is SalesPerson)
    {
        Console.WriteLine("{0} made {1} sale(s)!", emp.Name, ((SalesPerson)emp).SalesNumber);
    }
    else if (emp is Manager)
    {
        Console.WriteLine("{0} had {1} stock options", emp.Name, ((Manager)emp).StockOptions);
    }
    Console.WriteLine();
}
```

- The `is` operator can also assign the result to a variable if the cast is successful. Thus cleans up the need for explicit casting and preventing the problem of double casting.

```CSharp
if (emp is SalesPerson s)
{
	Console.WriteLine("{0} made {1} sale(s)!", emp.Name, s.SalesNumber);
}
else if (emp is Manager m)
{
	Console.WriteLine("{0} had {1} stock options", emp.Name, m.StockOptions);
}
```

- The `is` operator can also be used with `not` operator `!` to check if the object is not compatible with the given type.

### Casting in switch statements

- The `switch` statement can also be used with the `is` operator to check the type of the object.
- The `switch` statement can also be used with the `when` keyword to check the type of the object and assign it to a variable if the cast is successful.

```CSharp
foreach (Employee emp in employees)
{
	switch (emp)
	{
		case SalesPerson s when s.SalesNumber > 5:
			Console.WriteLine("{0} made {1} sale(s)!", s.Name, s.SalesNumber);
			break;
		case Manager m:
			Console.WriteLine("{0} had {1} stock options", m.Name, m.StockOptions);
			break;
	}
}
```
`Note :` The `is` operator is used to check whether an object is compatible with a given type or not. The `as` operator is used to perform explicit castings. If the cast is not successful, it returns `null`.

---

- `ToString()` method of the `Object` class is used to return a fully qualified name of the object. It is overridden in the derived classes to return a meaningful string representation of the object. 
- With inheritance, the `ToString()` method is overridden in the derived class with the care for chain of inheritance and the `base` keyword is used to call the base class `ToString()` method.

```CSharp
class Base
{
	public override string ToString()
	{
		Console.WriteLine($"BaseProp1 is {BaseProp1}, BaseProp2 is {BaseProp2}, ...");
	}
}

class Derived : Base
{
	public override string ToString()
	{
		Base.ToString();
		Console.WriteLine($"DerivedProp1 is {DerivedProp1}, ...");
	}
}
```

- The `Equals()` method of the `Object` class is used to compare two objects. It is overridden in the derived classes to compare the properties of the objects.
- It my default compares the references of the objects. So, it is overridden in the derived classes to compare the properties of the objects.
- While it may be tedius to compare all the properties of the objects, if you have `ToString()` method overridden, you can use it to compare the objects.

```CSharp
class Base
{
	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		
		if (this.GetType() != obj.GetType())
		{
			return false;
		}
		
		Base b = (Base)obj;
		return this.ToString() == b.ToString();
	}
}
```

- The `GetHashCode()` method of the `Object` class is used to return a hash code of the object. It is overridden in the derived classes to return a hash code based on the properties of the object.
- The `GetHashCode()` method is used to return a hash code of the object. It is overridden in the derived classes to return a hash code based on the properties of the object.

```CSharp
class Base
{
	public override int GetHashCode()
	{
		return this.ToString().GetHashCode();
	}
}
```