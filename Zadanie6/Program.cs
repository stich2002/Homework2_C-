﻿//Напишите программу, которая на вход принимает 
//число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите целое число");
int a = int.Parse(Console.ReadLine());
if(a%2==0) Console.WriteLine("Введенное число является чётным");
else Console.WriteLine("Введенное число является нечётным");