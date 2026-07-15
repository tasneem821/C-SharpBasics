# C# Fundamentals

This repository contains my solutions, examples, and practice exercises from the **C# Fundamentals** course of the .NET Track.

## 📁 Project Structure

```text
C#Basics
│
└── SessionOne
    ├── Program.cs
    └── Student.cs
```

### 📄 Files

| File | Description |
|------|-------------|
| **Program.cs** | Demonstrates the fundamental concepts of C# including comments, variables, variable scope, naming conventions, value types, and reference types. |
| **Student.cs** | Contains the `Student` class used throughout the examples to demonstrate object-oriented concepts such as object creation and reference behavior. |

---

## 📚 Topics Covered

### ✅ Comments
- Single-line comments (`//`)
- Multi-line comments (`/* */`)
- XML documentation comments (`///`)

### ✅ Variables
- Declaring variables
- Common data types (`string`, `int`, `double`)
- String interpolation

### ✅ Variable Scope
- Class-level fields
- Method-level variables
- Block-level variables

### ✅ Naming Conventions
- PascalCase
- camelCase

### ✅ Value Types
- `int`
- `double`
- `bool`
- `char`

Understanding how value types copy **the actual value**.

### ✅ Reference Types
Using a custom `Student` class to demonstrate:

- Object creation
- References
- Heap vs Stack
- Copying object references

---

## 💻 Code Demonstrations

The `Program.cs` file contains the following demonstrations:

- `Comment_Demo()`
- `Variables_Demo()`
- `Scope_Demo()`
- `Naming_Demo()`
- `ValueTypes_Demo()`
- `ReferenceTypes_Demo()`

Each method focuses on explaining one core C# concept with simple examples.

---

## 🛠 Technologies

- C#
- .NET
- Visual Studio 2022

---

## 🚀 How to Run

1. Clone the repository

```bash
git clone https://github.com/YourUsername/csharp-fundamentals.git
```

2. Open the solution in **Visual Studio**.

3. Run the project.

4. Uncomment any demo method inside `Main()` to explore a specific concept.

Example:

```csharp
static void Main(string[] args)
{
    Comment_Demo();
    Variables_Demo();
    Scope_Demo();
    Naming_Demo();
    ValueTypes_Demo();
    ReferenceTypes_Demo();

    Console.ReadKey();
}
```

---

## 🎯 Learning Objectives

By completing this session, I learned:

- C# program structure
- Writing comments and documentation
- Variables and primitive data types
- Variable scope
- C# naming conventions
- Difference between value types and reference types
- Creating and using classes
- Basic object manipulation

---

## 📄 License

This project is intended for educational purposes as part of my **.NET learning journey**.
