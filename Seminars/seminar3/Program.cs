// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FindQuad(double x, double y)
{
    if (x > 0 && y > 0)
    return 1;
    if (x < 0 && y > 0)
    return 2;
    if (x < 0 && y < 0)
    return 3;
    if (x > 0 && y < 0)
    return 4;

    return 0;
}

Console.WriteLine("Input X:");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Y:");
double y = Convert.ToDouble(Console.ReadLine());

int quadNum = FindQuad(x,y);
if(quadNum == 0)
{
    Console.WriteLine("Coordinats uncorrect");
}
else
{
    Console.WriteLine($"Point is locatated on {quadNum} quart");
}
*/

// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void FindQuad(int quad)
{
    if (quad ==1)
    Console.WriteLine("x+ y+");
    if (quad ==2)
    Console.WriteLine("x- y+");
    if (quad ==3)
    Console.WriteLine("x- y-");
    if (quad ==4)
    Console.WriteLine("x+ y-");
    if (quad < 1 || quad > 4)
    Console.WriteLine ("Такой четверти не существует");
}
Console.WriteLine("Input Quad:");
int quadNum = Convert.ToInt32(Console.ReadLine());
FindQuad(quadNum);
*/
//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
/*
double FindDistance(double xa, double xb, double ya, double yb)
{
    return Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2));
}
    
Console.WriteLine("Input xa");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input xb");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input ya");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input yb");
double yb = Convert.ToDouble(Console.ReadLine());

double result = FindDistance(xa, xb, ya, yb);
Console.WriteLine(result);
*/

// Напишите программу которая принимает на вход число (N) и 
//выдает на консоль квадраты чисел от 1 до N

void QuadNumbers(int num)
{
    int current = 1;
    while (current <= num)
    {
        Console.WriteLine($"quad of number is {current} = {current*current}");
        current++;
    }
}

Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
QuadNumbers(num);