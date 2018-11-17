﻿using System;

namespace WeeklyProject2
{
    class MathOperation
    {
        public static double DoCalculations()
        {
            double num1, num2, result;

            Console.WriteLine("Type the first number and press Enter : ");

            num1 = ReadFromConsole.ReadNumberFromConsole();

            Console.WriteLine("\n\rType the second number and press Enter : ");
            num2 = ReadFromConsole.ReadNumberFromConsole();

            Console.WriteLine("Choose a math operation between these two numbers.\nChoices are + , - , * , / , % , square root");
            string mathOperation = Console.ReadLine();

            result = 0;

            switch (mathOperation)
            {
                //TODO's : personalize the messages according to the operation
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Result : {num1} + {num2} = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Result : {num1} - {num2} = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Result : {num1} * {num2} = " + result);
                    break;
                case "/":
                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = ReadFromConsole.ReadNumberFromConsole();
                    }
                    result = num1 / num2;
                    Console.WriteLine($"Result : {num1} / {num2} = " + result);

                    break;
                case "%":
                    while (num2 == 0)
                    {
                        Console.WriteLine("Division with zero returns a non-real number. Enter a non-zero divisor: ");
                        num2 = ReadFromConsole.ReadNumberFromConsole();
                    }
                    result = num1 % num2;
                    Console.WriteLine($"Result : {num1} % {num2} = " + result);
                    break;
                case "square root":
                    while (num1 < 0)
                    {
                        Console.WriteLine("Only non-negative numbers are permitted under a root. Enter a non-negative number: ");
                        num1 = ReadFromConsole.ReadNumberFromConsole();
                    }
                    result = Math.Pow(num1, 1 / num2);
                    Console.WriteLine($"Result : {num1} sqrt {num2} = " + result);
                    
                    break;

                    //TODO check if default is needed (program ends if default is up)
                default:
                    Console.WriteLine("Incorrect Option");
                    break;
            }
            return result;
        }
    }
}
