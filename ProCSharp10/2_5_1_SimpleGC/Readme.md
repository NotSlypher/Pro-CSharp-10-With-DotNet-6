# Object Lifetime - Garbage Collection

## Garbage Collection

- Golden rule of .NET core memory management is :

1. `Allocate a class instance onto the managed heap using the new keyword and forget about it.`
2. `If the mangaed heap does not have sufficient memory to allocate a requested object, a garbage collection will occur.`

- ONce isntanciated the GC will take care of the object and will free the memory when it is no longer needed. How does the GC know when an object is no longer needed? 
- short answer incomplete answer : it removes object that are no longer reachable from any part of your code base.

```csharp
static void MakeCar()
{
    // if myCar is the only refere to the car oblject, it *may* be destroyed when this method ends
    Car myCar = new Car();
}
```
- The GC is a non-deterministic process. It runs when it needs to and not when you want it to.
- In the above code the myCar object is no longer reachable from any part of the code base. It is eligible for garbage collection. 
- ie it is not garanteed that the object will immediately be claimed by the memory but it is eligible to be claimed by the memory.
- The newobj instruciton tells the runtime to perfomr the following core operations
    1. Calculate toltal amount of memorey required by the objectto be allocated.
    2. Examine the managed heap to ensure taht there is indeed enough room to host the object to be allocated. If there is, the specified contructor is called and the caller is ultimately returned a reference to the object in memory, whose addres just happens to be identical to the last position of the next object pointer.
    3. If there is not enough room on the managed heap to host the object, the GC is invoked to free up some memory. The GC will then compact the heap and make room for the new object.
    4. Finally, before returning the reference to the caller, advance the next object pointer to point to the next available slot on themanged heap.

### Determining if an object is live

- The GC uses a technique called `mark and sweep` to determine if an object is live.
- The GC uses the following information to derermine whether an object is live:
    1. `Stack roots`: These are references to objects that are stored on the stack. provided by the compiler and the stack walker
    2. `Garbage collection handles`: These are references to objects that are explicitly declared in the code using the `GCHandle` class.
    3. `Static data`: These are references to objects that are stored in the static fields of the application.
- `object graph` is built by the runtime to investigate the objects on the managed heap to determine whether they are still reachable from the root objects.