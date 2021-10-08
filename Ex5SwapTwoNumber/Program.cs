//Reference: https://www.w3resource.com/csharp-exercises/basic/index.php

//5.Write a C# Sharp program to swap two numbers. 
//Input the First Number : 5
//Input the Second Number : 6
//Expected Output:
//After Swapping :
//First Number : 6
//Second Number : 5

using System;

namespace Ex5SwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the First Number");
            string  firstNumber = Console.ReadLine();

            Console.WriteLine("Input the Second Number");
            string secondNumber = Console.ReadLine();

            string temporaryString = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temporaryString;

            Console.WriteLine("First Number : " + firstNumber);
            Console.WriteLine("Second Number : " + secondNumber);
        }
    }
}
