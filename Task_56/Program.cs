// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int[] FindSumRow(int[,] array)
{
    int[] SumRow = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumRow[i] += array[i, j];
        }
    }
    return SumRow;
}

int RowMin(int[] SumRowArray)
{
    int SumMin = SumRowArray[0];
    int RowMin = 0;
    for (int i = 1; i < SumRowArray.Length; i++)
    {
        if (SumRowArray[i] < SumMin)
        {
            SumMin = SumRowArray[i];
            RowMin = i;
        }
    }
    return RowMin;
}

Console.Write("Укажите количество строк: ");
int arrayRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов: ");
int arrayColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите минимальное значение массива: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите максимальное значение массива: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());
int[,] new2DArray = Get2DArray(arrayRows, arrayColumns, arrayStart, arrayEnd);
Print2DArray(new2DArray);
int[] SumRow = FindSumRow(new2DArray);
int minRow = RowMin(SumRow);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow+1}");