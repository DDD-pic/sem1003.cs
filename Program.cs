/*
dz
Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью 
рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите число M: ");
//int m = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int n)
{
    if (n > 0)
    {
        Console.Write("{0} ", n);
        PrintNumbers(n - 1);
    }
}
		PrintNumbers( n);
		
		Console.WriteLine();

    

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
 сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int n )

{
    
    if (n == m) return m; 
    
    return (n + SumNumbers(n - 1));
}
    Console.WriteLine($"сумма числа n = {SumNumbers(n++) }");


Задача 68: Напишите программу вычисления функции Аккермана с помощью 
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

int Akk(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}
 
Console.WriteLine(Akk(2, 3)); // 4
Console.WriteLine(Akk(3, 2)); // 1
*/
 

