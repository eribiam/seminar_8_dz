//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
 
int[,] CreateMatrix (int rows, int columns)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i,j] = new Random().Next(10);
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

int[,] MatrixMultiplication (int[,] a, int[,] b)
{
    int newMatrixRows = a.GetLength(0);
    int newMatrixColumns = b.GetLength(1);
    int[,] newMatrix = new int[newMatrixRows, newMatrixColumns];
    for (int i = 0; i < newMatrixRows; i++)
    {
        for (int k = 0; k < newMatrixColumns; k++)
        {
            for (int j = 0; j < newMatrixColumns; j++)
            {
                newMatrix[i,k] = newMatrix[i,k] + a[i,j] * b[j,k];
            }
        }
    }
    return newMatrix;
}

Console.Clear();
Console.WriteLine("Введите число строк в первой матрице");
int rowA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов в первой матрице");
int columnA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк во второй матрице");
int rowB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов во второй матрице");
int columnB = Convert.ToInt32(Console.ReadLine());
if (rowA == 0 || columnA == 0 || rowB == 0 || columnB == 0 )
{
    Console.WriteLine("Колличества строк и столбцов должно быть больше нуля ");
}
else if (columnA != rowB)
{
    Console.WriteLine("Кол-во столбцов первой матрицы должно совпадать с кол-вом строк во второй");
}
else 
{
    int[,] matrixA = new int[rowA, columnB];
    int[,] matrixB = new int[rowB, columnB];
    matrixA = CreateMatrix(rowA, columnA);
    matrixB = CreateMatrix(rowB, columnB);
    int[,] resultMatrix = new int[rowA, columnB];
    resultMatrix = MatrixMultiplication(matrixA, matrixB);
    System.Console.WriteLine("Первая матрица");
    PrintMatrix(matrixA);
    System.Console.WriteLine("Вторая матрица");
    PrintMatrix(matrixB);
    System.Console.WriteLine("Произведение матриц");
    PrintMatrix(resultMatrix);
}

   