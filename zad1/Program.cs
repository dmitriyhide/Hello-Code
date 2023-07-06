// Напишите программу, которая на вход принимает два числа и выдаёт
// какое число большее, а какое меньшее.

// Например:
// a = 5, b = 7 -> max = 7
// a = 2, b = 10 -> max = 10
// a = -9, b = -3 -> max = -3

int max = 0;

Console.WriteLine("Введите два числа: ");
int num1 = Int32.Parse(Console.ReadLine());
int num2 = Int32.Parse(Console.ReadLine());

if(num1 > num2)
{
    max = num1;
}
else
{
    max = num2;
}
Console.WriteLine($"Вот и ответ {max}");