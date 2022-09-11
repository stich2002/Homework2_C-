// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int x=Convert.ToInt32(Console.ReadLine());

    int Sum(int x)
    {
        int sum = 0;
       while(x>0)
        {
        sum = sum + (x%10);
        x = x/10;
        } 
        return sum;
    }
int result = Sum(x);
Console.WriteLine("Сумма цифр в числе "+result);
   

