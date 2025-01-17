# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it's been initialized.  Uninitialized properties will have their default values, which might not be what your code expects.

## The Bug

The `bug.cs` file contains a class with a property that's not initialized before it's accessed in a method.  Depending on the context, this could cause unexpected results or even exceptions.

## The Solution

The `bugSolution.cs` file shows the correct way to handle this: explicitly initializing the property or initializing the property using the constructor