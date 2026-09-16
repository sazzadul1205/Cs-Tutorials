// WorkWithIntegers();
// OrderPrecedence();
// IntegerDivision();
// IntegerRange();
// IntegerOverflow();
WorkWithDoubles();
DoubleDivision();
DoubleRange();
DoublePrecision();

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;

    Console.WriteLine($"Addition: {a + b}");
    Console.WriteLine($"Subtraction: {a - b}");
    Console.WriteLine($"Multiplication: {a * b}");
    Console.WriteLine($"Division: {a / b}");
}

void WorkWithDoubles()
{
    double a = 18;
    double b = 6;

    Console.WriteLine($"Addition: {a + b}");
    Console.WriteLine($"Subtraction: {a - b}");
    Console.WriteLine($"Multiplication: {a * b}");
    Console.WriteLine($"Division: {a / b}");
}

void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;

    Console.WriteLine(a + b * c);
    Console.WriteLine((a + b) * c);
    Console.WriteLine((a + b) - 6 * c + (12 * 4) / 3 + 12);
}

void IntegerDivision()
{
    int a = 7;
    int b = 4;
    int c = 3;

    int quotient = (a + b) / c;
    int remainder = (a + b) % c;

    Console.WriteLine($"Quotient: {quotient}");
    Console.WriteLine($"Remainder: {remainder}");
}

void IntegerRange()
{
    int max = int.MaxValue;
    int min = int.MinValue;

    Console.WriteLine($"The range of integers is {min} to {max}");
}

void IntegerOverflow()
{
    int max = int.MaxValue;
    int overflow = max + 3;

    Console.WriteLine($"An example of overflow: {overflow}");
}

void DoubleDivision()
{
    double a = 5;
    double b = 4;
    double c = 2;

    double result = (a + b) / c;

    Console.WriteLine($"Result: {result}");
}

void DoubleDivisionExample()
{
    double a = 19;
    double b = 23;
    double c = 8;

    double result = (a + b) / c;

    Console.WriteLine($"Result: {result}");
}

void DoubleRange()
{
    double max = double.MaxValue;
    double min = double.MinValue;

    Console.WriteLine($"The range of double is {min} to {max}");
}

void DoublePrecision()
{
    double third = 1.0 / 3.0;

    Console.WriteLine($"1 / 3 = {third}");
}
