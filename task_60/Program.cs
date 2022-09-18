//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateThreeDimensionMatrix (int rows, int columns, int layers)
{
    int[,,] resultMatrix = new int[rows, columns, layers];
    for (int i = 0; i < layers; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                resultMatrix[j,k,i] = new Random().Next(100);
            }
        }
    }
    return resultMatrix;
}

void PrintThreeDimensionMatrix (int[,,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int layers = matrix.GetLength(2);
    for (int i = 0; i < layers; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            Console.Write("[ ");
            for (int k = 0; k < columns; k++)
            {
                Console.Write($"{matrix[j,k,i]} ");
            }
            Console.WriteLine("]");
        }
        Console.WriteLine();
    }
}

Console.Clear();
System.Console.WriteLine("Введите кол-во строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во слоёв");
int layers = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[rows,columns,layers];
matrix = CreateThreeDimensionMatrix(rows,columns,layers);
PrintThreeDimensionMatrix(matrix);