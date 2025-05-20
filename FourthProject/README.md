# 📱 Smartphone Management Console App (C#)

A simple yet complete C# console application designed to manage smartphones through object-oriented programming principles. This project is beginner-friendly and showcases the creation, manipulation, and display of smartphone data using classes, constructors, encapsulation, and exception handling.

---

## 🚀 Features

- 🧑‍💻 **Object-Oriented Design**  
  Defines a `Smartphone` class with private attributes and public methods to demonstrate encapsulation.

- 🏗️ **Constructors**  
  Includes both a default constructor and a parameterized constructor for flexible object creation.

- 🧾 **Information Display**  
  Retrieves and prints formatted smartphone details using a method (`getInfoSmartphone`).

- 💸 **Discount System**  
  Applies percentage-based discounts to a smartphone’s price, ensuring the percentage is valid and using error handling.

- 📶 **5G Connectivity Check**  
  Displays whether the smartphone supports 5G using a method that returns a human-readable message.

- 🔐 **Encapsulation with Setters/Getters**  
  Controls access to the price field via `getPrecio()` and `setPrecio(double)` with validation included.

---

## 🧠 How It Works

When you run the program:

1. Two `Smartphone` objects are created:
   - One using the **default constructor** with predefined values.
   - One using the **parameterized constructor** with custom values (e.g., Samsung Galaxy S21, 128GB, 5G, 799.99€).
2. The app displays information about both smartphones.
3. A **20% discount** is applied to the second smartphone using `aplicarDescuento`.
4. The updated price after discount is shown.
5. A method checks whether the phone supports **5G** and outputs the result.

---

## 💻 Example Output

```bash
Smartphone 1 info: Brand: Generic, Model: ModelX, Storage: 64GB, 5G: False, Price: 299.99 euros
Smartphone 2 info: Brand: Samsung, Model: Galaxy S21, Storage: 128GB, 5G: True, Price: 799.99 euros
Smartphone 2 new price: 639.992 euros
Smartphone 2: This smartphone supports 5G connectivity.
```

---

## 🛠️ Technologies Used

- **Language:** C#  
- **Type:** Console Application  
- **Key Concepts Covered:**
  - Object-Oriented Programming (OOP)
  - Encapsulation (private fields, public setters/getters)
  - Constructors (default and parameterized)
  - Exception Handling (`try-catch`)
  - Basic Conditional Logic (if-else, ternary operators)

---

## 📎 Notes

- All prices are displayed with **two decimal places**.
- **Discounts** must be between 1% and 100%.
- **Invalid prices** are rejected in the `setPrecio` method with an error message.
- Designed as a **learning exercise** for students starting out in C# and OOP.

---

## ▶️ Run It Yourself

### Requirements
- .NET SDK installed (e.g., [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download))
- IDE such as Visual Studio or Visual Studio Code

### Steps
1. Clone or download this repository.
2. Open the project folder in your IDE.
3. Run the program from your terminal or the IDE:
   ```bash
   dotnet run
   ```

---

## 📚 Learning Purpose

This project is part of a series of small console applications built to **reinforce object-oriented programming** in C#. It's ideal for students or junior developers who are starting with class structures, constructors, and basic logic handling in C#.

---

## 📄 License

This project is open-source and free to use for educational purposes.
