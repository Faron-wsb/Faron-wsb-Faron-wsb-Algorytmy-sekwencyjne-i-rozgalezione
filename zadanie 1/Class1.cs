﻿namespace zadanie_1
{
    public class Class1
    {
        using System;

public class MyProgram
    {
        public static void Main(string[] args)
        {
            double a, b, c;

            a = inputValue();
            b = inputValue();
            c = inputValue();
            double średniaartymetyczna;

            średniaartymetyczna = (a + b + c) / 3;
            Console.WriteLine(średniaartymetyczna);
        }

        // .NET can only read single characters or entire lines from the
        // console. The following function safely reads a double value.
        private static double inputValue()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) ;
            return result;
        }
    }

}
}