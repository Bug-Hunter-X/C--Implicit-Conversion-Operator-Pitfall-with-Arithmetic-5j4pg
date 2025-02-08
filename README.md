# C# Implicit Conversion Operator Pitfall

This code demonstrates a subtle issue with implicit conversion operators in C# when used in conjunction with arithmetic operations.  While implicit conversions work well for direct assignments, they may not be automatically applied to arithmetic expressions.

The `Bug.cs` file contains the problematic code. The `BugSolution.cs` file presents a solution to correct this problem.

## Problem
The implicit conversion operators between `MyClass` and `int` are defined. Assignments (e.g., `MyClass obj1 = 10;`) work correctly. However, using the `+` operator directly with `MyClass` and `int` results in a compiler error. This occurs because the compiler doesn't automatically apply the implicit conversion within the arithmetic expression. 

## Solution
To resolve this, you'll need to explicitly cast the `MyClass` object to an `int` before performing the arithmetic operation, ensuring that the compiler can apply the `+` operator to two `int` values.