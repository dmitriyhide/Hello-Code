// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int size = 4;
int[,] spiralArray = new int[size, size];

int rowStart = 0;
int rowEnd = size - 1;
int colStart = 0;
int colEnd = size - 1;

int counter = 1;

while (rowStart <= rowEnd && colStart <= colEnd)
{
    // Заполнение верхнего горизонтального ряда
    for (int i = colStart; i <= colEnd; i++)
    {
        spiralArray[rowStart, i] = counter++;
    }
    rowStart++;

    // Заполнение правого вертикального столбца
    for (int i = rowStart; i <= rowEnd; i++)
    {
        spiralArray[i, colEnd] = counter++;
    }
    colEnd--;

    // Заполнение нижнего горизонтального ряда
    if (rowStart <= rowEnd)
    {
        for (int i = colEnd; i >= colStart; i--)
        {
            spiralArray[rowEnd, i] = counter++;
        }
        rowEnd--;
    }

    // Заполнение левого вертикального столбца
    if (colStart <= colEnd)
    {
        for (int i = rowEnd; i >= rowStart; i--)
        {
            spiralArray[i, colStart] = counter++;
        }
        colStart++;
    }
}

// Вывод спирального массива
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write($"{spiralArray[i, j]:D2} ");
    }
    Console.WriteLine();
}
