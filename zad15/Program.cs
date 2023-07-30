// Задача 36: Задайте одномерный массив заполненный случайными
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10];

void Fill(int[] numbers)
{
    int n = numbers.Length;
    int i = 0;
    while (i < n)
    {
        numbers[i] = new Random().Next(50);
        i++;
    }
}

void Print(int[] nums)
{
    int n = nums.Length;
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
        summa += array[i];
        i = i + 2;
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {summa}");
}

Fill(array);
Print(array);
Console.WriteLine();
sum();