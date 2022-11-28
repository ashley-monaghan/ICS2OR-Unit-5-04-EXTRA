// Created by: Ashley Monaghan
// Created on: Nov 2022
//
//This program converts Fahrenheit to Celsius

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int userAge;
        string userDay;

        Console.WriteLine("Do you get the discount?");
        Console.WriteLine("");

        Console.WriteLine("Enter your current age, then the current day to find out: ");
        Console.WriteLine("");
        userAge = Convert.ToInt16(Console.ReadLine());
        userDay = (Console.ReadLine());
        
        Console.WriteLine(" ");
        if ((userDay == "Tuesday" || userDay == "Thursday") || (userAge > 12 && userAge < 21))
        {
            Console.WriteLine("You get the discount!");
        }
        else
        {
            Console.WriteLine("Sorry, you don't get the discount.");
        }

        Console.WriteLine("\nDone.");
    }
}