//Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 14212 -> нет 12821 -> да
/*
bool TrueOrFalse(int num)
{
    if (num / 10000  == num % 10 && num / 1000 % 10  == num % 100 / 10 )
    return true;
    else return false;
}
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
bool Palindrom = TrueOrFalse(num);
Console.WriteLine(Palindrom);
*/
//Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. A (3,6,8); B (2,1,-7), -> 15.84. A (7,-5, 0); B (1,-1,9) -> 11.53
//ZA l^2 = (x2-x1)^2+(y2-y1)^2+(z2-z1)^2
/*
double FindDistance(double xa, double xb, double ya, double yb, double za, double zb)
{
    return Math.Sqrt(Math.Pow((xb-xa), 2) + Math.Pow((yb-ya), 2) + Math.Pow((zb-za), 2));
}  
Console.WriteLine("Input xa");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input xb");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input ya");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input yb");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input za");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input zb");
double zb = Convert.ToDouble(Console.ReadLine());

double result = FindDistance(xa, xb, ya, yb, za, zb);
Console.WriteLine(result);
*/

//Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27
/*
void CubeNumbers(int num)
{
    int current = 1;
    while (current <= num)
    {
        Console.WriteLine($"cube number of {current} = {current*current*current}");
        current++;
    }
}

Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
CubeNumbers(num);
*/