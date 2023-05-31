// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write(Math.Pow(firstNumber, secondNumber));


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int sum = 0; 

// while (number > 0)
// {
//     sum = sum + number % 10;
//     number = number/10;
// }

// Console.WriteLine($"Сумма чифр в числе = {sum}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int size = 8;
// int[] array = new int[size]; 

// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(9);
// }

// Console.WriteLine($"Массив: [ {String.Join("; ",array)} ]");