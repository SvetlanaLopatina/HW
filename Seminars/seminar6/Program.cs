// 1. Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый на последнем и т.д.) [1,2,3,4]>[4,3,2,1]
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

int[] ReverseArray (int [] array)
{
    for(int i=0; i < array.Length/2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = temp;
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
ShowArray(ReverseArray(myArray));
*/
// 2. Программа, которая принимает на вход три числа и проверяет может ли существовать треугольник со сторонами такой длины. **каждая сторона должна быть меньше суммы двух других сторон.
/*
bool triangle (int x, int y, int z)
{
    if (x+y>z && y+z>x && x+z>y)
    return true;
    else return false;
}
Console.WriteLine("Input x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z");
int z = Convert.ToInt32(Console.ReadLine());
bool result = triangle(x,y,z);
if(result==true)
{
    Console.WriteLine($"треугольник со сторонами {x} {y} {z} может существовать");
}
else 
Console.WriteLine($"треугольник со сторонами {x} {y} {z} не может существовать");
*/
//3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Ф. a и b.
/*
int [] Fibonacci (int n, int a, int b)
{ int [] myArray = new int [n];
    myArray[0] = a;
    myArray[1] = b;
    for(int i=2; i < n; i++)
    {
        myArray[i] = myArray[i-1] + myArray[i-2];
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

Console.WriteLine("Input a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n");
int n = Convert.ToInt32(Console.ReadLine());
ShowArray(Fibonacci(n,a,b));
*/
//4. Программа, которая будет преобразовывать десятичное число в двоичное.
/* 10 > 0  = 1010
   5  > 1
   2  > 0
   1 > 1 */

void ConvertToTwo(int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    Console.WriteLine(result);
}
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
ConvertToTwo(num);