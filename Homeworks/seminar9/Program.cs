// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
 /*N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
/*
void ShowNumbers (int n)
{
    if (n <=0)
    {
        Console.WriteLine("это ненатуральное число");
    }
    Console.Write(" " + n);
    if (n > 1) ShowNumbers(n-1);
}
ShowNumbers(5);  
*/
// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/* M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
/*
int SumNatNumbers (int m, int n)
{
    if(n > m)
    return n + SumNatNumbers(m, n - 1);
    else return n;
}
Console.WriteLine(SumNatNumbers(4,8));
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/* P.S. A(m,n) = n + 1 if m=0; A(m,n) = A(m - 1,1) if n=0; A(m,n) = A(m-1, A(m,n-1)) if m и n >0
   m = 3, n = 2 -> A(m,n) = 29   */
/*
int AckermannF (int m, int n)
{
    if(m == 0) return n + 1;
    if(n == 0) 
    {
        return AckermannF (m - 1, 1);
    }
    else return AckermannF (m - 1, AckermannF (m, n - 1));
}   
Console.WriteLine(AckermannF(3,2));
*/