// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.


// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// int[,] matrix = GetRandomMatrix(rows, columns, 1, 10);

// PrintMatrix(matrix);

// int[,] RowsDescendingSortMatrix = MatrixRowsDescendingSort(matrix);

// PrintMatrix(RowsDescendingSortMatrix);

// int[,] GetRandomMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     Console.Write("Массив: ");
//     Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write("{0,3}   ", matrix[i, j]);
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] MatrixRowsDescendingSort(int[,] matrix)
// {
//     int temp = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if (matrix[i, k] < matrix[i, k + 1])
//                 {
//                     {
//                         temp = matrix[i, k];
//                         matrix[i, k] = matrix[i, k + 1];
//                         matrix[i, j + 1] = temp;
//                     }
//                 }

//             }
//         }

//     }
//     return matrix;
// }



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// int[,] matrix = GetRandomMatrix(rows, columns, 1, 10);

// PrintMatrix(matrix);

// FindMinSumRowIndex(matrix);


// int[,] GetRandomMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     Console.Write("Массив: ");
//     Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write("{0,3} ", matrix[i, j]);
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void FindMinSumRowIndex(int[,] matrix)
// {
//     int minRowSum = int.MaxValue;
//     int rowSum = 0;
//     int minRowIndex = 0;

//     Console.WriteLine($"Сложение элементов массива:");
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         rowSum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             rowSum += matrix[i, j];
//             Console.Write("{0,3} ", matrix[i, j]);
//         }
//         if (rowSum < minRowSum)
//         {
//             minRowSum = rowSum;
//             minRowIndex = i;
//         }
//         Console.Write($"   Сумма элементов строки {i+1 }: {rowSum}");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Строка номер: {minRowIndex + 1} является строкой с наименьшей суммой элементов: {minRowSum}");
//     Console.WriteLine();
// }


// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// int[,] matrixFirst = GetRandomMatrix(rows, columns, 1, 10);
// int[,] matrixSecond = GetRandomMatrix(rows, columns, 1, 10);

// PrintMatrix(matrixFirst);
// PrintMatrix(matrixSecond);

// TwoMatrixMultiplication(rows,columns, matrixFirst, matrixSecond);

// // int[,] matrixMultiplication = TwoMatrixMathMultiplication(rows,columns, matrixFirst, matrixSecond);
// // PrintMatrix(matrixMultiplication);

// int[,] GetRandomMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     Console.Write("Массив: ");
//     Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write("{0,3}   ", matrix[i, j]);
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// // // Вариант 1 не математический

// int[,] TwoMatrixMultiplication(int m, int n, int[,] matrixFirst, int[,] matrixSecond)
// {
//     int[,] matrix = new int[m, n];
//     Console.WriteLine("Умножение элеметов массивов: ");
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = matrixFirst[i, j] * matrixSecond[i, j];
//             Console.Write("{0,3}   ", matrix[i, j]);
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return matrix;
//     }

// // Вариант 2 математический

// int[,] TwoMatrixMathMultiplication(int m, int n, int[,] matrixFirst, int[,] matrixSecond)
// {
//     int[,] matrixMultip = new int[m, n];
//     Console.WriteLine("Умножение массивов строка на столбец ");
//     for (int i = 0; i < matrixMultip.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixMultip.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < matrixFirst.GetLength(1); k++)
//             {
//                 sum += matrixFirst[i, k] * matrixSecond[k, j];
//             }
//             matrixMultip[i, j] = sum;
//         }
//     }
//     return matrixMultip;
// }



// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



// int rows = 2;
// int columns = 2;
// int depth = 2;

// Console.WriteLine($"Количество строк: {rows}");
// Console.WriteLine($"Количество столбцов: {columns}");
// Console.WriteLine($"Значение глубины: {depth}");

// Console.WriteLine();

// int[,,] matrix = GetRandomMatrix3D(rows, columns, depth, 10, 99);

// PrintMatrix3D(matrix);

// int[,,] GetRandomMatrix3D(int m, int n, int o, int min, int max)
// {
//     int[,,] matrix3D = new int[m, n, o];

//     for (int i = 0; i < matrix3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix3D.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix3D.GetLength(2); k++)
//             {
//                 int number = new Random().Next(min, max + 1);
//                 while (ArrayCheckNumber(matrix3D, number))
//                 {
//                     number = new Random().Next(min, max + 1);
//                 }
//                 matrix3D[i, j, k] = number;
//             }
//         }
//     }
//     return matrix3D;

// }

// void PrintMatrix3D(int[,,] matrix3D)
// {
//     Console.Write("Массив: ");
//     Console.WriteLine();
//     for (int i = 0; i < matrix3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix3D.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix3D.GetLength(2); k++)
//             {
//                 Console.Write("{0,3}   ", $"{matrix3D[i, j, k]} ({i},{j},{k})");
                
//             }
//             Console.WriteLine();
//         }

//     }
//     Console.WriteLine();
// }

// bool ArrayCheckNumber(int[,,] array, int number)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i, j, k] == number)
//                     return true;
//             }
//         }
//     }
//     return false;
// }





// Задача 62: Заполните спирально массив 4 на 4.


/* 

Сильно не доработано,
решение без метода 
p.s НЕ раюотает с 3 и 6, 4 и 3
но кое что работает...

*/


// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[,] spiralArray = new int[colums, rows];

// int[] sortArray = new int[spiralArray.GetLength(0) * spiralArray.GetLength(1) + 1];

// for (int o = 0; o < spiralArray.Length; o++)
// {
//     int number = new Random().Next(spiralArray.GetLength(0) * spiralArray.GetLength(1) + 1);
//     while(ArrayCheckNumber(sortArray,number))
//     {
//         number = new Random().Next(spiralArray.GetLength(0) * spiralArray.GetLength(1) + 1);
//     }
//     sortArray[o] = number;
// }

// Array.Sort(sortArray);

// PrintArray(sortArray);
// Console.WriteLine();

// int k = 1;
// int t = 0;
// int i;
// int j = 0;
// int n = rows;
// int m = colums;

// while (k <= n * m)
// {
//     for (i = t; i < rows; i++)
//         spiralArray[j, i] = sortArray[k++];
//     j = rows - 1;

//     for (i = t + 1; i < colums; i++)
//         spiralArray[i, j] = sortArray[k++];
//     j = colums - 1;

//     for (i = rows - 2; i >= t; i--)
//         spiralArray[j, i] = sortArray[k++];
//     j = t;

//     for (i = colums - 2; i > t; i--)
//         spiralArray[i, j] = sortArray[k++];

//     rows--;
//     colums--;
//     t++;
//     j = t;
// }

// for (i = 0; i < spiralArray.GetLength(0); i++)
// {
//     for (j = 0; j < spiralArray.GetLength(1); j++)
//     {
//         Console.Write("{0,3} ", spiralArray[i, j]);
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// void PrintArray(int[] array)
// {
//     Console.Write("Массив: ");
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write(array[i] + "\t");
//     }
//     Console.WriteLine();
// }

// bool ArrayCheckNumber(int[] array, int number)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if (array[i] == number)
//         return true;
//     }
//     return false;
// }



