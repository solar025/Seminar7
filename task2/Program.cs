// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 1 -> 1

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int rows = ReadInt("Введите количество строк");
int colums = ReadInt("Введите количество столбцов");
int[,] array = new int[rows, colums];


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = new Random().Next(0,21);
        }
    }

   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        } 
        System.Console.WriteLine();
    }

Console.Write("Введите индекс строки нужного элемента: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца нужного элемента: ");
int b = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.GetLength(0); i++)
{
 if (a == i + 1)
    {
 for (int j = 0; j < array.GetLength(1); j++)
        {
 if (b == j + 1)
            {
 Console.WriteLine($"Значение [{a}, {b}] элемента массива: {array[i, j]}");
            }
            
        }
    }
}
if (a > array.GetLength(0) || b > array.GetLength(1))
{
Console.WriteLine("Такого числа в массиве нет!");
}
