//Reference: https://www.w3resource.com/csharp-exercises/basic/index.php

//7.Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
//Test Data:
//Input the first number: 25
//Input the second number: 4
//Expected Output:
//25 + 4 = 29
//25 - 4 = 21
//25 x 4 = 100
//25 / 4 = 6
//25 mod 4 = 1

using System;

namespace Ex7MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the First Number");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input the Second Number");
            int secondNumber = Int32.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            int sub = firstNumber - secondNumber;
            int mult = firstNumber * secondNumber;
            int divid = firstNumber / secondNumber;
            int mod = firstNumber %  secondNumber;

            Console.WriteLine($"{firstNumber} + {secondNumber} = " + sum);
            Console.WriteLine($"{firstNumber} - {secondNumber} = " + sub);
            Console.WriteLine($"{firstNumber} * {secondNumber} = " + mult);
            Console.WriteLine($"{firstNumber} / {secondNumber} = " + divid);
            Console.WriteLine($"{firstNumber} mod {secondNumber} = " + mod);
        }
    }
}
