//Reference: https://www.w3resource.com/csharp-exercises/basic/index.php

//9.Write a C# Sharp program that takes four numbers as input to calculate and print the average. Go to the editor
//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30

//Expected Output:
//The average of 10 , 15 , 20 , 30 is: 18

using System;

namespace Ex9Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number");
            int first = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number");
            int second = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input the third number");
            int third = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input the fourth number");
            int fourth = Int32.Parse(Console.ReadLine());

            int average = (first + second + third + fourth) / 4;

            Console.WriteLine($"The average of {first} , {second} , {third} , {fourth} is: {average}");

        }
    }
}
