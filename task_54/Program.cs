//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//создать ещё цикл и уменьшать строку каждую итерацию

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

void MatrixSort (int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int count = 0;
    int maxNumber = matrix[0,0];
    int maxIndex = 0;
    int temp = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = count; j < columns; j++)
        {
            for (int k = count; k < columns; k++)
            {
                if (matrix[i,k] > maxNumber)
                {
                    maxNumber = matrix[i,k];
                    maxIndex = k;
                } 
            }
            temp = matrix[i,j];
            matrix[i,j] = maxNumber;
            matrix[i,maxIndex] = temp;
            maxNumber = 0;
            count++;
        }
        count = 0;
    }
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
    MatrixSort(matrix);
    Console.WriteLine();
    PrintMatrix(matrix);
}
else System.Console.WriteLine("Число строк и столбцов должно быть больше нуля");