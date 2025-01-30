# Encapsulation

- Encapsulation is the process of hiding the internal implementation details of an object and only showing the necessary functionality to the outside world.

## Object Initialization

### Using init-Only setters

- In C# 9.0, you can use init-only setters to set the value of a property only once during object initialization.
- These type of properties are called **immuatble properties**.

```C#
public class Car
{
	public string PetName { get; init; }
	public int CurrSpeed { get; init; }

	public Car(string name, int speed)
	{
		PetName = name;
		CurrSpeed = speed;
	}
}
```

- This can also be used with object initializers.

```C#
Car myCar = new Car { PetName = "Henry", CurrSpeed = 100 };
```

- Object initializer is called after the constructor is called.

```C#
Car myCar = new Car("Henry", 20) { CurrSpeed = 100 };
```
- In the above example, the `CurrSpeed` property is set to 100 after the constructor is called.

---

- `Constant fields` are implicitly `static` and `readonly`. It needs to be determined at compile time. Hence it can also be assigned in a static constructor.

- `Readonly fields` can be assigned a value only once, either in the declaration or in the constructor. It can be assigned at runtime.

```C#
public class Car
{
	public readonly string PetName;
	public readonly int CurrSpeed;

	public Car(string name, int speed)
	{
		PetName = name;
		CurrSpeed = speed;
	}
}
```

---