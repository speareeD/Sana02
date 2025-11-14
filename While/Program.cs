uint n;
double a = 0, b = 0, c = 0;
Console.Write("Enter n: ");
n = uint.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    a += Math.Pow(-1, i) / (2 * i + 1);
}
Console.WriteLine($"a = {a}");
