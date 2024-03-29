﻿using System;
using System.Numerics;

namespace Expontential_method
{
    // The astrophysicist Neil deGrasse Tyson asked, on his YouTube channel Startalk (a video about Exponentials), the
    // question if you would rather take 5 MUSD right now or take a penny a day which is doubled each day for 30 days.
    // So, the answer he says, is that you would get about 10 MUSD if you choose the second option (plus about 10 MUSD
    // more since you are handed the money each day). 

    // I made this script in order to check whether that claim is true. It is.


    class Exponent
    {
        public static BigInteger DoubleExp(double noLoop, double yourNo)
        {
            double result = yourNo;

            for (double i = 0; i < noLoop; i++)
            {
                result += result;
                Console.WriteLine((i + 1).ToString() + ") " + result.ToString()); // Add 1 to i when displaying it on the console
            }

            return (BigInteger)result;
        }

        static void Main()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n\tDOUBLE A NUMBER");
                Console.Write("\n\t[1]Enter program");
                Console.WriteLine("\n\t[2]Quit program");

                try
                {
                    int menuChoice = Convert.ToInt32(Console.ReadLine());

                    if (menuChoice != 1)
                    {
                        Console.WriteLine("\nYou can only choose a number between 1 and 2.");
                    }

                    switch (menuChoice)
                    {
                        case 1:
                            Console.WriteLine("\n\t(Note: use , and not . for decimal numbers)");

                            Console.WriteLine("\n\tWhat is your number? ");
                            double yourNo = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("\n\tHow many times should your number (i.e. the product) get doubled? ");
                            double noLoop = Convert.ToDouble(Console.ReadLine());

                            double exp = (double)DoubleExp(noLoop, yourNo);

                            Console.WriteLine("\n\tThe value is: {0:N}", exp);
                            Console.WriteLine("\n\tPress any key to revert to menu.");
                            Console.ReadKey();
                           
                            break;

                        case 2:
                            isRunning = false;
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\n\tWrong input format. Returning to the menu.");
                    continue;
                }
            }
        }
    }
}
