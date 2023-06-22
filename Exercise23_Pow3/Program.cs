﻿Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()??"");

int count = 1;

while (count<=number)
{
double Pow = Math.Pow(count,3);
Console.Write ($"{Pow}, ");

count = count+1;



}