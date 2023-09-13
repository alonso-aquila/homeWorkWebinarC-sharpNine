// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите положительное число!");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NaturalNumber(n, 1));

string NaturalNumber(int n, int m)
{  
    if (n == m)
    {
        return n.ToString();
    }
    return  n + "-" + (NaturalNumber(n - 1, m));
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumberInterval(m, n));

int SumNumberInterval(int n, int m)
{  
    if (n == m)
    {
        return n;
    }
    return SumNumberInterval(n + 1, m) + n;   
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(AkkermanFunction(m, n));

int AkkermanFunction(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
  else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}