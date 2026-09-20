# Basics of C# 🚀

A hands-on collection of beginner-friendly **C# tutorials** — written as small, self-contained,
single-file programs that you can read in a few minutes and run in one command.

This is a **living repository**: every time I learn something new in C#, another tutorial file
gets added to the `tutorials` folder. More lessons are coming, so this README grows with the project.

---

## 📖 About

Instead of one big console application, each topic lives in its own tiny `.cs` file. Files in the
repo root cover one language feature each, while the `OOP-Concept/` sub-folder walks through
**object-oriented programming** one numbered lesson at a time.

Most root-level files use C#'s **top-level statements** — no `Main()` method, no boilerplate:

```csharp
Console.WriteLine("Hello World!");
```

That means you can jump straight to the concept you want to learn, run only that file,
and ignore everything else. Every tutorial is independent.

A few of the newer files (`DataTypes.cs`, `IfElse.cs`) and **every file in `OOP-Concept/`** instead
use the **classic console structure** — `namespace`, `class Program` and
`static void Main(string[] args)` — so you can see both styles side by side. The OOP lessons go one
step further and declare the classes they demonstrate right next to the entry point (for example
`class MyClass` plus `class ClassObject` in a single file), because that is the only way to show
classes, inheritance and interfaces. They all still run the exact same way with `dotnet run`:

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
- **Numbered OOP lessons** — files in `OOP-Concept/` are prefixed `1.` … `15.` so you can read them
  in order, and each one builds on the concept before it.

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
├── .kilo/                          # Kilo Code agent worktrees — local tooling, excluded from git
├── .vscode/
│   └── settings.json               # cSpell dictionary used while writing the samples
├── OOP-Concept/                    # 15 numbered OOP lessons (classic class + Main style)
│   ├── 1. Class-Object.cs          # class, object & calling a method
│   ├── 2. Field-Method.cs          # fields (data) vs. methods (behaviour)
│   ├── 3. properties.cs            # auto-properties with get / set
│   ├── 4. Constructors.cs          # a constructor runs when the object is created
│   ├── 5. ConstructorOverloading.cs
│   ├── 6. MethodOverloading.cs     # same method name, different parameter lists
│   ├── 7. Encapsulation.cs         # private field behind a public property
│   ├── 8. Inheritance.cs           # `class Anna : Person`
│   ├── 9. Virtual-Override.cs      # `virtual` / `override`
│   ├── 10. Static-Instance.cs      # `static` members vs. instance members
│   ├── 11. Polymorphism.cs         # one variable type, many behaviours
│   ├── 12. Abstraction.cs          # abstract class & abstract method
│   ├── 13. Interfaces.cs           # interface & implementation
│   ├── 14. ValueTypes.cs           # value types (int, float, double, decimal, bool, char)
│   └── 15. ReferenceType.cs        # two variables, one object on the heap
├── branches-loops.cs    # if/else, while, do-while, for & nested loops
├── DataTypes.cs         # int, long, float, double, bool, char & string
├── hello-world.cs       # Output & string interpolation
├── IfElse.cs            # if/else starter (classic class + Main style)
├── lists.cs             # List<T>, collection expressions & Fibonacci
├── numbers.cs           # int / double / decimal, math & precision
├── patterns.cs          # switch expressions & pattern matching
├── ReferenceTypes.cs    # class, string, object & array as reference types
├── Replace.cs           # Replace, case conversion & searching
├── Trim.cs              # TrimStart / TrimEnd / Trim
└── tuples.cs            # Value tuples, named tuples & records
```

> New tutorials simply get dropped in alongside the existing ones — the root stays flat on purpose.
> Anything that grows into its own lesson series gets a folder like `OOP-Concept/`, where the files
> are numbered so the reading order is obvious.

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

The same command works for the OOP lessons — just quote the path, because those file names contain
spaces:

```powershell
dotnet run "tutorials/OOP-Concept/1. Class-Object.cs"
```

No `dotnet build`, no `.csproj`, no `Main()` — `dotnet run` compiles and executes the file in one step.

This works for **both styles** used in the repo: the top-level statement files (`hello-world.cs`) and
the classic entry-point files (`DataTypes.cs`, `IfElse.cs` and every file in `OOP-Concept/`) that
declare their own `static void Main`. You can also run the code straight from inside VS Code with
the C# Dev Kit **Run** button.

> ℹ️ Only ever run **one** file from `OOP-Concept/` at a time: each lesson declares its own `Main`,
> so compiling the folder as a single project would report multiple entry points. `dotnet run` on a
> single file is exactly the right tool here.

---

## 📚 Tutorials

| File | Topic | What you'll learn |
| --- | --- | --- |
| [`hello-world.cs`](hello-world.cs) | Hello World & strings | `Console.WriteLine`, string interpolation (`$"..."`), reassigning variables, `.Length` |
| [`DataTypes.cs`](DataTypes.cs) | Data types | Declaring the built-in types — `int`, `long` (the `L` suffix), `float` (the `F` suffix), `double` (the `D` suffix), `bool` (`true` / `false`), `char` (single quotes) and `string` (double quotes) — inside a classic `namespace` + `class Program` + `static void Main` entry point |
| [`numbers.cs`](numbers.cs) | Numbers & math | `int`, `double`, `decimal`, `+ - * /`, order of precedence, integer division & modulus, `int.MaxValue` / `MinValue`, overflow, floating-point vs. decimal precision |
| [`ReferenceTypes.cs`](ReferenceTypes.cs) | Reference types | Four reference types side by side — a `class` (`new Person()`), a `string`, an `object` boxed with `100`, and an `int[]` array — printing one value from each |
| [`Trim.cs`](Trim.cs) | Trimming whitespace | `Trim()`, `TrimStart()`, `TrimEnd()` |
| [`Replace.cs`](Replace.cs) | Searching & changing strings | `Replace()`, `ToUpper()`, `ToLower()`, `Contains()`, `StartsWith()`, `EndsWith()` |
| [`branches-loops.cs`](branches-loops.cs) | Branching & loops | `if` / `else`, `&&` and `\|\|`, `while`, `do`…`while`, `for`, nested loops, `%` and a small "sum the multiples of 3" challenge |
| [`IfElse.cs`](IfElse.cs) | `if` / `else` (starter) | A bare-bones classic `class Program` + `static void Main` file that declares `int a = 20;` and `int b = 40;` and opens an `if (a > b)` block — the empty body is the next thing to fill in, so this one currently prints nothing. See `branches-loops.cs` for the finished version |
| [`tuples.cs`](tuples.cs) | Tuples & records | Value tuples, named tuple elements, tuple mutation, non-destructive `with` expressions, positional `record` types and adding methods to a record |
| [`lists.cs`](lists.cs) | Lists & collections | `List<T>`, collection expressions (`["Alice", "Bob"]`), `foreach`, `Add()` / `Remove()`, indexing and `Count`, `IndexOf()` (returns `-1` when missing), `Sort()`, plus a Fibonacci challenge |
| [`patterns.cs`](patterns.cs) | Pattern matching & switch expressions | Raw string literals (`"""`), `StringReader` + `yield return` in an `IEnumerable<T>` method, `double.TryParse()`, `switch` expressions with type patterns (`Deposit d => …`), records as pattern targets, and tuple results from a `switch` |

**Tip:** `numbers.cs`, `branches-loops.cs`, `tuples.cs` and `lists.cs` each run only **one** example by
default — `CalculateAreaOfACircle()`, `Challenge()`, `WorkWithRecords()` and `Challenge()` respectively.
The other examples are listed as comments at the top of each file; uncomment one at a time
(e.g. `WorkWithIntegers();` or `WorkWithWhile();`) to explore that area. The extra examples are local
functions, so the ones you leave commented out can produce a harmless `CS8321` "declared but never
used" warning.

**New here? Start with these three in order:** `hello-world.cs` → `DataTypes.cs` → `IfElse.cs`.
Once those feel comfortable, continue with [`OOP-Concept/1. Class-Object.cs`](<OOP-Concept/1. Class-Object.cs>)
and work through the numbered lessons in the section below.

---

## 🧱 OOP Concepts (`OOP-Concept/`)

Everything about **object-oriented programming** lives in the `OOP-Concept/` sub-folder. Each lesson
is a standalone file that defines its own classes next to its own `static void Main`, so it runs with
the same `dotnet run` command as the root files — just quote the path, because those file names
contain spaces:

```powershell
dotnet run "OOP-Concept/1. Class-Object.cs"
```

Read them in order — every lesson only uses ideas from the lessons before it:

| # | File | Topic | What you'll learn |
| --- | --- | --- | --- |
| 1 | [`1. Class-Object.cs`](<OOP-Concept/1. Class-Object.cs>) | Class & object | `class MyClass` as the blueprint, `new MyClass()` to create an object, and calling a method on it (`myClass1.Hello()` → `Hello Everyone!`) |
| 2 | [`2. Field-Method.cs`](<OOP-Concept/2. Field-Method.cs>) | Fields & methods | Public fields (`string Name`, `int Age`) as the data, a method (`Hi()`) as the behaviour, and two independent objects (`Pritom` / 25 and `Sazzadul` / 30) keeping their own values |
| 3 | [`3. properties.cs`](<OOP-Concept/3. properties.cs>) | Properties | Auto-properties (`public string Name { get; set; }`) instead of fields — `get` reads the value, `set` writes it |
| 4 | [`4. Constructors.cs`](<OOP-Concept/4. Constructors.cs>) | Constructors | A constructor (`public MyClass(string name)`) that runs the moment an object is created, and `new MyClass("Pritom")` to pass data straight in |
| 5 | [`5. ConstructorOverloading.cs`](<OOP-Concept/5. ConstructorOverloading.cs>) | Constructor overloading | Three `Person` constructors — `Person()`, `Person(string name)` and `Person(string name, int age)` — chosen by the arguments you pass (`Unknown` / 0, `Pritom` / 0, `Pritom` / 20) |
| 6 | [`6. MethodOverloading.cs`](<OOP-Concept/6. MethodOverloading.cs>) | Method overloading | One `Calculator` with `Add(int, int)`, `Add(int, int, int)` and `Add(double, double)` — same name, different parameter lists, different return types (prints `11`, `18`, `11.8`) |
| 7 | [`7. Encapsulation.cs`](<OOP-Concept/7. Encapsulation.cs>) | Encapsulation | A `private string name` that only the class itself can touch, exposed through a public property with explicit `get { return name; }` / `set { name = value; }` |
| 8 | [`8. Inheritance.cs`](<OOP-Concept/8. Inheritance.cs>) | Inheritance | `class Anna : Person` — `Anna` inherits `Name()` from the base class and adds its own `Age()` |
| 9 | [`9. Virtual-Override.cs`](<OOP-Concept/9. Virtual-Override.cs>) | `virtual` & `override` | A base method marked `virtual` and replaced in the derived class with `override` (`Hello` → `Hello Anna!`) |
| 10 | [`10. Static-Instance.cs`](<OOP-Concept/10. Static-Instance.cs>) | Static vs. instance | `person.HelloInstance()` needs an object to exist, while `Person.HelloStatic()` is called on the class itself |
| 11 | [`11. Polymorphism.cs`](<OOP-Concept/11. Polymorphism.cs>) | Polymorphism | One `Person` variable type holding two different objects (`Anna`, `James`), each overriding `Name()` — the object decides which version runs |
| 12 | [`12. Abstraction.cs`](<OOP-Concept/12. Abstraction.cs>) | Abstraction | An `abstract class Person` with an `abstract void Name();` (no body), and `Anna` supplying the actual implementation |
| 13 | [`13. Interfaces.cs`](<OOP-Concept/13. Interfaces.cs>) | Interfaces | `interface IPerson { void Name(); }` as a contract, with `class Anna : IPerson` fulfilling it |
| 14 | [`14. ValueTypes.cs`](<OOP-Concept/14. ValueTypes.cs>) | Value types | The value types printed one per line — `int`, `float` (`f` suffix), `double`, `decimal` (`m` suffix), `bool`, `char` |
| 15 | [`15. ReferenceType.cs`](<OOP-Concept/15. ReferenceType.cs>) | Reference types | `Person p2 = p1;` copies the *reference*, not the object — so setting `p2.Name = "Bob"` also changes `p1.Name`, and **both** print `Bob` |

**Tip:** the lesson files are deliberately tiny. Lesson 15 is the one worth sitting with — it is the
classic "why did my other object change too?" surprise, and it is why `ReferenceTypes.cs` in the repo
root exists as a companion (four different reference types, one value each).

**Notes on warnings:** lessons 2, 3, 7 and 15 declare non-nullable fields or properties that are not
assigned in a constructor, so the compiler prints a harmless

```text
warning CS8618: Non-nullable field 'Name' must contain a non-null value when exiting constructor.
```

The programs still run correctly. Adding `= string.Empty;` or the `required` modifier would silence
it — it is left as is so the lesson stays focused on the OOP keyword being taught.

---

## ➕ Adding a new tutorial

Adding a lesson takes about a minute:

1. Create a new file in the repo root — either PascalCase (`DataTypes.cs`) or lowercase/kebab-case
   (`branches-loops.cs`), matching the mix of styles already in the repo. If the lesson belongs to a
   series like the OOP lessons, put it in that folder instead and number it:
   `OOP-Concept/16. Structs.cs`.
2. Write top-level statements — optionally with small local functions, just like `numbers.cs`. If you
   prefer, you can also use the full `namespace` + `class Program` + `static void Main` form, like
   `DataTypes.cs`, or follow the `OOP-Concept/` lessons if you need to declare extra classes right
   next to the entry point.
3. Run it with `dotnet run Loops.cs` and make sure the output is clear. Quote the path when it
   contains spaces: `dotnet run "OOP-Concept/16. Structs.cs"`.
4. Add a row to the matching table above — **Tutorials** for root-level files, **OOP Concepts** for
   the `OOP-Concept/` lessons — and update the project structure tree so others can find it.

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
- [x] Reference types vs. value types (`ReferenceTypes.cs`, `OOP-Concept/14. ValueTypes.cs` & `15. ReferenceType.cs`)
- [x] Classes & objects, fields, methods and properties (`OOP-Concept/1` – `3`)
- [x] Constructors & constructor overloading (`OOP-Concept/4` – `5`)
- [x] Method overloading (`OOP-Concept/6. MethodOverloading.cs`)
- [x] Encapsulation — private field behind a public property (`OOP-Concept/7. Encapsulation.cs`)
- [x] Inheritance and `virtual` / `override` (`OOP-Concept/8` – `9`)
- [x] `static` vs. instance members (`OOP-Concept/10. Static-Instance.cs`)
- [x] Polymorphism (`OOP-Concept/11. Polymorphism.cs`)
- [x] Abstraction (abstract classes) & interfaces (`OOP-Concept/12` – `13`)
- [ ] Finish `IfElse.cs` — `else` / `else if` chains and nested conditions
- [ ] A dedicated root lesson for methods, parameters & return values (currently only used inside `OOP-Concept/6. MethodOverloading.cs`)
- [ ] Structs & enums — the OOP idea not covered yet
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
