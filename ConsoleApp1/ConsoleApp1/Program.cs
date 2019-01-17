using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int guessAmt = 0;
            int randomNum = 0;
            int userNum = 0;
            int lowBound = 0;
            int highBound = 0;

            Console.WriteLine("Select a lower bound:");
            lowBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select a upper bound:");
            highBound = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            randomNum = rnd.Next(lowBound, highBound);
            Console.WriteLine("Guess a number between 0 and 100:");
            while (userNum != randomNum)
            {
                
                userNum = Convert.ToInt32(Console.ReadLine());
                
                if(randomNum > userNum)
                {
                    Console.WriteLine("guess too low");
                }

                else if (randomNum < userNum)
                {
                    Console.WriteLine("guess too high");
                }
                
                guessAmt++;
            }

            Console.WriteLine("Correct");
            Console.WriteLine("took " + guessAmt +" tries");
            Console.ReadLine();
            
            
        }
    }
}
