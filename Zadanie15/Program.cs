//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру от одного до семи ");
int x = int.Parse(Console.ReadLine());

void Day()
{
    if (x<=5) Console.WriteLine("Нет");
    else Console.WriteLine("Да");
}

Day();