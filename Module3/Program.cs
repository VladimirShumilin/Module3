﻿using System;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Jane";

            Console.WriteLine(MyName);

            Console.WriteLine("\t  Привет, мир");
            Console.WriteLine("\t  Мне 27 лет");
            Console.WriteLine($"\t  My name is \n   {MyName}");

            Console.ReadKey();
        }
    }
}
