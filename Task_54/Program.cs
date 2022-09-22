// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
void BubbleDescendingMethod(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
Console.Write("Укажите количество строк: ");
int arrayrow = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов: ");
int arraycolumn = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите минимальное значение массива: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите максимальное значение массива: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());
int[,] new2DArray = Get2DArray(arrayrow, arraycolumn, arrayStart, arrayEnd);
Print2DArray(new2DArray);
BubbleDescendingMethod(new2DArray);
Console.WriteLine();
Print2DArray(new2DArray);
