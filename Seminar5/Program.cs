// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// int size = 12;
// int[] array = new int[size];
// int positiveSum = 0;
// int nagativeSum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);

//     if (array[i] > 0)
//     {
//         positiveSum = positiveSum + array[i];
//     }
//     else
//     {
//         nagativeSum = nagativeSum + array[i];
//     }
// }

// Console.WriteLine($"Массив случайных чисел: [{string.Join(";", array)}]");
// Console.WriteLine($"Сумма положительных числе в массиве: {positiveSum}");
// Console.WriteLine($"Сумма отрицательных числе в массиве: {nagativeSum}");


// Решение преподавателя

// int size = 12;
// int[] array = new int[size];
// int sumPositive = 0;
// int sumNegative = 0;

// for (int i = 0; i < array.Length; i++) // или можно указывать переменну size
// {
//     array[i] = new Random().Next(-9, 10);

//     if (array[i] > 0)
//     {
//         sumPositive += array[i];
//     }
//     else
//     {
//         sumNegative += array[i];
//     }
// }
// Console.WriteLine($"Массив: [ {string.Join(";", array)} ]");

// Console.WriteLine($"Сумма положительных {sumPositive}");
// Console.WriteLine($"Сумма положительных {sumNegative}");

// Методы

// Void 
// и 
// не Void


// Задача 32: Напишите программу замена элементов массива:
//  положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i]*(-1);
// }
// синтаксис метода тип возвращаемой задачи, имя метода, параметр 1, параметр2

// int[] GetArray(int size, int min, int max)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i ++)
//     {
//         result[i] = new Random().Next(min,max+1);
//     }

//     return result;
// }

// int [] array = GetArray(7 ,-10, 10); 

// Console.WriteLine($"Массив: [ {string.Join(";", array)} ]");

// int [] InverseArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }
// Console.WriteLine($"Инвертированный массив: [ {string.Join(";", InverseArray(array))} ]");


// Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив[6, 7, 19, 345, 3]->нет
// - 3; массив[6, 7, 19, 345, 3]->да

// int[] NewArray(int size, int min, int max)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max);
//     }
//     return result;
// }

// int[] array = NewArray(4, 0, 11);
// Console.WriteLine($"Массив: [ {string.Join(";", array)} ]");

// int element = 10;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == element)
//     {
//         Console.WriteLine($"Число {element} в массиве присутствует");
//     }
//     else
//     {
//         Console.WriteLine($"Число {element} в массиве отсутствует");
//     }
// }

// bool FindElement(int[]arr, int element)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == element)
//         {
//             return true;
//         }   
//     }
//     return false;
// }
// int numberForSearch = 10;
// if (FindElement(array, numberForSearch))
// {
//     Console.WriteLine($"Элемент {numberForSearch} присутствует в массиве");
// }
// else
// {
//         Console.WriteLine($"Элемент {numberForSearch} отсутствует в массиве");
// }


// // Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// // Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// // Результат запишите в новом массиве.
// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21

// int[] GetArray(int size, int min, int max)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i ++)
//     {
//         result[i] = new Random().Next(min,max+1);
//     }

//     return result;
// }
// int[] array = GetArray(5, 0, 10);
// Console.WriteLine($"Массив: [ {string.Join(";", array)} ]");


// int[] MultiplyingArrays (int[] array)
// {
//     int sizeNewArray = array.Length/2 + array.Length % 2;
//     //4 / 2 + 0 = 2 + 0
//     //5 / 2 + 1 = 3
//     int[] newArray = new int[sizeNewArray];

//     for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
//     {
//         newArray [i] = array[i] * array[j];
//     }
//     if (array.Length % 2 == 1)
//     {
//         newArray[sizeNewArray - 1] = array[array.Length / 2];

//     }
//     return newArray;
// }
// Console.WriteLine($"Массив: [ {string.Join(";", MultiplyingArrays(array))} ]");

// // int [] InverseArray (int[] array)
// // {
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         array[i] *= -1;
// //     }
// //     return array;
// // }
// // Console.WriteLine($"Инвертированный массив: [ {string.Join(";", InverseArray(array))} ]");


// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size]; // Массив на size элементов
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }

    return result; // Массив, который заполнили числами в диапазоне от min до max
}
// Массив на 7 элементов, каждый элемент - число от 0 до 10 (рандомное)
int[] array = GetArray(5, 0, 10); // size = 10, min = 0, max = 10
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");

// PascalCase - для методов, каждое слово в вашей переменной идет с большой буквы
// camelCase - первая буква - маленькая, остальные - заглавные

int[] MultiplyingArrays(int[] array)
{
    int sizeNewArray = array.Length / 2 + array.Length % 2;

    int[] newArray = new int[sizeNewArray];
    // i - номер элемента с левого края (первого элемента)
    // j - номер элемента с правого края (последний элемент массива)
    // задаем переменную1,переменную2 ; условие1, условие2 ; увел-е переменных или уменьшение
    for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
    {
        newArray[i] = array[i] * array[j];
    }

    if (array.Length % 2 == 1) // Размер массива - нечетное число
    {
        newArray[sizeNewArray - 1] = array[array.Length / 2];
    }

    return newArray;
}

Console.WriteLine($"Результат: [ {string.Join("; ", MultiplyingArrays(array))} ]");