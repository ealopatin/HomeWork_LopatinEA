// Задача 39: Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на первом месте,
//  а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] NewArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
// //     {
// //         array[i] = new Random().Next(min, max+1);
// //     }
// //     return array;
// // }

// // int[] array = NewArray(5, 1, 10);

// // Console.WriteLine($"Массив: [{String.Join("; ", array)}]");

// // // PrintArray(ReverseArray(array));

// // int[] ReverseArray(int[] array)

// // {

// //     int[] reverseArray = new int[array.Length];
// //     int size = array.Length;
// //     int j = size-1;
// //     int temp = 0;

// //     for (int i = 0; i < j; i++, j--)
// //     {
// //         temp = array[i];
// //         array[i] = array[j];
// //         array[j] = temp;
// //     }
// //     return reverseArray;
// // }


// // Console.WriteLine($"Массив: [{String.Join("; ", ReverseArray(array))}]");



// // //решение преподавателя


// int[] NewArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }


// void PrintArray(int[] arr)
// {
//     // foreach (int item in arr) //автоматический обход всех символов без условий
//     // {
//     //     Console.Write(item + ".."); 
//     // }

//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + "\t");

//     }
//     Console.Write("]");
// }

// int[] result = NewArray(9, 0, 15);

// PrintArray(result);

// // Console.WriteLine();

// // PrintArray(CopyArray(result));

// // // //1. Запись в новый массив

// int[] CopyArray (int[] array)
// {
//     int[] copyArray = new int [array.Length];
//     int size = array.Length;

//     for (int start = 0, end = size-1; start < size; start++,end--)
//     {
//         copyArray[start] = array[end];    
//     }
//     return copyArray;
// }

// void ReverseArray (int [] array)
// {
//     int size= array.Length;
//     for (int i = 0, j = size - 1; j < size/2; i++, j--)
//     {
//             int temp = array [i];
//             array[i] = array[j];
//             array[j] = temp;
        
//     }
// }

// Console.WriteLine();
// ReverseArray(result);
// PrintArray(result);



// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

// еорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.


// int a = 9;
// int b = 4;
// int c = 5;

// bool IsTriangle(int a, int b, int c)
// {
//     return (((a+b)> c) && ((b+c)> a) && ((b+c)> a));
// }
// if (IsTriangle(a,b,c))
// {
//     Console.WriteLine("Треугольник существует");
// }
// else
// {
//     Console.WriteLine("Треугольник НЕ существует");
// }


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 2)
// {
//     return;
// }
// int[] fibonacci = new int[N];
// fibonacci[0] = 0;
// fibonacci[1] = 1;

// for (int i = 2; i < N; i++)
// {
//     fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];
// }

// Console.WriteLine($"Массив: {string.Join("; ", fibonacci)}");

