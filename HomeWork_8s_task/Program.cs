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
//             Console.Write(matrix[i, j] + "\t");
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
//             Console.Write(matrix[i, j] + "\t");
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
//             Console.Write(matrix[i, j] + "\t");
//         }
//         if (rowSum < minRowSum)
//         {
//             minRowSum = rowSum;
//             minRowIndex = i;
//         }
//         Console.Write($"Сумма элементов строки {i+1 }: {rowSum}");
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

// int[,] matrixMultiplication = TwoMatrixMathMultiplication(rows,columns, matrixFirst, matrixSecond);
// PrintMatrix(matrixMultiplication);

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
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// // Вариант 1 не математический

// int[,] TwoMatrixMultiplication(int m, int n, int[,] matrixFirst, int[,] matrixSecond)
// {
//     int[,] matrix = new int[m, n];
//     Console.WriteLine("Умножение элеметов массивов: ");
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = matrixFirst[i, j] * matrixSecond[i, j];
//             Console.Write(matrix[i, j] + "\t");
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


// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение для губины: ");
// int depth = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// int[,,] matrix = GetRandomMatrix3D(rows, columns, depth, 1, 9);

// PrintMatrix3D(matrix);


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
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,,] GetRandomMatrix3D(int m, int n, int o, int min, int max)
// {
//     int[,,] matrix3D = new int[m, n, o];


//     for (int i = 0; i < matrix3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix3D.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix3D.GetLength(2); k++)
//             {
//                 matrix3D[i, j, k] = new Random().Next(min, max + 1);

//                 if (ArrayCheckNumber(matrix3D, matrix3D[i, j, k]) == true)
//                 {
//                     matrix3D[i, j, k] = new Random().Next(min, max + 1);
//                 }
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
//                 Console.Write($"{matrix3D[i, j, k]} ({i},{j},{k})" + "\t");

//             }
//             Console.WriteLine();
//         }

//     }
//     Console.WriteLine();
// }

// bool ArrayCheckNumber(int[,,] arr, int number)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 if (arr[i, j, k] == number)
//                     return true;
//             }
//         }
//     }
//     return false;
// }




//НЕ раюотает

// Задача 62: Заполните спирально массив 4 на 4.


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] matrix = GetRandomMatrix(rows, columns, 10, 40);

Spiral(rows, columns, 10, 40);

int[,] GetRandomMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.Write("Массив: ");
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void Spiral(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int roundCount = 0; roundCount < matrix.GetLength(0)/2; roundCount++)
    {
        for (int j = roundCount; j <= matrix.GetLength(0) - roundCount - 1; j++)
        {
            matrix[roundCount, j] = roundCount + j + 1;
            Console.Write(matrix[roundCount, j] + "\t");
        }
    }

}
