﻿Console.WriteLine("Введите два числа");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
  Console.WriteLine("max = " +number1);
}
else
{
  Console.WriteLine("max = " +number2);
}