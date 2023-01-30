// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange, 
                       int rows2, int columns2, int leftRange2, int rightRange2)
{   
    int[,] matrix = new int[rows, columns];
    int[,] massiv = new int[rows2, columns2];
    int rows3= 0;
    int colomns3 = 0;
    int[,] array = new int [rows3,colomns3];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
            massiv[i, j] = new Random().Next(leftRange2, rightRange2 + 1);
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


void ResultArray(int [,] matrix, int [,] massiv, int[,] array )
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
         int result = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
             result += matrix[i,k] * massiv[k,j];
            }
        array[i,j] = result;
        }
        
    }
}

const int ROWS = 4;
const int COLUMNS = 4;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

const int ROWS2 = 4;
const int COLUMNS2 = 4;
const int LEFTRANGE2 = 0;
const int RIGHTRANGE2 = 9;


int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE, ROWS2, COLUMNS2, LEFTRANGE2, RIGHTRANGE2);
Console.WriteLine($"Первая матрица:");
PrintMatrix(array);
Console.WriteLine();
int[,] array2 = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE, ROWS2, COLUMNS2, LEFTRANGE2, RIGHTRANGE2);
Console.WriteLine($"Вторая матрица:");
PrintMatrix(array2);
Console.WriteLine();
int[,] array3 = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE, ROWS2, COLUMNS2, LEFTRANGE2, RIGHTRANGE2);
ResultArray(array, array2, array3);
Console.WriteLine($"Произведение:");
PrintMatrix(array3);