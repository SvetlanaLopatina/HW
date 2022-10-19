// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
/*
 int CutNumber (int num)
{
    int dec = num / 10;
    int result = dec % 10;
    return result;
}
int RandomNumber = new Random().Next(100,1000);

int result = CutNumber(RandomNumber);
Console.WriteLine($"Second number of {RandomNumber} is {result}"); 
*/
// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void TheNumber(int num)
{
    if (num >= 100)
    {
        Console.WriteLine(num.ToString()[2]);
    }
    else
    {
        Console.WriteLine($"-> no third number");
    }
}
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
TheNumber(num);
*/
// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
/*
bool TrueOrFalse(int num)
{
    if (num ==6 || num ==7)
    return true;
    else return false;
}
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
bool Weekends = TrueOrFalse(num);
Console.WriteLine(Weekends);
*/