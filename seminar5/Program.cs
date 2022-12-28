// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int count = 0; 
// for (int i = 0; i < numbers.Length; i++)
// if (numbers[i] % 2 == 0) 
// {
//     count++; 
//     Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");
// }
// void FillArrayRandomNumbers(int[] numbers)
// { 
//     for(int i = 0; i < numbers.Length; i++) 
//     {
//         numbers[i] = new Random().Next(100,1000); 
//     }
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Наш массив: ");
// PrintArray(numbers);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Наш массив: ");
// PrintArray(numbers);
// int sum = 0;
// for (int i = 0; i < numbers.Length; i+=2)
// sum  = sum  + numbers [i];

// Console.WriteLine($"всего {numbers.Length} чисел, сумма = {sum} ");

// void FillArrayRandomNumbers(int[] numbers)
// { 
//     for(int i = 0; i < numbers.Length; i++) 
//     {
//         numbers[i] = new Random().Next(1,10); 
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }







// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);

// double min = 0;
// double max = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if(numbers [i] > max)
//     {
//         max = numbers[i];
//     } 
//     else
//         min = numbers[i];
   
// }

// Console.WriteLine($"всего {numbers.Length} чисел, максимальное число = {max}, минимальное число = {min} ");
// Console.WriteLine($"разница между максимальным и минимальным числом= {max - min}");

// void FillArrayRandomNumbers(double[] numbers)
// { 
//     for(int i = 0; i < numbers.Length; i++) 
//     {
//         numbers[i] = new Random().Next(-100, 1000); 
//     }
// }


//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]


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


// int[] ReverseArray(int[] array)
// {
//     for(int i = 0; i < array.Length/2; i++) // 4 6 8 1
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
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
// newArray = ReverseArray(newArray);
// ShowArray(newArray);




//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон


// bool CheckTriangle (int x, int y, int z)
// {
//     if((x<y+z) && (y<x+z) && (z<x+y))
//     {
//         return true;
//     }
//     return false;
// }

// Console.WriteLine("Введите длину стороны a");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину стороны b");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину стороны c");
// int z = Convert.ToInt32(Console.ReadLine());

// //Console.WriteLine($"CheckTriangle(x,y,z)");
// bool res = CheckTriangle(x,y,z);
// if(res == true)
// {
//     Console.WriteLine($"Треугольник со сторонами {x} {y} {z} может существовать ");
// }
// else
// Console.WriteLine($"Треугольник со сторонами {x} {y} {z} не может существовать ");


//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.



//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0, 1,2, 3, 5, 8, 13., ... ]




// int[] CreateRandomArray(int n, int a, int b)
//   {
//       int[] myArray = new int[n];
//       myArray[0] = a;
//       myArray[1] = b;
//       for (int i = 2; i < n; i++)
//       {
//           myArray[i] = myArray[i-2] + myArray[i-1];
//       }
//       return myArray;
//  }

//   void ShowArray(int[] array)
//  {
//       Console.WriteLine("Полученный массив ->:");
//       for (int i = 0; i < array.Length; i++)
//       {
//           Console.Write(array[i] + " ");
//       }
//       Console.WriteLine();
//  }


//  Console.WriteLine("Введите размер массива:");
//  int lenght = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите первый элемент массива:");
//  int a = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите второй элемент массива :"); 
//  int b = Convert.ToInt32(Console.ReadLine());                                  

//  int[] newArray = CreateRandomArray(lenght,a,b);

//  ShowArray(newArray);




// /Задача 4. ****Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//45 -> 101101
//3 -> 11
//2 -> 10

// string Method4(int num)
// {
//     string result = string.Empty;
//     while (num > 0)
//     {
//         result = num%2 +result;
//         num = num / 2;
//     }
//     return result;
// }
// string res = Method4(2);
// Console.WriteLine(res);
