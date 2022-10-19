// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int FindSum (int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("input A ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSum(a);
Console.WriteLine($"Sum of numbers from 1 to {a} -> {result}");
*/
//  Задача 2 Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.123 – 3 числа 
/*
int Count (int num)
{
    int current = 0;
    for(current = 1; current <= num; current++)
    {
        num = num / 10;
    }
    return current;
}
Console.WriteLine("input num");
int num = Convert.ToInt32(Console.ReadLine());
int result = Count(num);
Console.WriteLine($"Amount of numbers -> {result}");
*/
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int FindSum(int num)
{
    int sum = 1;
    for(int i = 1; i <= num; i++)
    {
        sum = sum * i;
    }
    return sum;
}
Console.WriteLine("input num ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSum(a);
Console.WriteLine($"Произведение чисел {a} -> {result}");
*/
//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]

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
