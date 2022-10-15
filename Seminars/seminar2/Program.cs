//Напишите программу, к-я выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
 
 /*
 int FindBiggestDigit (int num)
 {
    int ed = num % 10;
    int dec = num / 10;
    if (ed > dec)
    {
        return ed;
    }
    else
    {
        return dec;
    }
 }

 int RandomNumber = new Random().Next(10,100);

 int result = FindBiggestDigit(RandomNumber);
 Console.WriteLine($"Biggest digit of {RandomNumber} is {result}");
 */

/*Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98

int CutNumber (int num)
{
    int ed = num % 10;
    int hundred = num / 100;
    int result = hundred * 10 + ed;
    return result;
}
int RandomNumber = new Random().Next(100,1000);

int result = CutNumber(RandomNumber);
Console.WriteLine($"Искомое число {result}");

/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4  -> кратно
*/
/*
void Isdivisionable(int num1, int num2)
{
    if (num2 % num1 == 0)
    {
        Console.WriteLine($"-> Кратно");
    }
    else
    {
        Console.WriteLine($"-> Не кратно, остаток {num2 % num1}");
    }
}
Console.WriteLine("Input first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int num2 = Convert.ToInt32(Console.ReadLine());
Isdivisionable(num1, num2);

Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.  
14  ->  нет 46  ->  нет 161 ->  да


bool TrueOrFalse(int num)
{
    if (num % 7 ==0 && num % 23 ==0)
    return true;
    else return false;
}
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
bool Isdivisionable = TrueOrFalse(num);
Console.WriteLine(Isdivisionable);
*/
/* Напишите программу, которая принимает на вход два числа и 
проверяет, является ли одно число квадратом другого.
*/
void QuadOfNumber(int num1, int num2)
{
    if (num1 == num2 * num2)
    {
    Console.WriteLine("-> Являетя квадратом");
    }
    else
    {
      Console.WriteLine("-> Не является квадратом");  
}
}
Console.WriteLine("Input first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int num2 = Convert.ToInt32(Console.ReadLine());
QuadOfNumber(num1, num2);
