// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double[,] FillRandomDDimMass(int row, int col, int min_arg, int max_arg)
{
    double[,] new_arr = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            new_arr[i, j] = min_arg + new Random().NextDouble()*(max_arg - min_arg);
            new_arr[i, j] = Math.Round(new_arr[i, j], 2, MidpointRounding.ToZero);
        }
    }
    return new_arr;
}

void PrintDDimArray(double[,] arr)
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
    double[,] array = FillRandomDDimMass(row_size, column_size, min, max);
    Console.WriteLine("Сгенерированный массив: ");
    PrintDDimArray(array);
}
