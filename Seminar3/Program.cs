// //проверка вводка цифр и букв

// //вводится строка хочу узнать состоит она из цифр или нет

// Console.Write("Введите число: ");
// string stringNumber = Console.ReadLine();

// int number; //переменная в которую будет втавляться конвертированная строчка

// bool isNumber = int.TryParse(stringNumber, out number);

// //проверяю stringNumber: состоит ли точка только из цифр

// // если стостоит - isNUmber = true; а в переменную number - само число
// // Если не состоит то isNumber = false; а в переменнуб Number = 0;

// if (isNumber) 
// {
//     Console.WriteLine($"В смтрочке {stringNumber}находятся толко цифры!");

// }
// else
// {
//     Console.WriteLine($"В строчке {stringNumber} находятся символы");
//     Console.WriteLine(number);
// }

// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// 21
// 34

// Console.Write("Веедите X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Веедите Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int result = 0;


// if (x < 0 && y > 0)
// {
//     result = 2;
// }
// else if (x > 0 && y > 0)
// {
//     result = 1;
// }
// else if (x > 0 && y < 0)
// {
//     result = 4;
// }
// else if (x < 0 && y < 0)
// {
//     result = 4;
// }
// else
// {
//     Console.WriteLine($"Вы попали в одну из осей");
// }
// Console.WriteLine($"Точка с координатами: ({x};{y}) находится в {result} четверти.");

// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).


//  Console.Write("Веедите номер четверти: ");
//  int quater = Convert.ToInt32(Console.ReadLine());
// string result = "Неверный номер четверти";

//  if (quater == 1)
// {
//     result = "(x > 0; y > 0)";
// }
//   else if (quater == 2)
//   {
//     result = "(x < 0; y > 0)";
//   }
//   else if (quater == 3)
//   {
//     result = "(x < 0; y < 0)";
//   }
//   else if (quater == 4)
//   {
//     result = "(x > 0; y < 0)";
//   }
//   Console.WriteLine($"Диапазон возможных координат точек в этой четверти: {result}");

// Задача 21: Напишите программу, которая принимает  вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// AB = √(xb - xa)2 + (yb - ya)2
// d = (ax - bx)*(ax - bx) + (ay + by)*(ay + by)

// Console.Write("Веедите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Веедите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Веедите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Веедите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double distance = 0;

// //Math.Sqrt(число) => Math.Sqrt(25)=5
// //Math.pow умноржение
// //Math.Round округление - цифра после запятой, указывает на количества знаков после округления

// distance = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)),2);

// Console.WriteLine(distance);

// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int index = 1;
// int result =1;
// while (index <= N)
// {
//     result = index*index;
//     Console.Write($"{result} ");
//     index++;
// }

// Решение преподавателя 1

// Console.WriteLine("Введите число: ");
// int end= Convert.ToInt32(Console.ReadLine());
// int start = 1;

// while (start <= N)
// {
   
//     Console.Write($"{Math.Pow(start, 2)} ");
//     start++;
// }


// Решение преподавателя 2Ъ

Console.WriteLine("Введите число: ");
int end = Convert.ToInt32(Console.ReadLine());

for (int index = 1; index <= end; index++)
{
    Console.Write(Math.Pow(index,2) + " ");
}