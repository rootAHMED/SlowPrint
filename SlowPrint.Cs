using System;
using System.Globalization;
using Microsoft.VisualBasic.CompilerServices;


class Program
{
    static void Main(string[] args)
    {
        string message = "  I Love You :) ";
        SlowPrint (message);
    }

    static void SlowPrint(String text)
    {
        foreach (char c in text)
        {
         Console.Write(c); 
         Thread.Sleep(100);
        }

        Console.Read();
    }
}
