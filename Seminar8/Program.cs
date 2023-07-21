// Решение домашки преподавателем


// Решение задач в группах
// Задача 53: Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую и последнюю строку массива.

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// int[,] matrix = GetRandomMatrix(rows, columns, 1, 10);

// PrintMatrix(matrix);

// int [,] replaceMatrix = FirstAndLastRawsReplace(matrix);

// PrintMatrix(replaceMatrix);


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

// int [,] FirstAndLastRawsReplace(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == 0)
//             {
//                 int temp = 0;
//                 temp = matrix[i,j];
//                 matrix[i,j] = matrix[matrix.GetLength(0)-1,j];
//                 matrix[matrix.GetLength(0)-1,j] = temp;
//             }
//         }
//     }
//     return matrix;
// }






// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 

// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// int[,] matrix = GetRandomMatrix(rows, columns, 1, 10);

// PrintMatrix(matrix);

// int[,] replaceRawsToColumnsMatrix = RawToColumnsReplace(matrix);

// PrintMatrix(replaceRawsToColumnsMatrix);

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

// int [,] RawToColumnsReplace(int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = matrix[j,i];
//         }
//     }
//     return matrix;
// }


// рещшение преподавателя

// транспонирование матриц

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// if (rows != columns) //! =
// {
//     Console.WriteLine("Ошибка");
//     return;
// }

// int[,] matrix = GetRandomMatrix(rows, columns, 1, 10);

// PrintMatrix(matrix);

// int [,] RawToColumnsMatrix = RawToColumnsReplace (matrix);

// PrintMatrix(RawToColumnsMatrix);

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


// int [,] RawToColumnsReplace(int [,] matrix)
// {
//     int [,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             result[j,i] = matrix[i,j];
//         }
//     }
//     return result;
// }




// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
//  Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза



// Решение в группах задач:
// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7



Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();


int[,] matrix = GetRandomMatrix(rows, columns, 1, 10);

PrintMatrix(matrix);


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

int[,] DeleteMinRawColumn(int[,] matrix)
{
    int minNumber = int.MaxValue;
    int minrowindex = 0;
    int mincolumnindex = 0;
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            if (minNumber > matrix[i, j])
            {
                minNumber = matrix[i, j];
                minrowindex = i;
                mincolumnindex = j;
            }
             
        }
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if(i != minrowindex)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(j != mincolumnindex)
                {

                }
            }
        }
    }
        
}


// Дополнительная задача:

// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

