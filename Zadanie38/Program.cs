// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[]array = new int[n];
int max=0;
int min=0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
        if (i!=array.Length-1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}");
    }
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i]>max) max=array[i];
        }
            for (int i = 0; i < array.Length; i++)
        {
            if(array[i]<min) min=array[i];
        }
        Console.WriteLine("Разница между максимальным и минимальным значение массива "+(max-min));
     
        
