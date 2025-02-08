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
