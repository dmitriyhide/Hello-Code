// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
int digitCount = 0;
int tempNumber = anyNumber;

while (tempNumber > 0)
{
    tempNumber /= 10;
    digitCount++;
}

if (digitCount > 2)
{
    int thirdDigit = (anyNumber / (int)Math.Pow(10, digitCount - 3)) % 10;
    Console.WriteLine("третья цифра -> " + thirdDigit);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}