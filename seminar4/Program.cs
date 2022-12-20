// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int numA, int numB)
{
    int result = 1;
    for(int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}


Console.Write("Введите число A:");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B:");
int numB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numA, numB);
Console.WriteLine("Результат:"+ exponentiation);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while(n > 0)
// {
//     int Number = n % 10;
//     sum = sum + Number;
//     n /=10;
// }
// Console.WriteLine("Сумма цифр равна:" + sum);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] CreateRandomArray (int size,int minValue, int maxValue)
// {
//     int[] myArray = new int[size];
//     for(int i=0;i<size;i++)
//     {
//         myArray[i] = new Random().Next(minValue,maxValue+1);
//     }
//     return myArray;
// }

// void ShowArray (int[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());

// ShowArray(CreateRandomArray(lenght,min,max));
