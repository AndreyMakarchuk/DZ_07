// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


double[,] GetArray(int m, int n)
{
    double[,] res = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return res;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк m: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов n: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns);
PrintArray(array);