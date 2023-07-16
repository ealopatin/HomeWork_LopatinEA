// int number = 4;

// void ConverToBinary(int number)
// {
//     if (number == 0)
//     {
//         return;
//     }
//     ConvertToBinary(number / 2);
//     Console.Write(number %  2);

// }

// ConvertToBinary(number);


// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


// Console.Write("Введите колчиество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите колчиество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());


// int minRandom = 0;
// int maxRandom = 10;
// int [,] array2D = GetMatrix(rows,columns,minRandom,maxRandom);
// PrintMatrix (array2D);

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
//    }

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// Console.Write("Введите колчиество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите колчиество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());


// int minRandom = 0;
// int maxRandom = 10;
// int [,] array2D = GetMatrix(rows,columns,minRandom,maxRandom);
// PrintMatrix (array2D);


// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; //m строки 
//     for (int i = 0; i < matrix.GetLength(0); i++) //m цикл по строкам //GetMAtrix.GetLength(0) сколько строк //GetMAtrix.GetLength(0) сколько сстольбцов
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) //n цикл по столбцам 
//         {
//             matrix[i, j] = i + j;
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
//  }


// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


// Console.Write("Введите колчиество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите колчиество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минчисло: ");
// int minRandom = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите макс число: ");
// int maxRandom = Convert.ToInt32(Console.ReadLine());


// int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);

// PrintMatrix(array2D);
// Console.WriteLine();

// EvenIndexSquare(array2D);
// PrintMatrix (array2D);



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

// int[,] EvenIndexSquare(int [,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++) //m цикл по строкам //GetMAtrix.GetLength(0) сколько строк //GetMAtrix.GetLength(0) сколько сстольбцов
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) //n цикл по столбцам 
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matrix[i, j] *= matrix[i, j]; //matrix[i, j] * matrix[i, j]
//             }
//         }
//     }
//     return matrix;
// }


// решение преподавателя

// int [,] ChangeMatrix (int[,]matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i+=2) //m цикл по строкам //GetMAtrix.GetLength(0) сколько строк //GetMAtrix.GetLength(0) сколько сстольбцов
//     {
//         for (int j = 0; j < matrix.GetLength(1); j+=2) //n цикл по столбцам 
//         {
//             // if (i % 2 == 0 && j % 2 == 0)
//             // {
//             matrix[i, j] *= matrix[i, j]; //matrix[i, j] * matrix[i, j]
//             // }
//         }
//     }
//     return matrix;
// }


// PrintMatrix(ChangeMatrix(array2D));


// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1; 1) и т.д.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12


Console.Write("Введите колчиество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колчиество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минчисло: ");
int minRandom = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите макс число: ");
int maxRandom = Convert.ToInt32(Console.ReadLine());


int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);

PrintMatrix(array2D);
Console.WriteLine();

SumElementOnMainDiagonal(array2D);


int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n]; //m строки 
    for (int i = 0; i < matrix.GetLength(0); i++) //m цикл по строкам //GetMAtrix.GetLength(0) сколько строк //GetMAtrix.GetLength(0) сколько сстольбцов
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //n цикл по столбцам 
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int SumElementOnMainDiagonal(int[,] matrix)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                result = result + matrix[i, j];
            }
        }
    }
    return result;
}

