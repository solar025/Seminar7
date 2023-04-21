﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadInt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int rows = ReadInt("Введите количество строк");
int colums = ReadInt("Введите количество столбцов");
double[,] array = new double[rows, colums];

double[,] Generate2DArray(double rows, double solums)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
    return array;
}

void Print2DArray(double[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        } 
        System.Console.WriteLine();
    }
}

double[,] arr = Generate2DArray(rows, colums);
Print2DArray(arr);