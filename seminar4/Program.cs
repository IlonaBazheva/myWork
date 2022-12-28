// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Exponentiation(int numA, int numB)
// {
//     int result = 1;
//     for(int i = 1; i <= numB; i++)
//     {
//         result = result * numA;
//     }
//     return result;
// }


// Console.Write("Введите число A:");
// int numA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число B:");
// int numB = Convert.ToInt32(Console.ReadLine());

// int exponentiation = Exponentiation(numA, numB);
// Console.WriteLine("Результат:"+ exponentiation);



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


// //Задача 1. Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9].
// // Найдите сумму отрицательных и 
// положительных элементов массива.

// //Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна -20.


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return myArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// void FindMinMaxSum (int[] array)
// {
//     int sumPositive = 0;
//     int sumNegative = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0) sumPositive += array[i];
//         else
//         sumNegative += array[i];
//     }
//     Console.WriteLine($"Сумма положительных элементов (sumPositive), а отрицательных (sumNegative)");
// }
// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(lenght,min,max);
// ShowArray(newArray);
// FindMinMaxSum(newArray);

// // ShowArray(CreateRandomArray(lenght, min, max));


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return myArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
// int max = Convert.ToInt32(Console.ReadLine());                                  

// int[] newArray = CreateRandomArray(lenght,min,max);

// ShowArray(newArray);
// FindMinMAxSum(newArray);


//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return myArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
// int max = Convert.ToInt32(Console.ReadLine());                                  

// int[] newArray = CreateRandomArray(lenght,min,max);

// ShowArray(newArray);
// FindMinMAxSum(newArray);

// int[] ChangeElemets (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = -array[i];
//     }
//     return array;
// }


// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:"); 
// int max = Convert.ToInt32(Console.ReadLine());                                  

// int[] newArray = CreateRandomArray(lenght,min,max);

// ShowArray(newArray);
// newArray = ChangeElemets(newArray);
// ShowArray(newArray);





// //Задача 3.Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// //4; массив [6, 7, 19, 345, 3] -> нет
// //3; массив [6, 7, 19, 345, 3] -> да


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return myArray;
// }

// void ShowArray(int[] array)
// {
// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(lenght, min, max);

// ShowArray(newArray);
// bool result = Flag(newArray, num);
// Console.WriteLine(result);



// //Задача 4.****Задайте одномерный массив из 123 
// случайных чисел. Найдите количество элементов массива, 
// //значения которых лежат в отрезке [10,99].


// //*Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123*


// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// int count = 0; 
// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// count++; 
// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");
//  void FillArrayRandomNumbers(int[] numbers)
//  { for(int i = 0; i < numbers.Length; i++) 
//  { numbers[i] = new Random().Next(100,1000); }
//  }
//  void PrintArray(int[] numbers)
//  { Console.Write("[ "); 
//  for(int i = 0; i < numbers.Length; i++) 
//  { Console.Write(numbers[i] + " "); } 
// Console.Write("]"); Console.WriteLine();
// }
int[,] table = new int[3, 4];
FillArrayRandom(table);
PrintArray(table);
SortToLower(table);
Console.WriteLine();
PrintArray(table);


// Функция заполнения массива рандомно числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Функция сортировки элементов в строке двумерного массива, по убыванию
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

// Функция вывода двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}