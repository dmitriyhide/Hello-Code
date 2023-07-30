// Задача 38: Задайте  массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[10];

void Fill(double[] numbers)
{
    int n = numbers.Length;
    int i = 0;
    while (i < n)
    {
        numbers[i] = Math.Round(new Random().NextDouble() * 100, 2);
        i++;
    }
}

void Print(double[] nums)
{
    int n = numbers.Length;
    int i = 0;
    while (i < n)
    {
        Console.Write(nums[i] + "   ");
        i++;
    }
}

void MinMax()
{
    int i = 1;
    int n = array.Length;
    double min = array[0];
    double max = array[0];

    while (i < n)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
        i++;
    }
    Console.WriteLine($"Минимальный элемент массива: {min}");
    Console.WriteLine($"Максимальный элемент массива: {max}");
}

Fill(array);
Print(array);
Console.WriteLine();
MinMax();