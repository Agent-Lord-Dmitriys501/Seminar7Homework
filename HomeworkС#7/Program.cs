// Задача 47.Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// // создание двухмерного массива (рамдомно)
// double[,] CreateRandom2dArray(int M, int N)
// {
//     double[,] array = new double[M, N];
//     for (int i = 0; i < M; i++)
//         for (int j = 0; j < N; j++)
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//     return array;
// }
// // вывод двухмерного массива
// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество столбцов m = ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество строк n = ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] array = CreateRandom2dArray(m, n);
// Show2dArray(array);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7->такого числа в массиве нет
// 1,2 -> 2

// // создание двухмерного массива (рамдомно)
// int[,] CreateRandom2dArray()
// {
//     int M = 5;
//     int N = 5;
//     int[,] array = new int[M, N];
//     for (int i = 0; i < M; i++)
//         for (int j = 0; j < N; j++)
//             array[i, j] = new Random().Next(-100, 101);
//     return array;
// }
// // вывод двухмерного массива
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// // поиск позиции заданного элемента 
// void PoickElementa(int[,] array, int M, int N)
// {
//     bool element = false;
//     int rezult = 0;
//     // доработать весь метод
//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == M && j == N)
//             {
//                 element = true;
//                 rezult = array[i, j];
//             }
//         }

//     }
//     Console.WriteLine();
//     if (element == true)
//     {
//         Console.WriteLine(rezult + $" - этот элемент находиться на позиции {M} {N} ");
//     }
//     else
//     {
//         Console.WriteLine($"{M} {N} такой позиции элемента в двухмерном массиве несуществует ");
//     }

// }
// // Console.WriteLine(array[i, j] + $" - этот элемент находиться на позиции {M} {N} ");
// // Console.WriteLine($"{M} {N} такой позиции элемента в двухмерном массиве несуществует ");


// Console.Write("Введите номер позиции элемента в столбце: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер позиции элемента в строке: ");
// int n = Convert.ToInt32(Console.ReadLine());



// int[,] array = CreateRandom2dArray();
// Show2dArray(array);
// PoickElementa(array, m, n);


// Задача 52.Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// создание двухмерного массива (рамдомно)
int[,] CreateRandom2dArray(int M, int N)
{
    int[,] array = new int[M, N];
    for (int i = 0; i < M; i++)
        for (int j = 0; j < N; j++)
            array[i, j] = new Random().Next(0, 100);
    return array;
}
// вывод двухмерного массива
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// Среднее арифметическое каждого столбца
void SrednieArifmStolb(int[,] array)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sredArifm = 0.0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sredArifm += array[i, j];
        }
        Console.Write($"{sredArifm / array.GetLength(0)} ");
    }

}

Console.Write("Введите количество столбцов m = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n);
Show2dArray(array);
SrednieArifmStolb(array);

