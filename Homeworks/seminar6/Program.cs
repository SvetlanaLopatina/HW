// Задача 1: Пользователь вводит с клавиатуры N чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3
/*
int[] UserNumbers(int size)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return myArray;
}
void ShowArray(int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void CountElementAboveZero (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length;i++)
    {
        if(array[i] > 0) count++;
    }
    Console.WriteLine($"Количество чисел больше нуля -> {count}");
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int [] newArray = UserNumbers(a);
ShowArray(newArray);
CountElementAboveZero(newArray);
*/
// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void CrossPointLines(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k1 - k2);
    double y = (k2 * b1 - k1 * b2) / ( k2 - k1);
        if(k1 == k2 && b1 != b2 || k1 == k2 && b1 < b2|| k1 == k2 && b1 > b2 )
        {
            Console.WriteLine("Прямые не имеют точку пересечения");
        }
        else Console.WriteLine($"Прямые пересекаются в точке с координатами ({x};{y})");
} 
Console.WriteLine("Input b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k1 :");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
CrossPointLines(b1, k1, b2, k2);
*/