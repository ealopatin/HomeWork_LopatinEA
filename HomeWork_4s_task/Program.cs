//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// 1 вариант
// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень: ");
// int B = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Результат: {Math.Pow(A,B)}");

// 2 вариант
// Console.Write("Введите число: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// double result = 0;

// for (int a = 0; a <= numB; a++)
// {
//     result = Math.Pow(numA, a);
// }
// Console.WriteLine(result);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int result = A;
// int temp = A;
// int sum = 0;

// while (temp > 0)
// {
//     result = temp % 10;
//     temp = temp / 10;
//     sum = sum + result;
// }

// Console.WriteLine($"Сумма цифр в числе равна: {sum}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов в диапазоне 
// от 10 до 1000и выводит их на экран.
//Или массив вводится с консоли
//  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]


// Console.Write("Выберите способ заполнения массива 1 - Aвтоматически, 2 - Вручную : ");
// int choise = Convert.ToInt32(Console.ReadLine());
// if (choise > 2 | choise < 0)
// {
//     Console.Write("Некорректное значение");
// }
// else if (choise == 1)
// {
//     int size = 8;
//     int[] array = new int[size];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(10, 1001);

//     }
//     Console.WriteLine($"Массив: [{string.Join(";", array)}]");
// }
// else
// {
//     int size = 8;
//     int[] array = new int[size];

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"Введите элемент массива №{i}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }

//     Console.WriteLine($"Массив: [{string.Join(";", array)}]");
// }