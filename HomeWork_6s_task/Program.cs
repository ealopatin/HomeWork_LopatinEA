

//  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//  сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int MessageToValue(string message)
{

    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = MessageToValue($"Введите элемент {i}: ");
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.WriteLine($"Массив: [{string.Join("; ", array)}]");
    Console.WriteLine();
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

// int length = MessageToValue("Введите размер массива: ");
// int[] array = InputArray(length);

// PrintArray(array);

// Console.WriteLine($"Количество чисел больше нуля - {CountPositiveNumbers(array)}");
// Console.WriteLine();



// ПРОВЕРКА НА КОЛИЧЕСТВО ЭЛЕМЕНТОВ МАССИВА БЕЗ ОСТАНОВКИ ПРОГРАММЫ - НЕ РАБОТАЕТ

// int length = MessageToValue("Введите размер массива: ");


int length = 0;

void CheckArraySize0to10(int ckecklength)
{
    while (true)
    {
        length = MessageToValue("Введите размер массива: ");
        Console.WriteLine();
        if (length <= 10 && length > 0)
        {
            break;
        }
        Console.Write("Введите значение от 0 до 10 ");
        Console.WriteLine();

    }
    
}


CheckArraySize0to10(length);

int[] array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше нуля - {CountPositiveNumbers(array)}");
Console.WriteLine();


// int GetPositivUserNumber(string message, string errorMessage)
// {
//     while (true)
//     {
//         Console.Write(message);
//         if (int.TryParse(Console.ReadLine(), out int userNumber) && userNumber >= 0)
//             return userNumber;
//         Console.WriteLine(errorMessage);
//     }
// }


// while (true)
// {
//     if (number == 1111)
//     {
//         break;
//     }

// }




// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// //  значения b1, k1, b2 и k2 задаются пользователем.

// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// точка пересечения с x у

// k1 * x + b1 = k2 * x + b2

// х = (b2 - b1)/(k1 - k2)

// у = (k1 * (b2 - b1)/(k1 - k2)) + b1


// double MessageToValue(string message)
// {

//     Console.Write(message);
//     string value = Console.ReadLine();
//     double result = Convert.ToDouble(value);
//     return result;
// }

// double b1 = MessageToValue("Введите значение b1: ");
// double k1 = MessageToValue("Введите значение k1: ");
// double b2 = MessageToValue("Введите значение b2: ");
// double k2 = MessageToValue("Введите значение k2: ");

// double x = Math.Round((b2 - b1) / (k1 - k2), 2);
// double y = Math.Round((k1 * (b2 - b1) / (k1 - k2)) + b1, 2);

// if (k1 == k2)
// {
//     if (b1 == b2)
//     {
//         Console.WriteLine();
//         Console.WriteLine("Прямые совпадают");
//     }
//     else
//     {
//         Console.WriteLine("Прямые параллельны");
//     }
// }

// Console.WriteLine();
// Console.WriteLine($"Точка пересечения имеет координаты: ({x};{y})");
// Console.WriteLine();

