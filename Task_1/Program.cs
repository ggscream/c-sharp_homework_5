// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;

void FillArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]} ");
    }
}

int FindEven (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

WriteLine("Введите целое натуральное число, определяющее размер массива: ");
int n = Convert.ToInt32(ReadLine());
int[] array = new int[n];

PrintArray (array);
WriteLine();
FillArray (array);
PrintArray (array);
WriteLine();
WriteLine(FindEven(array));