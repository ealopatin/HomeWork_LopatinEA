//  Задача 19: Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


// Console.WriteLine("Введите пятичзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());


// if (num < 9999 || num > 99999)
// {
//     Console.WriteLine("Число содержит больше или меньше 5 знаков");
// }
// else if(num/10000 == num % 10 && (num/1000)%10 == num/10%10)
// {
//      Console.WriteLine($"{num} => ДА");
// }
// else
// {
//     Console.WriteLine($"{num} => НЕТ");
// }




// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и
//  находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

// Console.Write("Веедите координаты первой точки x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Веедите координаты первой точки y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Веедите координаты первой точки z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Веедите координаты второй точки x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Веедите координаты второй точки y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Веедите координаты второй точки z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double distance = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 -y1, 2) + Math.Pow(z2-z1,2)), 2);

// Console.Write($"Расстояние между двумя точками в пространстве: {distance}");

// Задача 23: Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Веедите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.Write($"Таблица кубов чисел от 1 до {N}: ");

// for (int index = 1; index < N; index++)
// {
//     Console.Write(Math.Pow(index, 3) + " ");
// }







//*******Доп задание

// Вариант 1

// Console.Write("Введите пять символов: ");
// string stringNumber = Console.ReadLine();

// if (stringNumber[0]==stringNumber[4] && stringNumber[1]==stringNumber[3])
// {
//     Console.WriteLine($"{stringNumber} это полиндром");
// }
// else
// {
//     Console.WriteLine($"{stringNumber} это НЕ полиндром");
// }


//Вариант 2 Поиск полиндрома для неограниченного числа символов

// Console.Write("Введите любое количество символов для проверки на полиндром: ");
// string str = Console.ReadLine();
// int indexstart = 0;
// int indexend = str.Length-1;
// int emergencyStop = 0;

// while (indexstart<indexend)
// {
//    if (str[indexstart]==str[indexend])
//     {
//         indexstart++;
//         indexend--;
//     }
//     else
//     {
//     emergencyStop = 1;
//     break;
//     }
// }

// if (emergencyStop == 1)
// {
//     Console.WriteLine($"{str} - Это НЕ полиндром!");
// }
// else
// {
//     Console.WriteLine($"{str} - Это полиндром!");
// }



