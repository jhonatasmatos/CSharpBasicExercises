//Reference: https://www.w3resource.com/csharp-exercises/basic/index.php

//3. Write a C# Sharp program to print the result of dividing two numbers.

//Test data:

//-1 + 4 * 6
//(35 + 5) % 7
//14 + -4 * 6 / 11
//2 + 15 / 6 * 1 - 7 % 2

//Expected Output:
//23
//5
//12
//3

using System;

namespace Ex4SpecifiedOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            //-1 + 4 * 6
            Console.WriteLine((4 * 6) - 1);

            //(35 + 5) % 7
            Console.WriteLine((35 + 5) % 7);

            //14 + - 4 * 6 / 11
            Console.WriteLine((-4 * 6 / 11) + 14 );

            //2 + 15 / 6 * 1 - 7 % 2
            Console.WriteLine(2 + (15 / 6 * 1) - (7 % 2));
        }
    }
}
