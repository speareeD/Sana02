int sum = 0;
Console.WriteLine("Enter 5 grades (0-100): ");
for (int i = 1; i <= 5; i++)
{
    Console.Write($"Enter {i} grade: ");
    sum += int.Parse(Console.ReadLine());
}
int average = sum / 5;

if(average >= 50)
{
    Console.WriteLine($"You are able to go to exam! Your average score is: {average}");
} else
{
    Console.WriteLine($"You can't go to exam. Your average grade is too low: {average}");
}
