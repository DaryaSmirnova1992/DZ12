// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("Введите значение М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"M={M}, N={N}");
if(N>M)
{
    for (int i = M; i < N; i++)
    {
        Console.Write($"{i + ", "}");
    }
}
else
for (int i = N; i < M; i++)
{
    Console.Write($"{i + ", "}");
}