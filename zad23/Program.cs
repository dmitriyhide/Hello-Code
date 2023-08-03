// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

int[,] nums = new int[4, 4];

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        nums[i, j] = new Random().Next(0, 10);
    }
}

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}

int minSumLine = 0;
int sumLine = SumLineElements(nums, 0);
for (int i = 1; i < nums.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(nums, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

int SumLineElements(int[,] nums, int i)
{
  int sumLine = nums[i,0];
  for (int j = 1; j < nums.GetLength(1); j++)
  {
    sumLine += nums[i,j];
  }
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] nums)
{
  for (int i = 0; i < nums.GetLength(0); i++)
  {
    for (int j = 0; j < nums.GetLength(1); j++)
    {
      nums[i, j] = new Random().Next(0, 10);
    }
  }
}

void WriteArray (int[,] nums)
{
  for (int i = 0; i < nums.GetLength(0); i++)
  {
    for (int j = 0; j < nums.GetLength(1); j++)
    {
      Console.Write(nums[i,j] + " ");
    }
    Console.WriteLine();
  }
}