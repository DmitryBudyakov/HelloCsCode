﻿// Сортировка массива от Min к Max

void FillArray(int[] array)     // заполняет массив Random [0;100)
{
    int length = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100);
    }
}

void PrintArray(int[] array)    // выводит массив в косоль
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (i == length - 1) Console.WriteLine($"{array[i]}");
        else Console.Write($"{array[i]} ");
    }
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

int[] arr = new int[8];

FillArray(arr);
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
