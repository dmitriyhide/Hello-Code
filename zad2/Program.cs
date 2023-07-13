// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

// Например:
// 2,3,7 -> 7
// 44,5,78 -> 78
// 22,3,9 -> 22


Console.WriteLine("Введите три числа: ");
int num1 = Int32.Parse(Console.ReadLine());
int num2 = Int32.Parse(Console.ReadLine());
int num3 = Int32.Parse(Console.ReadLine());
int max = num1; // или int max = int.MinValue;

if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine($"Вот и ответ {max}");