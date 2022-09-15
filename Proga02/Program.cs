// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

void PrintArray(int[,] inArray)
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

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] FindElem(int[,] inArray)
{
    Console.Write("Введите № строки массива: ");
    int i = int.Parse(Console.ReadLine()!) - 1;

    Console.Write("Введите № столбца массива: ");
    int j = int.Parse(Console.ReadLine()!) - 1;

    if (i<rows && j<columns && i >= 0 && j >= 0)
    Console.WriteLine($" Элемент [{i+1}, {j+1}] -> {inArray [i, j]}");
    else Console.WriteLine(" -> такого элемента в массиве нет");
    return inArray;
}
FindElem(array);
