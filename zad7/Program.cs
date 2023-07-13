// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// Например:
// 6 -> Да 
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 5)
{
    Console.WriteLine("Нет");
}
else if (number == 6)
{
    Console.WriteLine("Да");
}
else if (number == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}