// Задача2. Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше
//  a = 5; b = 7 -> max = 7
//  a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3
//using System.Globalization;

Console.WriteLine("Введите 2 числа и мы тебе скажем какое из них больше");
System.Console.WriteLine("Введите свое первое число");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    System.Console.WriteLine(«Большее число: » + a + «, меньшее число: » + b);
}
else {
    System.Console.WriteLine($»Большее число: {a}, меньшее число: {b}»);
}
    