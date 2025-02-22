# Operator Overloading

## Overloadability of C# operators

| C# Operator | Overloadability|
| --- | --- |
|+, -, !, ~, ++, --, true, false | These unary operators can be overloaded. C# demands that if true or false is overloaded, both must be overloaded. |
| +, -, *, /, %, &, ^, <<, >> | These binary operators can be overloaded. |
| ==,!=, <, >, <=, >= | These comparison operators can be overloaded. C# demands that “like” operators (i.e., < and >, <= and >=, == and !=) are overloaded together. |
| [] | The [] operator cannot be overloaded. As you saw earlier in this chapter, however, the indexer construct provides the same functionality. |
| () | The () operator cannot be overloaded. As you will see later in this chapter, however, custom conversion methods provide the same functionality. |
| +=, -=, *=, /=, %=, &=, ^=, <<=, >>= | Shorthand assignment operators cannot be overloaded; however, you receive them as a freebie when you overload the related binary operator. |

```csharp
public class Point
{
...
// Overloaded operator +.
public static Point operator + (Point p1, Point p2)
	=> new Point(p1.X + p2.X, p1.Y + p2.Y);
// Overloaded operator -.
public static Point operator - (Point p1, Point p2) 
	=> new Point(p1.X - p2.X, p1.Y - p2.Y);
}
```

- 