//  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1


// Console.Write("Введите пожалуйста трехзначное число, а мы покажем его вторую цифру: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num} -> {(num % 100)/10}");


//______________________________________________________________________________________________________________________________________________

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.Write("Введите пожалуйста число, а мы покажем его третью цифру: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = num;

// if (count<100)
// {
//     Console.WriteLine($"{num} третьей цифры нет");
// } 
// else
// {
//     while (count>1000)
//     {
//     count = count / 10;
//     }
//     Console.WriteLine($"{num} -> {count % 10}");
// }


//______________________________________________________________________________________________________________________________________________
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет



// Console.Write("Давайте проверим выходной или нет, введите цифры от 1 до 7: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num<1 | num>7)
// {
//     Console.Write($"{num} не соответствует дню недели");
// }
// else
// {
//     if(num>5)
//     {
//         Console.Write($"{num}-> Да");
//     }
//     else
//     {
//         Console.Write($"{num}-> Нет");
//     }
// }




//______________________________________________________________________________________________________________________________________________
// *Дополнительно*

// Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел 
// от 10 до 1000(999 - последнее). (каждый эл-т массива – сгенерирован случайно)

// Пример для 1 элемента массива: 591, сумма: 5+9+1 = 15; произведение: 5*9*1 = 45; 45 / 15 - делится НАЦЕЛО, число "интересное"

// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]


// // Вариант 1 

// int lenght = 10; // неободимая длинна массива;
// int index = 0;   // счетчик попыток подбора интересного числа;
// int count = 0;   // количество чисел в массиве;

// int number = 0;
// int sum = 0;
// int multip = 0;

// Console.Write("[");

// while (count < lenght)
// {
//       number = new Random().Next(10, 1000);

//     if (number < 100)
//     {
//         multip = (number / 10) * (number % 10);
//         sum = (number / 10) + (number % 10);
//     }
//     else
//     {
//         multip = (number / 100) * ((number / 10) % 10) * (number % 10);
//         sum = (number / 100) + ((number / 10) % 10) + (number % 10);
//     }

//     if (multip == 0)
//     {
//         index++;
//     }
//     else
//     {   
//         if (multip % sum == 0)
//         {
//             Console.Write($"{number}, ");
//             count++;
//             index++;
//         }
//         else
//         {
//             index++;
//         }
//     }
// }

// Console.Write("]");

// Console.WriteLine($"   Количество попыток:  {index}");











//______________________________________________________________________________________________________________________________________________
//______________________________________________________________________________________________________________________________________________

// Вариант 2. НЕ РАБОТАЕТ  НЕ РАБОТАЕТ  НЕ РАБОТАЕТ  НЕ РАБОТАЕТ  НЕ РАБОТАЕТ  НЕ РАБОТАЕТ  НЕ РАБОТАЕТ  НЕ РАБОТАЕТ  НЕ РАБОТАЕТ  

// void FillArray(int[] collect)
// {
//     int lenght = collect.Length;
//     int index = 0;
//     int number = 0;
//     int sum = 0;
//     int multip = 0;

//     while (index < lenght)
//     {
//         number = new Random().Next(10, 1000);

//         if (number < 100)
//         {
//             multip = (number / 10) * (number % 10);
//             sum = (number / 10) + (number % 10);
//         }
//         else
//         {
//             multip = (number / 100) * ((number / 10) % 10) * (number % 10);
//             sum = (number / 100) + ((number / 10) % 10) + (number % 10);
//         }

//         if (multip % sum == 0)
//         {
//             collect[index] = number;
//             index++;
//         }
//         else
//         {
//             index++;
//         }

//     }
// }

// void PrintArray(int[] collection2)
// {
//     int count = collection2.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(collection2[position]);
//         position++;
//     }

// }

// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);








//леция//леция//леция//леция//леция//леция//леция//леция//леция//леция//леция//леция//леция//леция//леция//леция//леция//леция//леция



// void FillArray(int[] collection)
// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }

// void PrintArray(int[] collection2)
// {
//     int count = collection2.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(collection2[position]);
//         position++;
//     }

// }

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1;

//     while (index < count)
//     {
//         if (collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }

// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// Console.Write(pos);
