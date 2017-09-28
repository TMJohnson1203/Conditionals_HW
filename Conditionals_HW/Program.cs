using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_HW
{
    class Program
    {
        static void Main(string[] args)
        {

            // are the two intergers equal to each other?
            // if yes, tell user that they are equal
            // if else, tell user that they are not equal

            //int firstNum = int.Parse(ReadLine());
            //Console.WriteLine("Please enter a number.");
           
            //int secNum = int.Parse(Readline());
            //Console.WriteLine("Please enter another number");

            //if firstNumber == secNum

            
            //Console.WriteLine("")

                    // problem 4
                    // is the character entered a vowel or a consonant

                //Console.WriteLine("Please enter a letter")
                //    char yourLetter = char.Parse(Console.ReadLine());

                //switch yourLetter == 'a'
                //    {
                //    Console.WriteLine("Your letter is a vowel.");
                //    }

                // number 5

            Console.WriteLine("Enter a whole number");
            int firstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another whole number");
            int secondValue = int.Parse(Console.ReadLine());

            if (firstValue > secondValue)
            {
                Console.WriteLine(firstValue + "is the larger value.");
            }

            else if (secondValue > firstValue)
            {
                Console.WriteLine(secondValue + "is the larger value.");
            }

            else
            {
                Console.WriteLine("The numbers are equal.");
            }

            // average of four numbers that user inputs

            //Console.WriteLine("Please enter a whole number");
            //int firstNum = int.Parse(Console.Readline());

            //Console.WriteLine("Please enter a second number");
            //int secNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter four whole numbers. One at time.");
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            double sum = firstNum = secNum + thirdNum + fourthNum;

            Console.WriteLine("The average is" + (sum / 4));







    



           


         

        }
    }
}
