// Задача 47.Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// создание двухмерного массива (рамдомно)
double[,] CreateRandom2dArray(int M, int N)
{
    double[,] array = new double[M, N];
    for (int i = 0; i < M; i++)
        for (int j = 0; j < N; j++)
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
    return array;
}
// вывод двухмерного массива
void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество столбцов m = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandom2dArray(m, n);
Show2dArray(array);
