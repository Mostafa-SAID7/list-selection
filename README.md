# 📋 List Selection Program in C#

This is a simple yet functional C# console application that lets users manage a list of numbers through a text-based menu. It supports adding, displaying, sorting, and analyzing numeric data.

---

## 🔍 Overview

### 🔁 Control Flow Structures Used

- while loop
- switch statement
- if / else statements
- for loops

### 🛠️ Methods and Functions Used

- Console.WriteLine() / Console.Write()
- Console.ReadLine()
- Convert.ToInt32(string)
- List<int> from System.Collections.Generic

### Supports methods such as:

- Add() – adds a number to the list.
- Clear() – empties the list.
- Count – gets the current number of items.
- Contains() – checks for duplicates.

> ⚠️ Built-in LINQ methods such as `.Sort()`, `.Min()`, `.Max()`, `.Avg()`, and `.Find()` are **not used** — all logic is implemented manually.

---

## 🎯 Features

- `P` - **Print numbers** in the list
- `A` - **Add a number** (prevents duplicates)
- `M` - **Calculate mean** of the list
- `S` - **Find smallest** number
- `L` - **Find largest** number
- `F` - **Find a number** by value and display its index
- `C` - **Clear the list**
- `T` - **Toggle sort order** (Ascending / Descending)
- `D` - **Display current sort order**
- `Q` - **Quit** the application

---

## 🚀 How to Run

### Run via .NET CLI:

```bash
git clone https://github.com/Mostafa-SAID7/list-selection.git
cd list-selection
dotnet run
```
You can also run it from Visual Studio or Visual Studio Code by opening the folder and pressing F5 or using the terminal.

### 💡 Learning Goals
This project helps you:

- ✅ Practice list manipulation in C#
- ✅ Implement manual sorting (bubble sort logic)
- ✅ Handle user input using switch-case statements
- ✅ Think algorithmically about calculating mean, minimum, and maximum without built-ins

### 🧩 Potential Add-ons
Consider adding the following to enhance the project:

- 🔁 Swap two elements by index
- ↩️ Undo the last action (add or remove)
- 💾 Save/load list from a file
- 🖼️ Create a GUI version using WinForms or WPF
- 📤 Export the list to a .csv or .json file

### 🛠 Requirements

- .NET 6.0 SDK or later
- An IDE or editor such as:
- Visual Studio
- Visual Studio Code (with the C# extension)
- Or a simple terminal for running with dotnet run

### 📝 How to Use This README
To integrate this documentation into your GitHub project:
In your project root directory, create a file named README.md.
Copy and paste all of this text into that file.
Save the file.

Commit and push it to your GitHub repository using the following commands:
```
git add README.md
git commit -m "Add full project documentation"
git push origin main
```
Once pushed, GitHub will automatically render the README.md on the repository homepage.

### 👤 Author
Mostafa SAID

### 📄 License
This project is licensed under the MIT License.

