// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными целыми числами. m = 3, n = 4.  1 4 8 19  5 -2 33 -2  77 3 8 1
/*
int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];                   // 1 2 3  new Array[i,j]
    for(int i=0; i < rows; i++)                                //  4 5 6 
        for(int j=0; j < columns; j++)                         //  7 8 9 
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
//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран. МЕТОД БУДЕТ ЗАПОЛНЯТЬ МАССИВ, на вход будет брать размер массива
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5
/*
int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];                   // 1 2 3  new Array[i,j]
    for(int i=0; i < rows; i++)                                //  4 5 6 
        for(int j=0; j < columns; j++)                         //  7 8 9 
        {
            newArray[i,j] = i + j;
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
//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Например, изначально массив выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:
//1 4 7 2
//5 **81** 2 **9**
//8 4 2 4
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
int[,] ElementsCount (int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(j % 2 == 0 && i % 2 == 0) 
            array[i,j] = array[i,j] * array [i,j];
        }
    }
   return array;
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
Show2DArray(ElementsCount(myArray));
*/
//Задача 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
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
int ElementsCount (int[,] array)
{
    int sum = 0;
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j) 
            sum += array[i, j]; 
        }
    }
   return sum;
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
int result = ElementsCount(myArray);
Console.WriteLine(result);
*/