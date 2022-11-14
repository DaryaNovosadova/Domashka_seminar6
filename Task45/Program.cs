﻿//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int[] array = GetArray(10, 0, 10);
PrintArray(array);
Console.WriteLine();

int[] CopyArray(int[] arr)
{
    int[] copyArray = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr[i];
    }
    return copyArray;
}
int[] copy = CopyArray(array);

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

PrintArray(copy);
Console.WriteLine();