﻿//Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число ");
int x = int.Parse(Console.ReadLine());

int x1 = ((x/10)%10);
Console.WriteLine("Вторая цифра числа: "+x1);