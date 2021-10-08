//Reference: https://www.w3resource.com/csharp-exercises/basic/index.php

//8.Write a C# Sharp program that takes a number as input and print its multiplication table
//Test Data:
//Enter the number: 5
//Expected Output:
//5 * 0 = 0
//5 * 1 = 5
//5 * 2 = 10
//5 * 3 = 15....5 * 10 = 50

using System;

namespace Ex8MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{number} * {i} = " + number * i);
            }
        }
    }
}
