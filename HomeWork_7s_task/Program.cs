//  Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
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

Console.Write("Введите колчиество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колчиество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int minRandom = 0;
int maxRandom = 10;
int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);
PrintMatrix(array2D);
Console.WriteLine();


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


Console.Write("Строку: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Столбец: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (m > rows || n > columns)
{
    Console.Write("Такого числа в массиве нет");
}
else
{
Console.WriteLine($"Число по указанной позиции: {array2D[m, n]}");
}


// Проверка и запрос повторного ввода без запвершения программы
// void CheckElement(int ckeckElement)
// {
//     while (true)
//     {
//         Console.Write("Строку: ");
//         int m = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Столбец: ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         if (m < rows || n < columns)
//         {
//             break;
//         }
//         Console.Write("Введите корректное значение: ");

//     }

// }

// CheckElement(array2D);

// Console.WriteLine(array2D[m, n]);

// while
// if (m > rows || n > columns)
//     {
//         Console.WriteLine("Такого значения нет");
//         break;
//     }
// Console.WriteLine(array2D[m, n]);


// 17 -> такого числа в массиве нет
// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
