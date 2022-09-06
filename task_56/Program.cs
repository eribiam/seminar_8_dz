// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrix (int rows, int columns)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i,j] = new Random().Next(100);
        }
    }
    return resultMatrix;
}

void PrintMatrix (int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine("]");
    }
}

int MinSumInRows (int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int sum = 0;
    int minSum = 0;
    int rowCount = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sum += matrix[i,j];
        }
        if (sum < minSum || minSum == 0)
        {
            minSum = sum;
            rowCount = i + 1;
        }
        sum = 0;
    }
    return rowCount;
}

Console.Clear();
Console.WriteLine("Введите число строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int column = Convert.ToInt32(Console.ReadLine());
if (row > 0 && column > 0)
{
    int[,] matrix = new int[row, column];
    matrix = CreateMatrix(row, column);
    PrintMatrix(matrix);
    Console.WriteLine($"Номер строки с наименьшей суммой элементов = {MinSumInRows(matrix)}");
}
else Console.WriteLine("Число строк и столбцов должно быть больше 0");
