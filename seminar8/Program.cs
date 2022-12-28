// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



//вводим массив

// int[,] Create2DRandomArray ( int rows, int columns)  
// {                                                                                
//     int[,] newArray = new int[rows,columns];                                     
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = i+j; 
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

//проходим каждую строку и сортируем числа по убыванию

// void SortToLower(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                     Console.Write(array[i,k]);
//                 }
//             }
//         }
//     }
    
// }

// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m,n);
// Show2DArray(myArray);
// int[,] table = new int[m, n];
// SortToLower(table);





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка



// Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// Create2DRandomArray(array);
// Show2DArray(array);
// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++) 
// {
//   int tempSumLine = SumLineElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }

// Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void Create2DRandomArray ( int[,] array)  
// {                                                                                                                  
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(range);
//         }
//     }
    
// }

// void Show2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }



// Задача 58: Задайте две матрицы.
//  Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// namespace ConsoleApplication1
// {
//     class Matrix
//     {
//         // Скрытые поля
//         private int n;
//         private int[,] mass;

//         // Создаем конструкторы матрицы
//         public int N
//         {
//             get { return n; }
//             set { if(value>0) n = value; }
//         }
//         public Matrix(int n)
//         {
//             this.n = n;
//             mass = new int[this.n, this.n];
//         }
//         public int this [int i, int j]
//         {
//             get
//             {
//                 return mass[i, j];
//             }
//             set
//             {
//                 mass[i, j] = value;
//             }
//         }
//         // Ввод матрицы
//         public void WriteMat()
//         {
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     Console.WriteLine("Введите элемент матрицы {0}:{1}", i+1, j+1);
//                     mass[i, j] = Convert.ToInt32(Console.ReadLine());
//                 }
//             }
//         }

//         // Вывод матрицы
//         public void ReadMat()
//         {
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     Console.Write(mass[i, j] + "\t");
//                 }
//                 Console.WriteLine();
//             }
//         }

//         // Умножение матрицы А на матрицу Б
//         public static Matrix umn(Matrix a, Matrix b)
//         {
//             Matrix resMass = new Matrix(a.N);
//             for (int i = 0; i < a.N; i++)
//                 for (int j = 0; j < b.N; j++)
//                     for (int k = 0; k < b.N; k++)
//                         resMass[i, j] += a[i, k]*b[k, j];

//             return resMass;
//         }

//         // перегрузка оператора умножения
//         public static Matrix operator *(Matrix a, Matrix b)
//         {
//             return Matrix.umn(a, b);
//         }
//     }
//     class MainProgram
//     {

//         static void Main(string[] args)
//         {
//             Console.WriteLine ("Введите размерность матрицы: ");
//             int nn = Convert.ToInt32 (Console.ReadLine ());
//             Matrix mass1 = new Matrix(nn);
//             Matrix mass2 = new Matrix(nn);
//             Matrix mass3 = new Matrix(nn);
//             Console.WriteLine("ввод Матрица А: ");
//             mass1.WriteMat();
//             Console.WriteLine("Ввод Матрица B: ");
//             mass2.WriteMat();

//             Console.WriteLine("Матрица А: ");
//             mass1.ReadMat();
//             Console.WriteLine();
//             Console.WriteLine("Матрица В: ");
//             Console.WriteLine();
//             mass2.ReadMat();

//             Console.WriteLine ("Умножение матриц А и Б: ");
//             mass3 = (mass1 * mass2);
//             mass3.ReadMat ();
//             Console.ReadKey();
//         }
//     }
// }


     
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// задаем трехмерный массив
// int[,,] Random3dArray( int field, int rows, int columns) 
// { 
//     int[,,] newArray = new int[field, rows, columns]; 
//     for(int i = 0; i < field; i++) 
//     // проходим по строкам 
//     { 
//         for(int j = 0; j < rows; j++) 
//         // проходим   по столбцам
//         {
//             for(int k = 0; k < columns; k++)
//             {
//                 newArray[i,j,k] = i + j + k; 
//             } 
//         } 
//     } return newArray;
// } 
// void Show3dArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write("[" + i + "," + j + "]" + array[i, j, k] + " ");
//             }
//             Console.WriteLine(); 
//         }
//         Console.WriteLine();    
//     }
//     Console.WriteLine();
// }
// Console.Write("Введите количество полей: ");
// int n = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: "); 
// int l = Convert.ToInt32(Console.ReadLine()); 
// int[,,] array = Random3dArray(m, n, l);
// Show3dArray(array);
                              


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//задаем массив
int size = 4;
int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;
// проходим по спирали по массиву и расставляем числа
while (num <= size * size)
{
 nums[i, j] = num;
 if (i <= j + 1 && i + j < size - 1)
 ++j;
 else if (i < j && i + j >= size - 1)
 ++i;
 else if (i >= j && i + j > size - 1)
 j--;
 else
 i--;
 num++;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
 Console.Write("[ ");
 for (int j = 0; j < array.GetLength(1); j++)
        {
 Console.Write(array[i, j] + " ");
        }
 Console.Write("]");
 Console.WriteLine("");
    }
}