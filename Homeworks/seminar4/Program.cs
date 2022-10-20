// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵)  2, 4 -> 16 
/*
double FindNaturalDegree (double x, double y)
{
    return Math.Pow (x, y);  
}
Console.WriteLine("Input A");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input B");
double y = Convert.ToDouble(Console.ReadLine());

double result = FindNaturalDegree (x, y);
Console.WriteLine(result);
*/
// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.  452 -> 11  82 -> 10  9012 -> 12
/*
int FindSum (int num)
{
    int sum = 0;
    for(int i = 0; i <= num; i++)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}
Console.WriteLine("input A ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSum(a);
Console.WriteLine($"Sum of numbers {a} -> {result}");
*/
// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]  6, 1, 33 -> [6, 1, 33]
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i=0; i<size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}

void ShowArray (int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
*/
