// // ; Задание1.  Напишите программу, которая принимает
// // ; на вход координаты точки (X и Y),
// // ;  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// // ;   в которой находится эта точка.

// // int FindQuart (double x, double Y);
// // {
// //     if(x>0, y>0)
// //     return 1;
// //     if(x<0, y>0)
// //     return 2;
// //     if(x<0, y<0)
// //     return 3;
// //     if(x>0, y<0)
// //     return 4;
// //     return 0;
// // }
// // Console.WriteLine("Input x:");
// // double x = Console.ToDouble(Console.Readline());
// // Console.WriteLine("Input y:");
// // double y = Console.ToDouble(Console.Readline());
// // int result = FindQuart(x,y);
// // if(result==0)
// // Console.WriteLine("Point not find");
// // else
// // Console.WriteLine(&"Point located in {result} quart");


// // Задача 2.Напишите программу,
// // которая по заданному номеру четверти,
// //  показывает диапазон возможных координат
// //  точек в этой четверти (x и y).

// void FindCoordinats (int quart)
// {
//     if(quart==1)
//     {
//         Console.WriteLine("Диапазон координат (x+ y+)");
//     }
//     if(quart==2)
//     {
//         Console.WriteLine("Диапазон координат (x- y+)");
//     }
//     if(quart==3)
//     {
//         Console.WriteLine("Диапазон координат (x- y-)");
//     }
//     if(quart==4)
//     {
//         Console.WriteLine("Диапазон координат (x+ y-)");
//     }
//     if ( quart < 1 && quart > 4)
//     Console.WriteLine("Заданной четверти не существует");
// }
// Console.WriteLine("Введите номер четверти:");
// int quart = Convert.ToInt32(Console.ReadLine());
// FindCoordinats(quart);

// // Задача 3. Напишите программу, которая принимает на вход координаты
// // двух точек и находит расстояние между ними в 2D пространстве.
// // A (3,6); B (2,1) -> 5,09
// // A (7,-5); B (1,-1) -> 7,21



// // Задача 4. Напишите программу которая принимает на вход число (N)
// //  и выдает на консоль квадраты чисел от 1 до N
// void N(int number)
// {
//   for (int i = 1; i < number; i++)
//   {
//     Console.WriteLine(i*i);
//   }
// }
// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// N(x);





// 1
// double N (double x1, double y1, double x2, double y2)
// {
//   double k1 = x1 - x2;
//   double k2 = y1 - y2;
//   double g = Math.Round(Math.Sqrt(k1*k1 + k2*k2),2);

//   return g;
// }
// Console.WriteLine("Координаты x1:");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты y1:");
// double y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты x2:");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты y2:");
// double y2 = Convert.ToInt32(Console.ReadLine());
// double result = N(x1, y1, x2, y2);
// Console.WriteLine(result);







// Homework


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// void N(int number)
// {
//   for (int i = 1; i < number; i++)
//   {
//     Console.WriteLine(i*i*i);
//   }
// }
// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// N(x);




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.8
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double N (double x1, double y1, double x2, double y2, double z1, double z2)
// {
//   double k1 = x1 - x2;
//   double k2 = y1 - y2;
//   double k3 = z1 - z2;
//   double g = Math.Round(Math.Sqrt(k1*k1 + k2*k2 + k3*k3),2);

//   return g;
// }
// Console.WriteLine("Координаты x1:");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты x2:");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты y1:");
// double y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты y2:");
// double y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты z1:");
// double z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты z2:");
// double z2 = Convert.ToInt32(Console.ReadLine());

// double result = N(x1, y1, x2, y2, z1, z2);
// Console.WriteLine(result);





// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("Введите пятизначное число:");
// string number = Console.ReadLine();

// void CheckingNumber (string number)
// {

// if (number[0] == number[4] || number[1] == number[3])
// {
//     Console.WriteLine("Yes");
// }
// else Console.WriteLine("No");
// }

//     if (number.Length == 5)
//     {
//         CheckingNumber(number);
//     }
// else Console.WriteLine("Введите другое число");


//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// int FindSum (int num)
// {
//     int sum = 0;
//     for(int current= 1; current<=num;current++)
//     {
//         sum += current;
//     }
//     return sum;
// }

// Console.WriteLine("Input A:");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = FindSum(a);
// Console.WriteLine(result);




// /Задача 2.Напишите программу, которая принимает на
//  вход число и выдаёт количество цифр в числе.

// //456 -> 3
// //78 -> 2
// //89126 -> 5


// int Number (int num)
// {
//     int count = 0;
//     while (num != 0)
//     {
//      num /= 10;
//      count ++;
//     }
//     return count;
// }
// Console.WriteLine("Input A:");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = Number(a);
// Console.WriteLine(result);




// //Задача 3. Напишите программу, которая принимает
//  на вход число N и выдаёт произведение чисел от 1 до N.

// //4  -> 24
// //5  -> 120


// int Factorial(int num)
// {
//     int fact = 1;
//     for(int current= 1; current<=num;current++)
//     {
//         fact =fact* current;
//     }
//     return fact;
// }

// Console.WriteLine("Input A:");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = Factorial(a);
// Console.WriteLine(result);


//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

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

// // int[] newArray = CreateRandomArray(lenght,min,max);
// // ShowArray(newArray);

// ShowArray(CreateRandomArray(lenght,min,max));



