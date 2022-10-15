//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Input first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
{
    if (num1 > num2)
    {
    Console.WriteLine($"{num1} является максмальным");
    Console.WriteLine($"{num2} является минимальным");
    }
    else 
    {
    Console.WriteLine($"{num1} является минимальным");
    Console.WriteLine($"{num2} является максмальным");  
    }
}
*/
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Input first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number ");
int num3 = Convert.ToInt32(Console.ReadLine());
{
    if (num1 > num2 && num1 > num3 )

    Console.WriteLine($"{num1} является максмальным");
}
{
    if (num2 > num1 && num2 > num3 )

    Console.WriteLine($"{num2} является максмальным");
}
{
    if (num3 > num1 && num3 > num2 )

    Console.WriteLine($"{num3} является максмальным");
}
*/
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Input first number ");
int number = Convert.ToInt32(Console.ReadLine());
{
    if (number % 2 == 0)
    {
        Console.WriteLine($"-> Четное");
    }
    else
    {
        Console.WriteLine($"-> Нечетное");
    }
}
*/
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 0;
while (current <= number)
{
    Console.Write(current + " ");
    current = current +2;
}
*/