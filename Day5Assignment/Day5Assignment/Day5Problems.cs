using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Day5Problems
    {
        public void flipCoin ()
        {
            int Heads = 0;
            int Tails = 0;
            int countFlipCoin = 20;
            Random random = new Random();

            for  (int i = 0; i < countFlipCoin; i++)
            {

                int coinTossCheck = random.Next(0, 2);
                if (coinTossCheck / 2.0f < 0.5)
                {
                    Tails++;

                }
                else
                {
                    Heads++;
                }
            }
            int heads_Percentage = (Heads * 100) / countFlipCoin ;
            Console.WriteLine("Heads percentage is : " + heads_Percentage);
            int tails_Percentage = (Tails * 100) / countFlipCoin;
            Console.WriteLine("Tails percentage is : " + tails_Percentage);


        }

        public void Leap_Year()
        {
            int year = 2022;
            if (year > 1000 && year < 9999 )
            {
                if (year % 4 == 0 || year % 400 == 0)
                {
                    Console.WriteLine("Leay year.");
                }
                else
                {
                    Console.WriteLine("not leap year");
                }
            }
            else
            {
                Console.WriteLine("Wrong Input .");
            }
        }
    }
}
