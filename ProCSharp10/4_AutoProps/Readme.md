# Autoprops

- Autoprops are a way to automatically generate properties for a class.
- You cannot write business logic ie custom getter and setter for autoprops instead you will have to use the traditional way of writing properties.
- When you use automatic property syntax to wrap another class variable, the hidden private reference type will also be set to a default value of null
-  The compiler will automatically generate the private reference type which is hidden but will be accessible through IL code and the public property for you.