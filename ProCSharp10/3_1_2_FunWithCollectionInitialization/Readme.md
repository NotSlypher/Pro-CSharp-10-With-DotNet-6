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

