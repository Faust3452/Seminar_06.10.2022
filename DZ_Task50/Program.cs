//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет
double[,] FillRandomDDimMass(int row, int col, int min_arg, int max_arg)
{
    int row_real_size = new Random().Next(1, row + 1);
    int col_real_size = new Random().Next(1, col + 1);
    double[,] new_arr = new double[row_real_size, col_real_size];
    for (int i = 0; i < row_real_size; i++)
    {
        for (int j = 0; j < col_real_size; j++)
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

string GetArrElement(int row, int col, double[,] arr)
{
    string res = default;
    if ((row < arr.GetLength(0)) && (col < arr.GetLength(1))) res = Convert.ToString(arr[row, col]);
    else res = "такого элемента в массиве нет";
    return res;
}

Console.Write("Введите максимальное количество строк в массиве: ");
int row_size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное количество столбцов в массиве: ");
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
    Console.Write("Введите позицию строки в массиве для получения значения: ");
    int row_get = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите позицию столбца в массиве для получения значения: ");
    int col_get = Convert.ToInt32(Console.ReadLine());
    if ((row_get < 0) || (col_get < 0)) Console.WriteLine("Вы ввели неверное значение для проверки, повторите ввод!");
    else
    {
        string result = GetArrElement(row_get, col_get, array);
        Console.WriteLine($"{row_get}, {col_get} -> {result}");
    }
}