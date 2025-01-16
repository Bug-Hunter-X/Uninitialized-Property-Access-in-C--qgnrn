# Uninitialized Property Access in C# Example

This repository demonstrates a common C# error: accessing a property before it's been initialized.  This can lead to a `NullReferenceException` at runtime.

The `bug.cs` file contains the code with the error. The `bugSolution.cs` file shows how to fix the problem.

## How to Reproduce
1. Clone this repository.
2. Open `bug.cs` in a C# IDE.
3. Run the `MyMethod()` method.
4. Observe the `NullReferenceException`.

## Solution
The solution is to initialize the `MyProperty` either in the constructor or before accessing it in `MyMethod()`.