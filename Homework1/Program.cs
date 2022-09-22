//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();

int[,] array = new int [m, n];

for (int i = 0; i < m; i++)
{
    for (int y = 0; y < n; y++)
    {
        array[i,y] = rnd.Next(1, 10);
        Console.Write(array[i,y] + " ");

    }
    Console.WriteLine();
}

Console.WriteLine();
int c;

for (int i = 0; i < m; i++)
{
    for (int y = 0; y < n; y++)
    {   
        for (int k = 0; k < n - 1; k++)
        {
           if (array[i, k] > array[i, k + 1])
                    {
                        c = array[i, k];
                        array[i,k] = array[i, k + 1];
                        array[i, k + 1] = c;
                    }
        }
    }
}

for (int i = 0; i < m; i++)
{
    for (int y = 0; y < n; y++)
    {
        Console.Write(array[i,y] + " ");
    }
    Console.WriteLine();
}