
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] MakeNewArray (int size, int min, int max)
// {
//     int [] makeNewArray = new int [size];

//     for(int i = 0; i < size; i++)
//     {
//         makeNewArray[i] = new Random().Next(min, max);
//     }
//     return makeNewArray;

// }

// int [] array = MakeNewArray (4, 100, 1000);
// Console.WriteLine($"Массив случайных, положительных, трёхзначных чисел:  [{String.Join("; ", array)}]");

// int countEvenNumbers = 0;

// for (int i = 0; i < array.Length; i++) // или можно указывать переменну size
// {
//     if (array[i] % 2 == 0)
//     {
//         countEvenNumbers++;
//     }
// }

// Console.WriteLine($"Количество четных чисел:  {countEvenNumbers}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int [] MakeNewArray (int size, int min, int max)
// {
//     int [] makeNewArray = new int [size];

//     for(int i = 0; i < size; i++)
//     {
//         makeNewArray[i] = new Random().Next(min, max);
//     }
//     return makeNewArray;

// }

// int [] array = MakeNewArray (4, -99, 100);
// Console.WriteLine($"Массив заполненный случайными двузначными числами:  [{String.Join("; ", array)}]");
// int sumOddPositionElements = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (i % 2 != 0)
//     {
//         sumOddPositionElements = sumOddPositionElements + array[i];
//     }
// }

// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumOddPositionElements}");





// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76





// // ВАРИАНТ 1

// double[] MakeNewArray( int size, int min,int max)
// {
//     double [] makeNewArray = new double [size];
//     for (int i = 0; i < size; i++)
//     {
//         makeNewArray[i] = Math.Round(new Random().NextDouble() + new Random().Next(min,max), 2);
    
//     }
//     return makeNewArray;
// }

// double [] array = MakeNewArray (6, 1, 100);

// Console.WriteLine();
// Console.WriteLine($"Массив: [{String.Join("; ", array)}]");


// double maxNum=array[0];
// double minNum=array[0];
// for (int i = 0; i < array.Length - 1; i++)
// {
//     if (array[i] < array[i+1])
//     {
//         maxNum = array[i+1];
//     }
//     else
//     {
//         minNum = array[i+1];
//     }
        
// }
// Console.WriteLine();
// Console.WriteLine($"Максимальный элемент: {maxNum}  Минимальный элемент: {minNum}" );
// Console.WriteLine();
// Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {Math.Round(maxNum-minNum,2)}" );
// Console.WriteLine();






// ________________________________________________________________________
// // ВАРИАНТ 2 с выбором способа ввода данных


// //Метод создания массива

// double[] MakeNewArray(int size, int min, int max)
// {
//     double[] makeNewArray = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         makeNewArray[i] = Math.Round(new Random().NextDouble() + new Random().Next(min, max), 2);

//     }
//     return makeNewArray;
// }

// //Выбор способа ввода авто или руки

// int choise = 0;
// int size = 0;
// int min = 0;
// int max = 0;
// double[] array = MakeNewArray (0, 0, 0);

// Console.WriteLine("Выберите спосбоб ввода: ");
// choise = Convert.ToInt32(Console.ReadLine());

// if (choise == 1)

// {
//     Console.WriteLine("Задайте длинну массива: ");
//     size = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Задайте минимальноей значение массива: ");
//     min = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Задайте минимальное значение массива: ");
//     max = Convert.ToInt32(Console.ReadLine());

//     array = MakeNewArray(size, min, max);
// }
// else
// {

//     size = new Random().Next(3, 10);
//     min = new Random().Next(-999, 1000);
//     max = new Random().Next(-999, 1000);
//         while (min > max)
//         {
//         min = new Random().Next(-999, 1000);
//         max = new Random().Next(-999, 1000);
//         }
//     array = MakeNewArray(size, min, max);
// }

// Console.WriteLine();
// Console.WriteLine($"Массив: [{String.Join("; ", array)}]");


// // Поиск Максимального и минимального эелемента

// double maxNum = array[0];
// double minNum = array[0];
// for (int i = 0; i < array.Length - 1; i++)
// {
//     if (array[i] < array[i + 1])
//     {
//         maxNum = array[i + 1];
//     }
//     else
//     {
//         minNum = array[i + 1];
//     }

// }
// Console.WriteLine();
// Console.WriteLine($"Максимальный элемент: {maxNum}  Минимальный элемент: {minNum}");
// Console.WriteLine();
// Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {Math.Round(maxNum - minNum, 2)}");
// Console.WriteLine();