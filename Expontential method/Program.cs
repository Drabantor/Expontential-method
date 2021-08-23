using System;

namespace Expontential_method
{
    class Exponent
    {
        public static decimal DoubleExp(decimal noLoop, decimal storedNo)
        {
            decimal result = storedNo;

            for (decimal i = 0; i < noLoop; i++)
            {
                result += result;
            }
            return result; 
        }

        static void Main()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n\tDOUBLE A NUMBER");
                Console.Write("\n\t[1]Enter program");
                Console.WriteLine("\n\t[2]Quit program");

                int menuChoice = Convert.ToInt32(Console.ReadLine());

                try
                {
                    switch (menuChoice)
                    {
                        case 1:
                            Console.WriteLine("\n\t(Note: use , and not . for decimal numbers)");

                            Console.WriteLine("\n\tWhat is your number? ");
                            decimal storedno = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("\n\tHow many times should your number get doubled? ");
                            decimal noLoop = Convert.ToDecimal(Console.ReadLine());

                            decimal exp = DoubleExp(noLoop, storedno);

                            Console.WriteLine("\n\tThe value is: {0:N}", exp);
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
