//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое число");
int N = int.Parse(Console.ReadLine());
Console.Write("Последовательность чисел: ");
for (int i=2; i<=N; i+=2) Console.Write(i+" ");