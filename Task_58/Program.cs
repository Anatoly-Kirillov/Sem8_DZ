// Задача 58: Задайте два массива. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 массива:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] Get2DArray(int row, int column, int start, int end)
{
    int[,] result = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(start, end + 1);
        }
    }
    return result;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Product2DArray(int[,] prod2DArray, int[,] first2DArray, int[,] second2DArray)
{
    for (int i = 0; i < first2DArray.GetLength(0); i++)
    {
        for (int j = 0; j < second2DArray.GetLength(1); j++)
        {
            for (int k = 0; k < second2DArray.GetLength(1); k++)
            {
                prod2DArray[i, j] += first2DArray[i, k] * second2DArray[k, j];
            }
        }
    }
}


Console.Write("Укажите количество строк первого массива: ");
int arrayRow1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов первого массива: ");
int arrayColumn1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество строк второго массива: ");
int arrayRow2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов второго массива: ");
int arrayColumn2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите минимальное значение массива: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите максимальное значение массива: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());
int[,] Array1 = Get2DArray(arrayRow1, arrayColumn1, arrayStart, arrayEnd);
int[,] Array2 = Get2DArray(arrayRow2, arrayColumn2, arrayStart, arrayEnd);
int[,] production2DArray = new int[arrayRow1, arrayColumn2];

Console.WriteLine("Первый массив:");
Print2DArray(Array1);
Console.WriteLine("Второй массив:");
Print2DArray(Array2);

if (arrayColumn1 == arrayRow2 && arrayColumn2 == arrayRow1 )
{
Product2DArray(production2DArray, Array1, Array2);
Console.WriteLine("\nПроизведение матриц:");
Print2DArray(production2DArray);
}
else Console.WriteLine("\nНе возможно найти произведение двух матриц.");