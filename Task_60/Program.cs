// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[,,] Get3DArray(int row, int column, int layer)
{
    int[,,] result = new int[row, column, layer];

    for (int i = 0; i < layer; i++)
    {
        for (int j = 0; j < row; j++)
        {
            for (int l = 0; l < column; l++)
            {
                result[i, j, l] = new Random().Next(10, 100);
            }
        }
    }
    return result;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                Console.Write($"{array[j, l, i]} ({j},{l},{i})\t");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Укажите количество строк: ");
int arrayRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов: ");
int arrayColumn = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество слоёв: ");
int arrayLayer = Convert.ToInt32(Console.ReadLine());
int[,,] Array3D = Get3DArray(arrayRow, arrayColumn, arrayLayer);
Print3DArray(Array3D);
