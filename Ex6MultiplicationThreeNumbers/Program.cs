//Reference: https://www.w3resource.com/csharp-exercises/basic/index.php

//6.Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
//Test Data:
//Input the first number to multiply: 2
//Input the second number to multiply: 3
//Input the third number to multiply: 6
//Expected Output:
//2 x 3 x 6 = 36

using System;

namespace Ex6MultiplicationThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the First Number");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input the Second Number");
            int secondNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input the Third Number");
            int thirdNumber = Int32.Parse(Console.ReadLine());

            int result = firstNumber * secondNumber * thirdNumber;

            Console.WriteLine($"{firstNumber} x {secondNumber} x {thirdNumber} = " + result);
        }
    }
}
