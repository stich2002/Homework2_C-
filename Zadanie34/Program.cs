﻿// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[]array = new int[n];
int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (i!=array.Length-1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}");
    }
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 ==0 ) count=count+1;
    }
    Console.WriteLine("Количество четных чисел в массиве "+count);