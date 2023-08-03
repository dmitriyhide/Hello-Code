// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] threeDimensionalArray = new int[2, 2, 2];
int minValue = 10;
int maxValue = 99;
Random random = new Random();

// Заполнение и вывод трехмерного массива
for (int x = 0; x < 2; x++)
{
    for (int y = 0; y < 2; y++)
    {
        for (int z = 0; z < 2; z++)
        {
            int randomNumber;
            bool uniqueNumber;

            do
            {
                randomNumber = random.Next(minValue, maxValue + 1);
                uniqueNumber = true;

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        for (int k = 0; k < 2; k++)
                        {
                            if (threeDimensionalArray[i, j, k] == randomNumber)
                            {
                                uniqueNumber = false;
                                break;
                            }
                        }
                        if (!uniqueNumber)
                            break;
                    }
                    if (!uniqueNumber)
                        break;
                }
            } while (!uniqueNumber);

            threeDimensionalArray[x, y, z] = randomNumber;
        }
    }
}

// Вывод трехмерного массива по массивам
for (int z = 0; z < 2; z++)
{
    Console.WriteLine($"Массив Z={z}");
    for (int x = 0; x < 2; x++)
    {
        for (int y = 0; y < 2; y++)
        {
            Console.Write($"{threeDimensionalArray[x, y, z]}({x},{y},{z}) ");
        }
    }
    Console.WriteLine();
}