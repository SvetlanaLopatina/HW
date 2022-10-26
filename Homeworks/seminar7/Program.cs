// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4. 0,5 7 -2 -0,2
/*
int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];                   
    for(int i=0; i < rows; i++)                                
        for(int j=0; j < columns; j++)                         
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    return newArray;   
}

void Show2DArray (int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)                                
    {
        for(int j=0; j < array.GetLength(1); j++)                       
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }   
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);
*/
// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*Например, задан массив: 1 4 7 2 
                          5 9 2 3
                          8 4 2 4       17 -> такого числа в массиве нет*/

int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];                   
    for(int i=0; i < rows; i++)                                
        for(int j=0; j < columns; j++)                         
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    return newArray;   
}

void Show2DArray (int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)                                
    {
        for(int j=0; j < array.GetLength(1); j++)                       
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }   
}

bool UserElement (int[,] array, int a, int b)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
        if(array[i,j] == array[a,b])
        return true;
        }
    }
    return false;
}
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первый индекс");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй индекс");
int b = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m,n,min,max);
bool result = UserElement (myArray, a, b);
Show2DArray(myArray);
Console.WriteLine($"В данном массиве есть указанное вами число? -> {result}");

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
/*
int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];                   
    for(int i=0; i < rows; i++)                                
        for(int j=0; j < columns; j++)                          
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    return newArray;   
}

void Show2DArray (int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)                                
    {
        for(int j=0; j < array.GetLength(1); j++)                       
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }   
}

int[,] ArithmeticMean (int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        double average = 0;
        
        for(int j =0; j < array.GetLength(1); j ++)
        {
            sum = sum + array[j,i];
            average = sum / array.GetLength(1) ;
        }
        Console.WriteLine(average);
    }
    return array;
   
} 
Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray= Create2DRandomArray(m , n , min, max);
Show2DArray(myArray);
ArithmeticMean (myArray);
*/