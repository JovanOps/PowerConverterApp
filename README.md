# Power Converter Console App

A simple C# console application for converting power values between horsepower (HP) and kilowatts (kW).

## 🧰 Technologies Used:
- C# .NET (Console Application)
- Visual Studio 2022
- Git & GitHub

## 📋 Description:
This application allows the user to:
- Enter a numeric value (e.g., 120)
- Choose a target unit: `kw` or `hp`
- Perform conversion:
  - `HP → kW` using the formula: `kW = HP × 0.745699872`
  - `kW → HP` using the formula: `HP = kW / 0.745699872`

The result is displayed directly in the console.

## ▶️ How to Run:
1. Clone or download the repository
2. Open the solution (`.sln`) file in Visual Studio
3. Build and run the application (press `F5`)
4. Follow the on-screen instructions

## 💡 Example:
Please, enter value:
100
Convert to (enter kw or hp):
kw
Converted result: 74.5699872

## ⚠️ Notes:
- Accepts only valid numeric input
- Converts in both directions (`kw` or `hp`)
- Case-insensitive input handling

---

> This project demonstrates conditional logic, user input validation, and mathematical operations in a C# console application.
