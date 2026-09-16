# Basics of C# 🚀

A hands-on collection of beginner-friendly **C# tutorials** — written as small, self-contained,
single-file programs that you can read in a few minutes and run in one command.

This is a **living repository**: every time I learn something new in C#, another tutorial file
gets added to the `tutorials` folder. More lessons are coming, so this README grows with the project.

---

## 📖 About

Instead of one big console application, each topic lives in its own tiny `.cs` file and uses
C#'s **top-level statements** — no `Main()` method, no boilerplate:

```csharp
Console.WriteLine("Hello World!");
```

That means you can jump straight to the concept you want to learn, run only that file,
and ignore everything else. Every tutorial is independent.

Each file follows the same spirit:

- **One topic per file** — strings, numbers, trimming, replacing, and whatever comes next.
- **Readable output** — values are printed so you can see exactly what the code does.
- **Optional extras** — when a file explores several ideas (like `numbers.cs`), the alternate
  examples are wrapped in local functions you can switch on by uncommenting one line at the top.

---

## ✅ Prerequisites

- **.NET SDK 10.0 or later** — the tutorials run as *file-based apps*, so no project file is needed.
- Any editor — **VS Code** with the **C# Dev Kit** extension is recommended for IntelliSense
  and debugging (this repo was built with it).

Check your SDK version:

```powershell
dotnet --version
```

---

## 📂 Project structure

```text
Cs-Tutorials/
├── README.md
├── hello-world.cs      # Output & string interpolation
├── numbers.cs          # int / double / decimal, math & precision
├── Replace.cs          # Replace, case conversion & searching
└── Trim.cs             # TrimStart / TrimEnd / Trim
```

> New tutorials simply get dropped in alongside the existing ones — the structure stays flat on purpose.

---

## ▶️ How to run a tutorial

Clone the repo, then run any file directly:

```powershell
git clone https://github.com/sazzadul1205/Cs-Tutorials.git
cd Cs-Tutorials
dotnet run hello-world.cs
```

If you keep the files inside a `tutorials` folder locally, run them like this instead:

```powershell
dotnet run tutorials/hello-world.cs
```

No `dotnet build`, no `.csproj`, no `Main()` — `dotnet run` compiles and executes the file in one step.

---

## 📚 Tutorials

| File | Topic | What you'll learn |
| --- | --- | --- |
| [`hello-world.cs`](hello-world.cs) | Hello World & strings | `Console.WriteLine`, string interpolation (`$"..."`), reassigning variables, `.Length` |
| [`numbers.cs`](numbers.cs) | Numbers & math | `int`, `double`, `decimal`, `+ - * /`, order of precedence, integer division & modulus, `int.MaxValue` / `MinValue`, overflow, floating-point vs. decimal precision |
| [`Trim.cs`](Trim.cs) | Trimming whitespace | `Trim()`, `TrimStart()`, `TrimEnd()` |
| [`Replace.cs`](Replace.cs) | Searching & changing strings | `Replace()`, `ToUpper()`, `ToLower()`, `Contains()`, `StartsWith()`, `EndsWith()` |

**Tip:** `numbers.cs` only runs `CalculateAreaOfACircle()` by default. Uncomment any of the other
calls at the top of the file (e.g. `WorkWithIntegers();`) to explore that area — one at a time.

---

## ➕ Adding a new tutorial

Adding a lesson takes about a minute:

1. Create a new file in the repo root, e.g. `Loops.cs` (PascalCase matches the existing naming style).
2. Write top-level statements — optionally with small local functions, just like `numbers.cs`.
3. Run it with `dotnet run Loops.cs` and make sure the output is clear.
4. Add a row to the **Tutorials** table above so others can find it.

There is intentionally **no project file to update** — that keeps contribution friction at zero.

---

## 🗺️ Roadmap

Topics I plan to work through — this list is deliberately open-ended and will keep changing:

- [x] Hello World, output & string interpolation
- [x] Numbers, arithmetic & numeric types
- [x] Trimming whitespace
- [x] Replacing & searching inside strings
- [ ] Conditionals & branching (`if` / `switch`)
- [ ] Loops (`for`, `while`, `foreach`)
- [ ] Arrays, `List<T>` and other collections
- [ ] Methods, parameters & return values
- [ ] Classes, structs & records (OOP basics)
- [ ] Interfaces, inheritance & polymorphism
- [ ] Exception handling
- [ ] File input/output
- [ ] LINQ
- [ ] `async` / `await`
- [ ] Generics
- [ ] …and more as I keep learning

---

## 🤝 Contributing & feedback

This is a learning repository, but corrections, extra examples and suggestions are always welcome.
Feel free to open an **issue** or submit a **pull request** — if you spot a better way to explain a
concept, that is exactly the kind of feedback that helps.

---

## 📄 License

No license has been added yet. If you'd like to reuse this code, open an issue and one can be added
(e.g. MIT).

---

## 👤 Author

**Sazzadul Islam** — [github.com/sazzadul1205](https://github.com/sazzadul1205)

If these tutorials helped you, a ⭐ on the repo is appreciated. Happy coding! 🎉
