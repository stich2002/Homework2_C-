// Напишите программу, которая принимает на вход три 
//числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три целых числа ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max=a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c; 
Console.WriteLine("Максимальное из этих чисел "+max); 
