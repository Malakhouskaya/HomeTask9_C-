// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void PrintNumbersFromN(int N)
{
    Console.Write($"{N} ");
    if(N == 1)
    {
        return;
    }
    PrintNumbersFromN(N-1);
    
}

Console.WriteLine("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintNumbersFromN(N);




// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumElementsFromMN(int M, int N)
{
    if(M == N+1)
    {
        return 0;
    }
    return M + SumElementsFromMN(M+1,N);
}

int SumElementsFromMN2(int M, int N)
{
    if(M == N-1)
    {
        return 0;
    }
    return M + SumElementsFromMN2(M-1,N);
}


Console.WriteLine("Input the first number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number: ");
int N = Convert.ToInt32(Console.ReadLine());

if(M < N)
    Console.WriteLine($"Sum of the elements from M to N is {SumElementsFromMN(M,N)}");
else
    Console.WriteLine($"Sum of  the elements from M to N is {SumElementsFromMN2(M,N)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Akkerman(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if (m > 0 && n == 0)
      return Akkerman(m - 1, 1);
    else
      return Akkerman(m - 1, Akkerman(m, n - 1));
}


Console.WriteLine("Input the first positive number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second positive number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
    Console.WriteLine("Error: you've input the negative number!");
else
    Console.WriteLine($"The result of Akkerman function is {Akkerman(m,n)}");
*/