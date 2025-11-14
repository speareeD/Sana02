using System.Net.Http.Headers;

double a, b, c, x, x1, x2;

Console.WriteLine("Quadratic equation (ax^2 + bx + c = 0)");

Console.Write("Enter a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Enter b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Enter c: ");
c = double.Parse(Console.ReadLine());

if (a == 0)
{
    if (b == 0)
    {
        if (c == 0)
        {
            Console.WriteLine("Equation has a multitude of solutions");
        }
        else
        {
            Console.WriteLine("Equation has no solutions");
        }
    }
    else
    {
        x = -(c / b);
        Console.WriteLine("X = " + x);
    }
}
else
{
    double d = Math.Sqrt(b * b - 4 * a * c);
    if (d > 0)
    {
        x1 = (-b + d) / (2 * a);
        x2 = (-b - d) / (2 * a);
        Console.WriteLine($"x1 = {x1}, x2 = {x2}");
    } else if(d == 0)
    {
        x = -b / (2 * a);
        Console.WriteLine($"x = {x}");
    } else
    {
        Console.WriteLine("Equation has no solutions");
    }
}