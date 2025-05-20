# 📐 OOP Concepts: Point Distance Calculation Program (C#)

Welcome to the simple point distance calculator!

This beginner-friendly C# console app demonstrates basic Object-Oriented Programming (OOP) concepts. It creates `Point` objects, calculates the Euclidean distance between two points, and outputs the result to the console.

---

## 🚀 Key Features

- 🏷 **Class Definition:** Implements the `Point` class with private fields `x` and `y`.
- 🔧 **Constructors:** Supports a default constructor (point at origin) and a parameterized constructor.
- 📐 **Distance Method:** Calculates the Euclidean distance between two points using the Pythagorean theorem.
- 🖥 **Console Output:** Displays the calculated distance between two `Point` objects.
- 🔄 **Simple Structure:** Main method creates points and performs the calculation.

---

## 📋 Program Details

- **`Point` Class:**
  - Private fields `x` and `y` representing point coordinates.
  - Default constructor initializing the point at `(0, 0)`.
  - Parameterized constructor to define coordinates when creating the object.
  - `DistanceTo(Point otherPoint)` method that returns the distance to another point.

- **`Program` Class:**
  - `Main` method calls `PerformTask()`.
  - `PerformTask()` creates two points (`origin` and `destination`), calculates the distance, and prints it.

---

## ▶️ How to Use

1. **Run the program** from your IDE or terminal.
2. The program automatically creates two points: 
   - Origin at `(0, 0)`.
   - Destination at `(150, 90)`.
3. Calculates the distance between these points.
4. Displays the result in the console:  
   `The distance between the points is: [value]`

---

## 📦 Technologies

- Language: C#
- Type: Console Application
- OOP Concepts covered:
  - Classes and objects
  - Constructors
  - Encapsulation (private fields)
  - Methods

---

## 👨‍🎓 Great for beginners learning:

- Basic Object-Oriented Programming in C#
- Using constructors
- Simple mathematical calculations in programming
- Console input/output
- Methods and accessing private members
