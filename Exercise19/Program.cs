﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.Write("Введите пятизначное число: ");
string? num = Console.ReadLine();

//Нет нужды для данной задачи преобразовывать string в число, т.к. нет арифметических действий.
//Т.е. сравниваем символы, что для данной задачи приемлемо
//Однако будет не верный результат, если ввести не число, а строку...

if (num.Length == 5 && num[0] == num[4] && num[1] == num[3])        
{
    System.Console.WriteLine("Введенное число является палиндромом.");
}
else if (num.Length != 5)
{
    System.Console.WriteLine("Введенное число не пятизначное. Программа такой запрос не обрабатывает.");
}
else
{
    System.Console.WriteLine("Введенное число палиндромом НЕ является .");
}