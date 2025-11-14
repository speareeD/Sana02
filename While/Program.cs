uint n;
double a = 0, b = 0, c = 0;
Console.Write("Enter n: ");
n = uint.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    a += Math.Pow(-1, i) / (2.0 * i + 1);
}

for(int i = 1; i <= n; i++)
{
    b += 1 + (1.0 / Math.Pow(i, 2));
}

Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");