// Напишите программу, которая на вход принимает число (N)
// а на выходе показывает все чётные числа от 1 до N.

// Например:
// 5 -> 2,4
// 8 -> 2,4,6,8

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int n = 2;

// if (number > 1)
// {
//     while (n <= number)
//     {
//         Console.WriteLine(n + " ");
//         n = n + 2;
//     }
// }

// или

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= n; i += 2)
{
    Console.Write(i + " ");
}