//  Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int n = 8;
int [] numbers = new int[n];
Console.Write("[");
for(int i = 0; i < n; i++)
{
numbers[i] = new Random().Next(1,100);
if (i!=n-1) Console.Write($"{numbers[i]}, ");
else Console.Write($"{numbers[i]}");
}
Console.Write("]");
