//Reference: https://www.w3resource.com/csharp-exercises/basic/index.php

//1.Write a C# Sharp program to print Hello and your name in a separate line. Go to the editor
//Expected Output :
//Hello: Alexandra Abramov

using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Alexandra Abramov";

            Console.WriteLine("Hello: " + name);
        }
    }
}
