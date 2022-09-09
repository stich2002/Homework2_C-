// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void SquareKub()
{
Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int[] answer = new int[N];
if (N > 0)
{
for (int i = 1; i < (N + 1); i++)
{
answer[i - 1] = (i * i * i);
}
}
else
{
Console.Write("Надо было вводить положительные числа");
}
var str = string.Join(" ", answer);
Console.WriteLine(str);
}

try
{
SquareKub();
}
catch
{
Console.Write("Надо было вводить числа");
}
