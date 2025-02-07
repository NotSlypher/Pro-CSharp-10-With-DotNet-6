# Exception Handling

## What is an Exception?

- An exception is an event, which occurs during the execution of a program, that disrupts the normal flow of the program's instructions.
- The purpose to create custom exceptions is to create a strongly typed exception that can be caught and handled separately from other exceptions.
- Exceptions are the way to tell the program that something unusual has happened and the normal flow of the program cannot continue.

## Why Exception Handling?

- Exception handling is a mechanism to handle runtime errors such as ClassNotFound, IO, SQL, Remote etc.
- It is mainly used to handle checked exceptions.
- If an exception occurs in the program, the system will throw (or raise) the exception to the runtime environment.

## Exception Class

| Method | Description |
| --- | --- |
| getMessage() | Returns a detailed message about the exception that has occurred. This is the message that we provide |
| toString() | Returns the message in the form of a string. The message is obtained by calling the getMessage() method |
| Equals() | Determines whether the specified object is equal to the current object |
| GetHashCode() | Serves as the default hash function |
| GetType() | Gets the runtime type of the current instance |
| Finalize() | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection |
| MemberwiseClone() | Creates a shallow copy of the current Object |

## Proper Custom Exception

- If you want to build a truly prim-and-proper custom exception class, you want to make sure your custom 
exception does the following:
	- Derives from the Exception/ApplicationException class.
	- Defines a default constructor.
	- Defines a constructor that sets the inherited Message property.
	- Defines a constructor that sets the InnerException property.