// Задача2. Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше
//  a = 5; b = 7 -> max = 7
//  a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3
using System.Globalization;

Console.WriteLine("Введите первое число:");
int number_1 = ConvertToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int number_2 = Convert.ToInt32(Console.ReadLine());
if (number_1 > number_2){
    System.Console.WriteLine("да");
}
else{
    System.Console.WriteLine("нет");
}

