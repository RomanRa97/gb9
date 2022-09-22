//Задача 2**. Напишите программу, которая спирально заполнит числами от 1 до 16 двумерный массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
//Указание:
//При заполнении массива использовать циклы.



int n = 4;
int[,] array = new int[n, n];

int perem = 1;
int i = 0;
int j = 0;

while (perem <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = perem;
  perem++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      if (array[x,y] / 10 <= 0)
      Console.Write(array[x,y] + " ");

      else Console.Write(array[x,y] + " ");
    }
    Console.WriteLine();
  }
