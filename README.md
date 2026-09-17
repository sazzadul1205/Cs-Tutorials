# Basics of C# 🚀

A hands-on collection of beginner-friendly **C# tutorials** — written as small, self-contained,
single-file programs that you can read in a few minutes and run in one command.

This is a **living repository**: every time I learn something new in C#, another tutorial file
gets added to the `tutorials` folder. More lessons are coming, so this README grows with the project.

---

## 📖 About

Instead of one big console application, each topic lives in its own tiny `.cs` file. Most files use
C#'s **top-level statements** — no `Main()` method, no boilerplate:

```csharp
Console.WriteLine("Hello World!");
```

That means you can jump straight to the concept you want to learn, run only that file,
and ignore everything else. Every tutorial is independent.

A few of the newer files (`DataTypes.cs`, `IfElse.cs`) instead use the **classic console
structure** — `namespace`, `class Program` and `static void Main(string[] args)` — so you can see
both styles side by side. They still run the exact same way with `dotnet run`:

```csharp
namespace DataTypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Baby");
        }
    }
}
```

Each file follows the same spirit:

- **One topic per file** — strings, data types, numbers, trimming, replacing, and whatever comes next.
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
├── branches-loops.cs    # if/else, while, do-while, for & nested loops
├── DataTypes.cs         # int, long, float, double, bool, char & string
├── hello-world.cs       # Output & string interpolation
├── IfElse.cs            # if/else starter (classic class + Main style)
├── lists.cs             # List<T>, collection expressions & Fibonacci
├── numbers.cs           # int / double / decimal, math & precision
├── patterns.cs          # switch expressions & pattern matching
├── Replace.cs           # Replace, case conversion & searching
├── Trim.cs              # TrimStart / TrimEnd / Trim
└── tuples.cs            # Value tuples, named tuples & records
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

This works for **both styles** used in the repo: the top-level statement files (`hello-world.cs`) and
the classic entry-point files (`DataTypes.cs`, `IfElse.cs`) that declare their own `static void Main`.
You can also run the code straight from inside VS Code with the C# Dev Kit **Run** button.

---

## 📚 Tutorials

| File | Topic | What you'll learn |
| --- | --- | --- |
| [`hello-world.cs`](hello-world.cs) | Hello World & strings | `Console.WriteLine`, string interpolation (`$"..."`), reassigning variables, `.Length` |
| [`DataTypes.cs`](DataTypes.cs) | Data types | Declaring the built-in types — `int`, `long` (the `L` suffix), `float` (the `F` suffix), `double` (the `D` suffix), `bool` (`true` / `false`), `char` (single quotes) and `string` (double quotes) — inside a classic `namespace` + `class Program` + `static void Main` entry point |
| [`numbers.cs`](numbers.cs) | Numbers & math | `int`, `double`, `decimal`, `+ - * /`, order of precedence, integer division & modulus, `int.MaxValue` / `MinValue`, overflow, floating-point vs. decimal precision |
| [`Trim.cs`](Trim.cs) | Trimming whitespace | `Trim()`, `TrimStart()`, `TrimEnd()` |
| [`Replace.cs`](Replace.cs) | Searching & changing strings | `Replace()`, `ToUpper()`, `ToLower()`, `Contains()`, `StartsWith()`, `EndsWith()` |
| [`branches-loops.cs`](branches-loops.cs) | Branching & loops | `if` / `else`, `&&` and `\|\|`, `while`, `do`…`while`, `for`, nested loops, `%` and a small "sum the multiples of 3" challenge |
| [`IfElse.cs`](IfElse.cs) | `if` / `else` (starter) | A bare-bones classic `class Program` + `static void Main` file that declares `int a = 20;` and `int b = 40;` and opens an `if (a > b)` block — the empty body is the next thing to fill in, so this one currently prints nothing. See `branches-loops.cs` for the finished version |
| [`tuples.cs`](tuples.cs) | Tuples & records | Value tuples, named tuple elements, tuple mutation, non-destructive `with` expressions, positional `record` types and adding methods to a record |
| [`lists.cs`](lists.cs) | Lists & collections | `List<T>`, collection expressions (`["Alice", "Bob"]`), `foreach`, `Add()` / `Remove()`, indexing and `Count`, `IndexOf()` (returns `-1` when missing), `Sort()`, plus a Fibonacci challenge |
| [`patterns.cs`](patterns.cs) | Pattern matching & switch expressions | Raw string literals (`"""`), `StringReader` + `yield return` in an `IEnumerable<T>` method, `double.TryParse()`, `switch` expressions with type patterns (`Deposit d => …`), records as pattern targets, and tuple results from a `switch` |

**Tip:** `numbers.cs`, `branches-loops.cs`, `tuples.cs` and `lists.cs` each run only **one** example by default.
Uncomment any of the other calls at the top of the file (e.g. `WorkWithIntegers();` or
`WorkWithWhile();`) to explore that area — one at a time. The extra examples are local functions,
so the ones you leave commented out can produce a harmless `CS8321` "declared but never used" warning.

**New here? Start with these three in order:** `hello-world.cs` → `DataTypes.cs` → `IfElse.cs`.

---

## ➕ Adding a new tutorial

Adding a lesson takes about a minute:

1. Create a new file in the repo root — either PascalCase (`DataTypes.cs`) or lowercase/kebab-case
   (`branches-loops.cs`), matching the mix of styles already in the repo.
2. Write top-level statements — optionally with small local functions, just like `numbers.cs`. If you
   prefer, you can also use the full `namespace` + `class Program` + `static void Main` form, like
   `DataTypes.cs`.
3. Run it with `dotnet run Loops.cs` and make sure the output is clear.
4. Add a row to the **Tutorials** table above so others can find it.

There is intentionally **no project file to update** — that keeps contribution friction at zero.

---

## 🗺️ Roadmap

Topics I plan to work through — this list is deliberately open-ended and will keep changing:

- [x] Hello World, output & string interpolation
- [x] Built-in data types (`int`, `long`, `float`, `double`, `bool`, `char`, `string`)
- [x] Numbers, arithmetic & numeric types
- [x] Trimming whitespace
- [x] Replacing & searching inside strings
- [x] Branching (`if` / `else`, `&&`, `||`)
- [x] Loops (`while`, `do`…`while`, `for`, nested loops)
- [x] Tuples & records (named tuples, `with` expressions, positional records)
- [x] `switch` expressions & pattern matching
- [x] Arrays, `List<T>` and other collections
- [x] `foreach` over collections
- [x] `yield return` (first used inside `patterns.cs`)
- [ ] Finish `IfElse.cs` — `else` / `else if` chains and nested conditions
- [ ] Methods, parameters & return values
- [ ] Classes, structs & interfaces (OOP basics)
- [ ] Inheritance & polymorphism
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
