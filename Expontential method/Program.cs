using System;

namespace Expontential_method
{
    // The astrophysicist Neil deGrasse Tyson asked, on his YouTube channel Startalk (a video about Exponentials), the question if you rather
    // would take 5 MUSD right now or take a penny a day which is doubled each day for 30 days. So, the answer he says, is that you would get
    // about 10 MUSD if you choose the second option (plus about 10 MUSD more since you are handed the money each day). 
    // I made this script in order to check whether that claim is true. It is.


    class Exponent
    {
        public static decimal DoubleExp(decimal noLoop, decimal yourNo)
        {
            decimal result = yourNo;

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
                            decimal yourNo = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("\n\tHow many times should your number get doubled? ");
                            decimal noLoop = Convert.ToDecimal(Console.ReadLine());

                            decimal exp = DoubleExp(noLoop, yourNo);

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
