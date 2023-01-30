// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

int[,,] TrArray = new int[2, 2, 2];
FillArray(TrArray);
Print(TrArray);

void Print(int[,,] arr)
{
    for (int i = 0; i < TrArray.GetLength(0); i++)
    {
        for (int j = 0; j < TrArray.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < TrArray.GetLength(2); k++)
            {
                Console.Write($"{TrArray[i, j, k]} ({i},{j},{k}) ");
                
            }
        }
    }
}

void FillArray(int[,,] arr)
{
    int count =10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] += count;
                count ++;
            }
        }
    }
}

