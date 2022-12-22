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



Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);

double min = 0;
double max = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if(numbers [i] > max)
    {
        max = numbers[i];
    } 
    else
        min = numbers[i];
   
}

Console.WriteLine($"всего {numbers.Length} чисел, максимальное число = {max}, минимальное число = {min} ");
Console.WriteLine($"разница между максимальным и минимальным числом= {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{ 
    for(int i = 0; i < numbers.Length; i++) 
    {
        numbers[i] = new Random().Next(-100, 1000); 
    }
}
