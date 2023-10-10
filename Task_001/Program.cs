// Задача2. Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше
//  a = 5; b = 7 -> max = 7
//  a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3
//using System.Globalization;
// Мое решение
// Console.WriteLine("Введите 2 числа и мы тебе скажем какое из них больше");
// System.Console.WriteLine("Введите свое первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число:");
//int b = Convert.ToInt32(Console.ReadLine());
//
// if (a > b)
//{
    //System.Console.WriteLine("больше");
//}
//else if(a == b) {
 //   System.Console.WriteLine("равен");
//
//}
   // else{
      //  System.Console.WriteLine("меньше");
   // }
   // пример идельного решения
   //if (firstNumber == secondNumber)
   Console.WriteLine("Введите 2 числа и мы тебе скажем какое из них больше");
System.Console.WriteLine("Введите свое первое число");
firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
secondNumber = Convert.ToInt32(Console.ReadLine());

        if (firstNumber == secondNumber){
                Console.WriteLine($"Введенные числа равны `{firstNumber}`");
        }
        
        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
        }
        if (firstNumber < secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
        }