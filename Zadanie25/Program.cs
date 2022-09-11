// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите два числа А и В ");
double A=Convert.ToInt32(Console.ReadLine());
double B=Convert.ToInt32(Console.ReadLine());

    double result = Math. Pow(A,B);

Console.WriteLine("Результат возведения числа А в степень В: "+result);