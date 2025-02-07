# Interfaces

## Interfaces vs Abstract Base Classes

- Abstract classes are used when you want to provide a common base class implementation for all derived classes, but you do not want to allow the instantiation of the base class itself, abstract classes can define the following
	- Abstract methods
	- Virtual methods
	- Any number of constructors
	- field data
	- non-abstract methods etc
- Interfaces are used when you want to define a contract that all derived classes must follow, interfaces can define the following
	- Methods
	- Properties
	- Events
	- Indexers
	- Interfaces cannot define field data, constructors, or destructors
	- static constructor