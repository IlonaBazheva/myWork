// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void PrintNUm(int num)
// {
//     if(num>=1)
//     {
//         Console.Write(num+"");
//         PrintNUm(num-1);
//     }
// }
// PrintNUm(10);

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите начальное число M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int N = Convert.ToInt32(Console.ReadLine());

void GapNumberSum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
    GapNumberSum(M, N, sum);
}
GapNumberSum(M, N, 0);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// static int Akkerman(int n, int m)
// {
//     if (n == 0)
//         return m + 1;
//     else
//       if ((n != 0) && (m == 0))
//         return Akkerman(n - 1, 1);
//     else
//         return Akkerman(n - 1, Akkerman(n, m - 1));
// }
 
// Console.WriteLine(Akkerman(2, 3)); // 4
// Console.ReadKey();