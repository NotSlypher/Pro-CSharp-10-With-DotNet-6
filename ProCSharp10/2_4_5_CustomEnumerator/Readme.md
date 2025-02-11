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