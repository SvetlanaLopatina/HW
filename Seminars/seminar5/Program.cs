//Задача1.Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
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
void FindMinMaxSum(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for(int i = 0; i < array.Length;i++)
    {
        if(array[i]>0) sumPositive += array[i];
        else sumNegative +=array[i];
    }
    Console.WriteLine($"Сумма положительных элементов -> {sumPositive} Cумма отрицательных элементов -> {sumNegative}");
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
FindMinMaxSum(myArray);
*/
//Задача2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
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

int[] ChangeElementArray(int[] array)
{
    for(int i = 0; i < array.Length;i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
ShowArray(ChangeElementArray(myArray));
*/
//Задача 3. Задайте массив. Напишите программу, к-я определяет, присутствует ли заданное число в массиве.
/*
int[] CreateNewArray(int size)
{
    int[] myArray = new int [size];
    for(int i=0; i<size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент ");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return myArray;
}
void ShowArray (int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}
bool NeedElement(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        return true;
    }
    return false;
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int [] NewArray = CreateNewArray(a);
bool result = NeedElement(NewArray, num);
ShowArray(NewArray);
Console.WriteLine($"В данном массиве есть указанное вами число? -> {result}");
*/

//Задача 4.*Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. *Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

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
}
int ElementCount(int[] array, int b, int c)
{
     int count = 0;                  
     {
        if(array[i] >= b && array[i] <=c)
        {
            count++;
        }
     }
     return count;
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начало отрезка");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец отрезка");
int c = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
int result = ElementCount(myArray, b, c);
Console.WriteLine($"В этом массиве содержится {result} чисел от {b} до {c}");