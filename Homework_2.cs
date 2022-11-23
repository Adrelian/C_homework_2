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