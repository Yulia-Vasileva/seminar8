// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int rows = 4;
int columns = 4;
int[,] Matrix = new int[rows, columns];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
  Matrix[i, j] = temp;
  temp++;
  
        if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
        j++;
  
        else if (i < j && i + j >= Matrix.GetLength(0) - 1)
         i++;

        else if (i >= j && i + j > Matrix.GetLength(1) - 1)
         j--;

        else
        i--;
}

newArray(Matrix);

void newArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
