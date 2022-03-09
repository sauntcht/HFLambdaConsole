﻿using System;

namespace HFLambdaConsole
{
    internal class Program
    {
        static Random random = new Random();

        static double GetRandomDouble(int max) => max * random.NextDouble();
        
        static void PrintValue(double d) => Console.WriteLine($"The value is {d:0.000}");
     


        static void Main(string[] args)
        {
            var value = Program.GetRandomDouble(100);
            Program.PrintValue(value);


        }
    }
}
