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


        public void Power_Of_2 ()
        {
            Console.WriteLine("Enter a number : ");
            string inputByUser = Console.ReadLine();
            int numVal = Int32.Parse(inputByUser);
            if ( numVal >= 0 || numVal < 31)
            {
                int temp  = 1;
                for (int i = 0; i < numVal; i++)
                {
                    temp = 2 * temp;
                    Console.WriteLine(temp);

                }
                
               
            }
            
            
        }

        public double Harmonic_Number (int N)
        {
                // H1 = 1
                float harmonic = 1;

                // loop to apply the formula
                // Hn = H1 + H2 + H3 ... +
                // Hn-1 + Hn-1 + 1/n
                for (int i = 2; i <= N; i++)
                {
                    harmonic += (float)1 / i;
                }
                return harmonic;

            Console.WriteLine(Harmonic_Number(N));
            
        }


        public void Factor ()
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is Prime.");
        }

        public void Swap_Two_Number()
        {
            int num1 = 12;
            int num2 = 23;
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Swapping of number is  : " + num1 + " " + num2);

        }

        public void Check_Even_Or_Odd ()
        {
            int number;
            Console.WriteLine("Enter the Number to check Even or Odd : ");
            number = int.Parse(Console.ReadLine());
            if(number % 2 == 0 )
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }

        }

        public void Check_Char_Vowel_Or_Consonant ()
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());


            // Condition for vowel checking
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine(ch + " is Vowel.");

            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is Consonant.");
            }
        }
    }
}
