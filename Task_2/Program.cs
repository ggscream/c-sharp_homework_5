// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;

void FillArray (double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9999, 10000); //для скорости работы программы пока ограничимся четырёхзначными числами
    }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]} ");
    }
}

double FindUnevenSum (double[] arr)
{
    double sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += arr[i];
        }
    }
    return sum;
}

WriteLine("Введите целое натуральное число, определяющее размер массива: ");
int n = Convert.ToInt32(ReadLine());
double[] array = new double[n];

PrintArray (array);
WriteLine();
FillArray (array);
PrintArray (array);
WriteLine();
WriteLine(FindUnevenSum(array));