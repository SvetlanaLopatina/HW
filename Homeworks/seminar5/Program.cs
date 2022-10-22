// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int [size];
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
    Console.WriteLine();
}
void FindSumEvenBumber(int[] array)
{
    int amount = 0;
    for(int i = 0; i < array.Length;i++)
    {
        if(array[i] % 2 ==0) amount++;
    }
    Console.WriteLine($"Количество четных чисел -> {amount}");
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
FindSumEvenBumber(myArray);
*/
//Задача2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19] [-4, -6, 89, 6] -> 0
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int [size];
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
    Console.WriteLine();
}
void FindSumOddNumber(int[] array)
{
    int sumOdd = 0;
    for(int i = 1; i < array.Length;i=i+2)
    {
        sumOdd += array[i];
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях -> {sumOdd}");
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
FindSumOddNumber(myArray);
*/

//Задача3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int [size];
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
    Console.WriteLine();
}
void FindMinMaxNumber(int[] array)
{
    int Max = array[0];
    int Min = array[0];
    for(int i = 1; i < array.Length;i++)
    {
        if(array[i]>Max) Max = array[i]; 
    }
    for(int i = 1; i < array.Length;i++)
    {
        if(array[i]<Min) Min = array[i]; 
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива -> {(Max - Min)}");
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
FindMinMaxNumber(myArray);
*/