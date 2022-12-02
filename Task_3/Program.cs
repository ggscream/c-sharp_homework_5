// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using static System.Console;

void FillArray (double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9999, 10000); //для скорости работы программы пока ограничимся четырёхзначными числами
    }
}

void PrintArray (double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]} ");
    }
}

double FindMaxim (double[] arr)
{
    double maxim = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxim)
        {
            maxim = arr[i];
        }
    }
    return maxim;
}

double FindMinim (double[] arr)
{
    double minim = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minim)
        {
            minim = arr[i];
        }
    }
    return minim;
}


WriteLine("Введите целое натуральное число, определяющее размер массива: ");
int n = Convert.ToInt32(ReadLine());
double[] array = new double[n];

PrintArray (array);
WriteLine();
FillArray (array);
PrintArray (array);
WriteLine();
FindMaxim (array);
FindMinim (array);
WriteLine($"Минимальный элемент массива = {FindMinim (array)}, максимальный элемент массива = {FindMaxim (array)}");
WriteLine($"Разница элементов = {(FindMaxim (array) - FindMinim (array))}");