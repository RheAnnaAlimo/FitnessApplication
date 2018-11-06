using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApplication
{  
        class Program
        {
            static void Main(string[] args)
            {
                //Prompt user for minutes exercised
                //Add minutes to total minutes
                //Display total minutes
                //Repeat until user quits

                double runningTotal = 0.0;

                while (true)
                {
                    Console.WriteLine("Enter # of minutes you exercised or type \"quit\" to exit");
                    string userInput = Console.ReadLine();
                    if (userInput.ToLower() == "quit")
                    {
                        Console.WriteLine("\nGoodbye");
                        break;
                    }
                    else
                    {
                        //ensure user inputs a positive integer
                        try
                        {
                            var minutes = double.Parse(userInput);

                            //add some positive feedback
                            if (minutes <= 0)
                            {
                                Console.WriteLine(minutes + " is not an acceptable value");
                                continue;
                            }
                            else if (minutes <= 10)
                            {
                                Console.WriteLine("Better than nothing, am I right?\n");
                            }
                            else if (minutes <= 30)
                            {
                                Console.WriteLine("Way to go!\n");
                            }
                            else if (minutes <= 60)
                            {
                                Console.WriteLine("You must be a ninja!\n");
                            }
                            else
                            {
                                Console.WriteLine("Now you're just showing off!\n");
                            }
                            Console.WriteLine("You've entered " + userInput + " minutes.");
                            runningTotal += minutes;
                            Console.WriteLine("You've exercised a total of " + runningTotal + " minutes.\n");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("That is not a valid input");
                            continue;
                        }

                    }

                }
            }
        }
    }

