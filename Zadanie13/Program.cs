//Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число ");
int x = int.Parse(Console.ReadLine());

void Number()
{
    if(x < 99) Console.WriteLine("Третьей цифры нет");
    else if ((x>99)&(x<1000)) Console.WriteLine (x%10);
    else if ((x>999)&(x<10000)) Console.WriteLine((x/10)%10);
    else if ((x>9999)&(x<100000)) Console.WriteLine((x/100)%10);
}

Number();