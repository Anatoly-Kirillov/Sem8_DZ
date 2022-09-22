// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void SpiralArray(int row, int column, int[,] array)
{
    int EndRow = array.GetLength(0) - 1, EndColumn = array.GetLength(1) - 1;
    int point = 1;

    while (row <= EndRow && column <= EndColumn)
    {
        for (int i = column; i <= EndColumn; i++)
        {
            array[row, i] = point;
            point++;
        }
        row++;

        for (int i = row; i <= EndRow; i++)
        {
            array[i, EndColumn] = point;
            point++;
        }
        EndColumn--;

        if (row <= EndRow && column <= EndColumn)
        {
            for (int i = EndColumn; i >= column; i--)
            {
                array[EndRow, i] = point;
                point++;
            }
            EndRow--;


            for (int i = EndRow; i >= row; i--)
            {
                array[i, column] = point;
                point++;
            }
            column++;
        }
    }
}
void PrintArray(int[,] array)
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
Console.Write("Укажите количество строк: ");
int arrayRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов: ");
int arrayColumn = Convert.ToInt32(Console.ReadLine());
int[,] newArray = new int[arrayRow, arrayColumn];
int startRow = 0, startColumn = 0;
SpiralArray(startRow, startColumn, newArray);
PrintArray(newArray);