// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// Свой вариант

// int randomNumber = new Random().Next(10,100);

// int firstDigit = randomNumber / 10; 
// int secondDigit = randomNumber % 10;

// Console.WriteLine(randomNumber);

// if (firstDigit>secondDigit)
// {
// Console.WriteLine($"Максимальная цифра в числе, {randomNumber}, - это {firstDigit}");
// }
// else
// {
// Console.WriteLine($"Максимальная цифра в числе, {randomNumber}, - это {secondDigit}");
// }

// Семинар Вариант

// int randomNumber = new Random().Next(10,100);

// int firstDigit = randomNumber / 10; 
// int secondDigit = randomNumber % 10;

// int max = firstDigit;

// if (secondDigit>max)
// {
//     max = secondDigit;
// }
// Console.WriteLine($"Максимальная цифра в числе, {randomNumber}, - это {max}");

//_______________________________________________________________


// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// Свое решение
// int randomNumber = new Random().Next(100,1000);

// int fristDigit = randomNumber / 100;
// int thirdDigit = randomNumber % 10;

// Console.WriteLine($"Случайное трехзначное число: {randomNumber} Число без 2го знака: {fristDigit}{thirdDigit}");

// Математическое решение

// int randomNumber = new Random().Next(100,1000);

// int result = ((randomNumber/100) * 10) + (randomNumber % 10);

// Console.WriteLine($"Случайное трехзначное число: {randomNumber} Число без 2го знака: {result}"); 

// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

//Свое решение

// Console.WriteLine("Введите число 1:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int remainder = num1 % num2; 

// if (remainder == 0)
// {
//     Console.WriteLine($"{num1}, {num2} -> кратно");
// }
// else
// {
//     Console.WriteLine($"{num1}, {num2} -> не кратно, остаток: {remainder}");
// }

// Решение семинар

// Console.WriteLine("Введите число 1:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0)
// {
//     Console.WriteLine($"{num1}, {num2} -> кратно");
// }
// else
// {
//     Console.WriteLine($"{num1}, {num2} -> не кратно, остаток: {num1 % num2}");
// }

//_________________________________________________________________________________________

// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

//Свое решение 

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int check7 = number % 7;
// int check23 = number % 23;

// if (check7 + check23 == 0)
// {
//     Console.WriteLine($"{number} -> Да");
// }
// else
// {
//     Console.WriteLine($@"{number} -> Нет");
// }

//Решение семинар 

// Console.WriteLine("Какое число проверим одновременную кратьность 7 и 23: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine($"{number} -> Да,делится без остатка на 7 и 23");
// }
// else
// {
//     Console.WriteLine($@"{number} -> Нет, делится с отстактом {number % 7}");
//     Console.WriteLine($@"{number} -> Нет, делится с отстактом {number % 23}");
// }