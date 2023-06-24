// ctrl + /

//Однострочный комментарий

/*Многострочный
комментарий
*/

//#1 возведение в стемень числа
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine()); 
// int result = number * number;
// Console.WriteLine("Выводим квадрат числа: " + number + " равен: " + result);

//#1.1 возведение в стемень числа с точкой
// Console.Write("Введите число: ");
// double number = Convert.ToDouble(Console.ReadLine()); 
// double result = number * number;
// Console.WriteLine("Выводим квадрат числа: " + number + " равен: " + result);

// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет
//digit - число


// Console.Write("Введите первре число: ");
// int number1 = Convert.ToInt32(Console.ReadLine()); 

// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine()); 

// if (number1 == number2 * number2)
// {
//     Console.WriteLine("Число 1: " + number1 + " Число 2: " + number2 + " -> yes");
// }
// else
// {
//     Console.WriteLine("Число 1: " + number1 + " Число 2: " + number2 + " -> no");
// }

// 5. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от] -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// САМ
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// // int count = 0;

// int negativeN = N * (-1); // -N

// Console.Write(negativeN + ", ");

// do
// {
// negativeN = negativeN + 1;
// Console.Write(negativeN + " ,");
// }
// while(negativeN <= N - 1);


// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// if (N < 0)
// {
//     N = N * -1;
// }

// int negativeN = N * (-1);

// while(negativeN <= N)
// {
//     Console.Write(negativeN + " ");
//     negativeN++;
// }


//shift alt F - редактирование


Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.Readline());
Console.Write("Ввелите Число 2: ");
int n2 = Convert.ToInt32(Console.Readline());
if(n1 > n2)
{
Console.Writeline(n1);
}
else
{
Console.Writeline(n1);
}
