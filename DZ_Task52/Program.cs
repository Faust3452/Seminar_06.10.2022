// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int[,] FillRandomDDimMass(int row, int col, int min_arg, int max_arg)
{
    int[,] new_arr = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            new_arr[i, j] = new Random().Next(min_arg, max_arg);
        }
    }
    return new_arr;
}

void PrintDDimArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] MiddleElArr(int[,] arr)
{
    int col = arr.GetLength(1);
    double[] res = new double[col];
    for (int j = 0; j < col; j++)
    {
        res[j] = default;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            res[j] = res[j] + arr[i, j];
        }
        res[j] = res[j] / arr.GetLength(0);
        res[j] = Math.Round(res[j], 2, MidpointRounding.ToZero);
    }
    return res;
}

Console.Write("Введите количество строк в массиве: ");
int row_size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column_size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение для генерации элементов в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение для генерации элементов в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());
if (min > max) Console.WriteLine("Максимальное значение меньше минимального, повторите ввод!");
else
{
    int[,] array = FillRandomDDimMass(row_size, column_size, min, max);
    Console.WriteLine("Сгенерированный массив: ");
    PrintDDimArray(array);
    double[] middle = MiddleElArr(array);
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < middle.Length; i++)
    {
        if (i == middle.Length - 1) Console.Write($"{middle[i]}");
        else Console.Write($"{middle[i]}, ");
    }
}