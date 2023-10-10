// Задача2. Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше
//  a = 5; b = 7 -> max = 7
//  a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3
using System.Globalization;

Console.WriteLine("Введите 2 числа и мы тебе скажем какое из них больше");
System.Console.WriteLine("Введите свое первое число");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

bool Chto0 = a > b;
bool Chto1 = a == b;
bool Chto2 = a < b;

if(Chto0){
    System.Console.WriteLine($"Число {a} больше чем {b}");
}
else if(Chto1){
    System.Console.WriteLine($"Чмсла {a} и {b} равны");
}
else{
    System.Console.WriteLine($"число {b} больше чем {a}");
}