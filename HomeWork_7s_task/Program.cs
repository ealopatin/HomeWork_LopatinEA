﻿//  Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.Write("Введите колчиество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите колчиество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int minRandom = -99;
// int maxRandom = 100;
// int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);
// PrintMatrix(array2D);


// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; //m строки 
//     for (int i = 0; i < matrix.GetLength(0); i++) //m цикл по строкам //GetMAtrix.GetLength(0) сколько строк //GetMAtrix.GetLength(0) сколько сстольбцов
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) //n цикл по столбцам 
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Вариант 1. 
// Проверка без метода
// ______________________________________________________

// Console.Write("Введите колчиество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите колчиество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();


// int minRandom = 0;
// int maxRandom = 10;
// int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);
// PrintMatrix(array2D);
// Console.WriteLine();


// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; //m строки 
//     for (int i = 0; i < matrix.GetLength(0); i++) //m цикл по строкам //GetMAtrix.GetLength(0) сколько строк //GetMAtrix.GetLength(0) сколько сстольбцов
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) //n цикл по столбцам 
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }


// Console.Write("Строку: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// Console.Write("Столбец: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// if (m > rows || n > columns)
// {
//     Console.Write("Такого числа в массиве нет");
// }
// else
// {
// Console.WriteLine($"Число по указанной позиции: {array2D[m, n]}");
// }


// 2 Вариант 
// Проверка и запрос повторного ввода без завершения программы
// ______________________________________________________

// Console.Write("Введите колчиество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите колчиество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int minRandom = 0;
// int maxRandom = 10;
// int rowsIndex = 0;
// int columnsIndex = 0;

// int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);

// PrintMatrix(array2D);
// Console.WriteLine();

// CheckIndexElement(rowsIndex,columnsIndex);
// Console.WriteLine($"Число по указанной позиции: {array2D[rowsIndex, columnsIndex]}");


// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; //m строки 
//     for (int i = 0; i < matrix.GetLength(0); i++) //m цикл по строкам //GetMAtrix.GetLength(0) сколько строк //GetMAtrix.GetLength(0) сколько сстольбцов
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) //n цикл по столбцам 
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// void CheckIndexElement(int crowsIndexCheck, int columnsIndexCheck)
// {
//     while (true)
//     {
//         Console.Write("Введите индекс строки: ");
//         rowsIndex = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Введите индекс столбца: ");
//         columnsIndex = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine();

//         if ((rowsIndex >= 0 && rowsIndex < rows) && (columnsIndex >= 0 && columnsIndex < columns))
//         {
//             break;
//         }
//         Console.WriteLine("Такого числа в массиве нет.");
//         Console.WriteLine();
//         Console.Write($"Введите корректные значения позиции элемента - не более {rows-1} для строк и не более {columns-1} для столбцов.");
//         Console.WriteLine();

//     }

// }






// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Вариант 1 Без метода
// ______________________________________________________

// Console.WriteLine();
// Console.Write("Введите колчиество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите колчиество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int minRandom = 1;
// int maxRandom = 10;
// int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);

// Console.WriteLine("Массив:");
// Console.WriteLine();

// PrintMatrix(array2D);
// Console.WriteLine();

// double rowsAverage = 0;

// for (int i = 0; i < array2D.GetLength(0); i++)
// {
//     for (int j = 0; j < array2D.GetLength(1); j++)
//     {
//         rowsAverage = rowsAverage + array2D[i,j];
//     }
//     Console.Write($"Строка: {i} - Сумма: {rowsAverage}");
//     Console.Write($" Среднее арифметическое: {Math.Round(rowsAverage/array2D.GetLength(1),2)}");
//     Console.WriteLine();
//     rowsAverage = 0;
// }
// Console.WriteLine();

// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; //m строки 
//     for (int i = 0; i < matrix.GetLength(0); i++) //m цикл по строкам //GetMAtrix.GetLength(0) сколько строк //GetMAtrix.GetLength(0) сколько сстольбцов
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) //n цикл по столбцам 
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }





// Вариант 2 черех метод
// ______________________________________________________

// Console.WriteLine();
// Console.Write("Введите колчиество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите колчиество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int minRandom = 1;
// int maxRandom = 10;
// int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);

// Console.WriteLine("Массив:");
// Console.WriteLine();

// PrintMatrix(array2D);
// Console.WriteLine();


// RowsAverage(array2D);

// void RowsAverage(int[,] matrix)
// {
//     double[] rowsAVG = new double[matrix.GetLength(1)];

//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         double rowsSum = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             rowsSum = rowsSum + matrix[i, j];
//         }
//         rowsAVG[j]= Math.Round(rowsSum / matrix.GetLength(0),2);
//         Console.Write($"Столбца: {j} - Сумма: {rowsSum}");
//         Console.Write($" Среднее арифметическое: {rowsAVG[j]}");
//         Console.WriteLine();

//     }
// }

// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; //m строки 
//     for (int i = 0; i < matrix.GetLength(0); i++) //m цикл по строкам //GetMAtrix.GetLength(0) сколько строк //GetMAtrix.GetLength(0) сколько сстольбцов
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) //n цикл по столбцам 
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine();



// Вариант 3 метов методе
// ______________________________________________________

// Console.WriteLine();
// Console.Write("Введите колчиество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите колчиество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int minRandom = 1;
// int maxRandom = 10;
// int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);

// Console.WriteLine("Массив:");
// Console.WriteLine();

// PrintMatrix(array2D);
// Console.WriteLine();


// RowsAverage(array2D);


// void PrintResult(double rowsSum, double[] rowsAVG, int j)
// {      
//         Console.Write($"Столбца: {j} - Сумма: {rowsSum}");
//         Console.Write($" Среднее арифметическое: {rowsAVG[j]}");
//         Console.WriteLine();
// }

// void RowsAverage(int[,] matrix)
// {
//     double[] rowsAVG = new double[matrix.GetLength(1)];

//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         double rowsSum = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             rowsSum = rowsSum + matrix[i, j];
//         }
//         rowsAVG[j]= Math.Round(rowsSum / matrix.GetLength(0),2);
//         PrintResult(rowsSum, rowsAVG, j);
            
//     }
// }

// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; //m строки 
//     for (int i = 0; i < matrix.GetLength(0); i++) //m цикл по строкам //GetMAtrix.GetLength(0) сколько строк //GetMAtrix.GetLength(0) сколько сстольбцов
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) //n цикл по столбцам 
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine();
