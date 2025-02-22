# Collections and Generics C#

## Collections

Collections are used to store, retrieve, manipulate, and communicate aggregate data. They are used to store groups of objects. The .NET Framework provides specialized classes for data storage and retrieval. These classes are called collections.

### Problems with collections

1. **Type Safety**: Collections are not type-safe. You can add any type of object to a collection. This can lead to runtime errors.
2. **Performance**: Collections are not optimized for performance. They are not efficient for storing large amounts of data.
3. **Memory Management**: Collections do not manage memory efficiently. They can lead to memory leaks and performance issues.
4. **Boxing and Unboxing**: Collections use boxing and unboxing to store value types. This can lead to performance issues.

## Generics

Generics are used to create type-safe collections. They allow you to create collections that are type-safe and efficient. Generics allow you to create collections that are optimized for performance and memory management.

### Benefits of Generics

1. **Type Safety**: Generics are type-safe. You can create collections that are type-safe and efficient.
1. **Performance**: Generics are optimized for performance. They are efficient for storing large amounts of data.
1. **Memory Management**: Generics manage memory efficiently. They prevent memory leaks and performance issues.
1. **Boxing and Unboxing**: Generics do not use boxing and unboxing. They are optimized for performance.
1. **Code Reusability**: Generics allow you to create reusable code. You can create collections that are generic and reusable.
1. **Compile-Time Checking**: Generics provide compile-time checking. They prevent runtime errors and type mismatches.
1. **Type Inference**: Generics provide type inference. They allow you to create collections without specifying the type.

## Collection Initialization

Collection initialization is a feature of C# that allows you to initialize collections in a concise and readable way. It allows you to create collections and add elements to them in a single statement.

```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
Dictionary<string, int> scores = new Dictionary<string, int> { 
	{ "Alice", 100 }, 
	{ "Bob", 90 }, 
	{ "Charlie", 80 } 
};
```

### Types of Generics

1. **`List<T>``**: Represents a list of objects that can be accessed by index. It is similar to an array.
1. **`Dictionary<TKey, TValue>``**: Represents a collection of key/value pairs. It is similar to a hash table.
1. **`Queue<T>``**: Represents a first-in, first-out (FIFO) collection of objects.
1. **`Stack<T>``**: Represents a last-in, first-out (LIFO) collection of objects.
1. **`HashSet<T>``**: Represents a collection of unique objects. It does not allow duplicate elements.
1. **`LinkedList<T>``**: Represents a doubly linked list of objects.
1. **`SortedSet<T>``**: Represents a sorted collection of unique objects.
1. **`SortedDictionary<TKey, TValue>``**: Represents a collection of key/value pairs that are sorted by key.

### Default values for Generics Type T

if we have a reset method where we want to reset the value of the generic type to its default value, we can use the default keyword to get the default value of the type.
```csharp
public void ResetPoint() {
	_xPos = default(T); 
	_yPos = default(T); 
	}
```

Starting in C#7.1 default value can also be set using default expression literal eliminating the need to specify the type.
```csharp
public void ResetPoint() {
	_xPos = default; 
	_yPos = default; 
	}
```

### Constraining type parameters

| Generic Constraint | Meaning in Life |
| ----- | ----- |
| where T : struct | The type argument must be a value type. |
| where T : class | The type argument must be a reference type. |
| where T : new() | The type argument must have a public parameterless constructor. |
| where T : <base class> | The type argument must be or derive from the specified base class. |
| where T : <interface> | The type argument must be or implement the specified interface. |
| where T : U | The type argument must be or derive from the specified type argument U. |

```csharp
// MyGenericClass derives from object, while
// contained items must be a class implementing IDrawable 
// and must support a default ctor.
public class MyGenericClass<T> where T : class, IDrawable, new() {
	...
}
```

- here, T must be a class, implement IDrawable, and have a default constructor. The new() constraint must be specified last in the constraints list.

## Observable Collections

- Observable collections are a type of collection that notifies when items are added, removed, or updated.

1. **ObservableCollection<T>**: Represents a dynamic data collection that provides notifications when items are added, removed, or updated.
1. **ReadOnlyObservableCollection<T>**: Represents a read-only wrapper around an ObservableCollection<T>. It provides read-only access to the collection.

### NotifyCollectionChangedEventArgs

- The NotifyCollectionChangedEventArgs class provides 2 important properties:
  1. **OldItems**: Gets the list of items affected by a Replace, Remove, or Move action.
  1. **NewItems**: Gets the list of new items involved in the change.
  1. **Action**: Gets the action that caused the event.

- However you need to know under which circumstances these properties are populated:
  1. **Add**: OldItems is null and NewItems contains the items that were added.
  1. **Remove**: OldItems contains the items that were removed and NewItems is null.
  1. **Replace**: OldItems contains the items that were replaced and NewItems contains the new items.
  1. **Move**: OldItems contains the items that were moved and NewItems contains the new items.
  1. **Reset**: OldItems is null and NewItems is null.

```csharp
public enum NotifyCollectionChangedAction {
	Add = 0,
	Remove = 1,
	Replace = 2,
	Move = 3,
	Reset = 4,
}
```

### NotifyCollectionChangedEventHandler

- The NotifyCollectionChangedEventHandler delegate is used to handle the CollectionChanged event of the ObservableCollection<T> class.

```csharp
ObservableCollection<Person> people = new ObservableCollection<Person>()
{
    new Person{ Age=12, FirstName="Ayu", LastName="Tom"},
    new Person{ Age=12, FirstName="Ayu", LastName="Com"},
};

people.CollectionChanged += People_CollectionChanged;

void People_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
{
    Console.WriteLine("action for this event: {0}", e.Action);

    if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
    {
        Console.WriteLine("Here are the new items:");
        foreach (Person p in e.NewItems)
        {
            Console.WriteLine(p.ToString());
        }
    }

    if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
    {
        Console.WriteLine("Here are the old items:");
        foreach (Person p in e.OldItems)
        {
            Console.WriteLine(p.ToString());
        }
    }
}
```