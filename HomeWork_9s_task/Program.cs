// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"



// Console.WriteLine("Введите число:");
// int numM = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число:");
// int numN = Convert.ToInt32(Console.ReadLine());

// string PrintNum(int numM, int numN)
// {
//     if (numM == numN) return numM.ToString();

//     return numM + PrintNum(numM + 1, numN);
// }

// Console.WriteLine($"Числа от {numM} до {numN}: {PrintNum(numM, numN)}");



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

// Вариант 1

// Console.WriteLine("Введите число:");
// int numM = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число:");
// int numN = Convert.ToInt32(Console.ReadLine());


// string PrintNum(int numM, int numN)
// {
//     if (numM == numN) return numM.ToString();

//     return numM + PrintNum(numM + 1, numN);
// }

// Console.WriteLine($"Числа от {numM} до {numN}: {PrintNum(numM, numN)}");

// int arrayMN = Convert.ToInt32(PrintNum(numM, numN));

// int SumNum(int num)
// {
//     if (num == 0) return 0;
//     return num % 10 + SumNum(num / 10);
// }
// Console.WriteLine($"Cумма цифр в числе {arrayMN}: {SumNum(arrayMN)}");

// Вариант 2

// Console.WriteLine("Введите число:");
// int numM = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число:");
// int numN = Convert.ToInt32(Console.ReadLine());


// int PrintNum(int numM, int numN)
// {
//     if (numM == numN) return numM;

//     return numM + PrintNum(numM + 1, numN);
// }

// Console.WriteLine($"Сумма чисел от {numM} до {numN}: {PrintNum(numM, numN)}");



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n. 
// m = 2, n = 3->A(m, n) = 29


// Console.WriteLine("Введите число:");
// int numM = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число:");
// int numN = Convert.ToInt32(Console.ReadLine());


// int Akkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return Akkerman(m - 1, 1);
//     return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// Console.WriteLine(Akkerman(numN, numM));