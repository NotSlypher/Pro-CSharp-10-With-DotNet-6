#Arrays and Tuples

## Arrays

Arrays are a collection of elements of the same type. They are mutable, which means that the elements of the array can be changed after the array is created.

### Index and Range Type

In C# 8, index type is introduced. It is a type that represents an index of a collection. It is a readonly struct and is used to index a collection. It is defined in the System namespace.

It has 2 new operators:
- `^` - The caret operator is used to denote the index from the end of the collection. **Last item from in a sequence is one less than actual length, so `^1` is the last item and `^0` would cause error.**

- `..` - The range operator is used to create a range of indices. Creates a subsequence from the start index to the end index.


ex. `Index i = ^1;` - This will create an index that is 1 from the end of the collection.

ex. `Range r = 1..^1;` - This will create a range that starts from index 1 and ends at 1 from the end of the collection.



## Tuples	

Tuples are a data structure that can hold multiple elements. They are immutable, which means that the elements of the tuple cannot be changed after the tuple is created.


---
>***Note***: Boxing occurs when a value type is converted to a reference type(stored on the heap), and unboxing occurs when a reference type is converted to a value type (stored on the stack).