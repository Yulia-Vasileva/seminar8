// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void Count(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < array.GetLength(1) - 1; z++)
        {
            if (array[i, z] < array[i, z + 1]) 
            {
                int temp = 0;
                temp = array[i, z];
                array[i, z] = array[i, z + 1];
                array[i, z + 1] = temp;
            }
        }
    }
}
}


const int ROWS = 3;
const int COLUMNS = 4;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;


int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintMatrix(array);
Console.WriteLine();
Count(array);
PrintMatrix(array);