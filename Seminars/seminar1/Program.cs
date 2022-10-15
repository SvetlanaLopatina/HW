/*

Console.Write("Input first number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"My first number is {num}");
*/



//здесь я вывожу мое первое число
//Задание 1. Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

//**Например:**

//4 -> 16
//-3 -> 9
//-7 -> 49

/*Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine($"Quad of {num} is -> {result}");

//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

//a = 25; b = 5 -> да
//a = 2 b = 10 -> нет
//a = 9; b = -3 -> да
//a = -3 b = 9 -> нет

//9%4 == 1
//9/4
//4+4 остаток 1
//11%4 == 3 остаток от деления

345 -> 5
345%10
34*10
5 
5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N. 
Console.WriteLine("Input first number ");
int num = Convert.ToInt32(Console.ReadLine());
int current = num * (-1);
while (current <= num)
{
    Console.WriteLine(current + "");
    current++;
}
*/
/*
Console.WriteLine("Input first number ");
int num = Convert.ToInt32(Console.ReadLine());
int current = num % 10;
Console.Write(current);
*/

Console.WriteLine("Input first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
int quad2 = num2 * num2;
if (num1 == quad2)

 Console.WriteLine($"{num1} является квадратом {num2}");

else Console.WriteLine("${num1} является квадратом {num2}");