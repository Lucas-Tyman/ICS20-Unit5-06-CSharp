// Created by: Kenny Le
// Created on: May 2022
//
// This program performs a loop.

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function performs a loop
        int firstInteger;
        int secondInteger;
        int answer = 0;
        int temp = 0;
        int counter = 0;

        // input
        Console.WriteLine("This program performs a loop by doing repeated addition.");

        Console.WriteLine("");
        Console.Write("Please input the first integer: ");
        firstInteger = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please input the second integer: ");
        secondInteger = Convert.ToInt32(Console.ReadLine());

        // process
        if (secondInteger < 0)
        {
            temp = firstInteger;
            firstInteger = secondInteger;
            secondInteger = temp;
        }
        while (counter < secondInteger)
        {
            answer += firstInteger;
            counter++;
        }

        // output
        Console.WriteLine("The answer is " + answer);
        Console.WriteLine("\nDone.");
    }
}