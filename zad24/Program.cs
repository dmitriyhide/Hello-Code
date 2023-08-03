// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Задаем размеры матриц

// Задаем размеры матриц
int rowsA, colsA, rowsB, colsB;
Console.WriteLine("Введите количество строк и столбцов первой матрицы:");
rowsA = int.Parse(Console.ReadLine());
colsA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество строк и столбцов второй матрицы:");
rowsB = int.Parse(Console.ReadLine());
colsB = int.Parse(Console.ReadLine());

// Проверяем, возможно ли умножение матриц
if (colsA != rowsB)
{
    Console.WriteLine("Умножение матриц невозможно!");
    return;
}

// Создаем две матрицы
int[,] matrixA = new int[rowsA, colsA];
int[,] matrixB = new int[rowsB, colsB];
int[,] resultMatrix = new int[rowsA, colsB];

// Вводим значения для первой матрицы
Console.WriteLine("Введите значения для первой матрицы:");
for (int i = 0; i < rowsA; i++)
{
    for (int j = 0; j < colsA; j++)
    {
        matrixA[i, j] = int.Parse(Console.ReadLine());
    }
}

// Вводим значения для второй матрицы
Console.WriteLine("Введите значения для второй матрицы:");
for (int i = 0; i < rowsB; i++)
{
    for (int j = 0; j < colsB; j++)
    {
        matrixB[i, j] = int.Parse(Console.ReadLine());
    }
}

// Находим произведение матриц
for (int i = 0; i < rowsA; i++)
{
    for (int j = 0; j < colsB; j++)
    {
        for (int k = 0; k < colsA; k++)
        {
            resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
        }
    }
}

// Выводим результат
Console.WriteLine("Результат умножения матриц:");
for (int i = 0; i < rowsA; i++)
{
    for (int j = 0; j < colsB; j++)
    {
        Console.Write(resultMatrix[i, j] + " ");
    }
    Console.WriteLine();
}