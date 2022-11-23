// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.


// 456 -> 5
// 782 -> 8
// 918 -> 1

// void SecNum (int num) 
// {
//     if (num < 100 || num >= 1000) // need three-digit number
//     {
//         Console.WriteLine("You make a mistake");
//     }

//     else
//     {
//         int result = (num - (num/100)*100 - (num % 10))/10;
//         Console.WriteLine($"{num} -> {result}");
//     }
// }

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// SecNum(number);

// Задача 13: Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// void ThirdNumber(int number)
// {
//    int hundred = number % 100; // отбросить двухзначные
//    if (hundred == number )
//    {
//     Console.WriteLine("Третьей цифры нет ");
//    }
//    else // поиск третьего числа
//    {
//    int result = ((number / 100) % 10);
//    Console.WriteLine($"{number} -> {result}");
//    } 
// }
// Console.Write("Input number: ");
//  int newNumber = Convert.ToInt32(Console.ReadLine());
//  ThirdNumber(newNumber);

//  Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void DayOfWeek(int number)
{

}