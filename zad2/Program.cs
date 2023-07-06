// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

// Например:
// 2,3,7 -> 7
// 44,5,78 -> 78
// 22,3,9 -> 22

int max = 0;

Console.WriteLine("Введите три числа: ");
int num1 = Int32.Parse(Console.ReadLine());
int num2 = Int32.Parse(Console.ReadLine());
int num3 = Int32.Parse(Console.ReadLine());

if (num1 > num2)
{
    max = num1;
}
else
{
    max = num1;
}
if (num2 > num1)
{
    max = num2;
}
else
{
    max = num2;
}
if (num2 > num3)
{
    max = num3;
}
else
{
    max = num3;
}
Console.WriteLine($"Вот и ответ {max}");