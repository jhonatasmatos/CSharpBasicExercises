//Reference: https://www.w3resource.com/csharp-exercises/basic/index.php

//10.Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
//Test Data:
//Enter first number - 5
//Enter second number - 6
//Enter third number - 7

//Expected Output:
//Result of specified numbers 5, 6 and 7, (x + y).z is 77 and x.y + y.z is 72

using System;

namespace Ex10ThreeNumbersExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number");
            int y = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input the third number");
            int z = Int32.Parse(Console.ReadLine());

            int firstExpression = (x + y) * z;
            int secondExpression = (x * y) + (y * z);

            Console.WriteLine($"Result of specified numbers {x},{y} and {z}, ({x}+{y}).{z} is {firstExpression} and {x}.{y} + {y}.{z} is {secondExpression}");
        }
    }
}
