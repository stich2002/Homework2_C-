// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.

Console.WriteLine("Введите количество чисел");
int M = Convert.ToInt32(Console.ReadLine());
int x;
int count = 0;
for (int i = 1; i <= M; i++)
{
    Console.WriteLine("Введите число номер "+i);
    x = Convert.ToInt32(Console.ReadLine());
    if(x>0) count++;
}
    Console.WriteLine("Введено чисел больше нуля "+count);


