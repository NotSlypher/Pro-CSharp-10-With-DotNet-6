# Encapsulation

# Class

Classes are a way to bundle data and functionality together. Creating a new class creates a new type of object, allowing new instances of that type to be made.

## Constructor

The constructor is a special method that is called when an object is instantiated. It is used to initialize the object's attributes and perform any setup required for the object to function properly.

### Constructor with an out parameter

```C#
// Constructor with an out parameter
public Car(string name, int speed, out bool isSafe)
{
    petName = name;
    currSpeed = speed;
    isSafe = (currSpeed < 100) ? true : false;
}
```

The constructor with an out parameter must follow all rules for an out parameter.

### Constructor chaining

Constructor chaining is a design pattern in which a class has multiple constructors, each calling another constructor in the class to perform common initialization tasks to avoid code duplication.

```C#
// Constructor chaining
public class Motorcycle
{
    public int driverIntensity;
    public string name;

    public Motorcycle() { }
    public Motorcycle(int intensity) : this(intensity, "") { }
    public Motorcycle(string name) : this(0, name) { }
    public Motorcycle(int intensity, string name)
    {
        this.name = name;
        if (intensity > 10)
        {
            intensity = 10;
        }
        driverIntensity = intensity;
    }
}
 ```

 ---
 `Note: using the this keyword to call another constructor in the same class is never mandatory, but using this you can write more maintainable code.`

 `Note: Alternative to constructor chaining is to use optional parameters.`

 ### Constructor flow

As you can see, the flow of constructor logic is as follows:
- You create your object by invoking the constructor requiring a single int.
- This constructor forwards the supplied data to the master constructor and provides any additional startup arguments not specified by the caller.
- The master constructor assigns the incoming data to the object’s field data.
- Control is returned to the constructor originally called and executes any remaining code statements.