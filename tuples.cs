
// WorkWithTuples();
// WorkWithNamedTuples();
WorkWithRecords();

void WorkWithTuples()
{
    var pt = (X: 1, Y: 2);

    var slope = pt.Y / pt.X;

    Console.WriteLine(
        $"A line from the origin to the point {pt} has a slope of {slope}."
    );

    pt.X = pt.X + 5;

    Console.WriteLine($"The point is now at {pt}.");

    var pt2 = pt with { Y = 10 };

    Console.WriteLine($"The point 'pt2' is at {pt2}.");

    var subscript = (A: 0, B: 0);

    subscript = pt;

    Console.WriteLine(subscript);
}

void WorkWithNamedTuples()
{
    var namedData = (
        Name: "Morning observation",
        Temp: 17,
        Wind: 4
    );

    var person = (
        FirstName: "",
        LastName: ""
    );

    var order = (
        Product: "guitar picks",
        Style: "triangle",
        Quantity: 500,
        UnitPrice: 0.10m
    );

    Console.WriteLine(namedData);
    Console.WriteLine(person);
    Console.WriteLine(order);
}

void WorkWithRecords()
{
    Point pt3 = new Point(1, 1);

    var pt4 = pt3 with { Y = 10 };

    Console.WriteLine($"The two points are {pt3} and {pt4}");

    double slopeResult = pt4.Slope();

    Console.WriteLine($"The slope of {pt4} is {slopeResult}");
}

public record Point(int X, int Y)
{
    public double Slope() => (double)Y / X;
}

