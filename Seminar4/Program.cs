// Демонстрация решения
// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число для арифметической прогрессии: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// int index = 1;
// int result = 0;

// while (index<=numA)
// {
//     result = result + index;
//     index++;
// }

// Console.WriteLine($"{numA} -> {result}");

//  РЕшение преподавателя

// Console.Write("Введите число для арифметической прогрессии: ");
// int limit = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// for (int i = 1; i <=limit; i++)
// {
//     sum += i; //sum = sum + 1;
// }
// Console.WriteLine($"Сумма чисел от 1 до {limit} = {sum}");




// Решение в группах задач:
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5





// Console.WriteLine("Введите числоя для подсчета количества цифр: ");
// int numA = Convert.ToInt32(Console.ReadLine());

// int result = 0;
// int division = numA;

// while (division > 0)
// {
//     result++; 
//     division = division / 10;
// }
// Console.WriteLine($"В числе {numA} - {result} цифр");

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.Write("Введите число для фактореал: ");
// int limit = Convert.ToInt32(Console.ReadLine());
// int multip = 1;

// for (int i = 1; i <=limit; i++)
// {
//     multip *= i; //multip = multip * 1;
// }
// Console.WriteLine($"Сумма чисел от 1 до {limit} = {multip}");


// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// void FillArray(int[] collection)
// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         collection[index] = new Random().Next(0, 2);
//         index++;
//     }
// }

// void PrintArray(int[] collection2)
// {
//     int count = collection2.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($"{collection2[position]} ");
//         position++;
//     }

// }

// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);

// Решение преподавателя

// int size = 8;
// int[] array = new int[size]; //выделчется память и изнаально масисв заполнить ноялми

// for (int i = 0; i < array.Length; i++)
// {
//     array [i] = new Random().Next(2); //начинаю от 0 иду до 2 второе чило всегда не учитвается то есть по факту минус один
//     //Console.Write(array[i] + "");
// }
//  Console.WriteLine($"Массив: [{string.Join(";", array)}]");
