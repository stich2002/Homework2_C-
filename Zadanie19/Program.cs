// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число ");
int x=Convert.ToInt32(Console.ReadLine());
string result="";
    if (((x/10000)==(x%10))&&(((x/1000)%10)==((x/10)%10))) result="да";
    else result="нет";

Console.WriteLine(result);
    
    