// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[15];

void Fill(int[] numbers)
{
    int n = numbers.Length;
    int i = 0;
    while (i < n)
    {
        numbers[i] = new Random().Next(100, 1000);
        i++;
    }
}

void Print(int[] nums)
{
    int n = numbers.Length;
    int i = 0;
    while (i < n)
    {
        Console.Write(nums[i] + " ");
        i++;
    }
}

void sum()
{
    int n = args.Length;
    int i = 0;
    int summa = 0;
    while (i < n)
    {
        if (args[i] % 2 == 0)
        {
            summa += 1;
        }
        i++;
    }
    Console.WriteLine($"Количество чётных чисел в массиве : {summa}");
}

Fill(array);
Print(array);
Console.WriteLine();
sum();
