// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите значение М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"M={M}, N={N}");
int sum = 0;
if(N>M)
{
    for (int i = M; i <= N; i++)
    {
        sum = sum + i;
    }
}
else
for (int i = N; i <= M; i++)
{
    sum = sum + i;
}
Console.Write(sum);