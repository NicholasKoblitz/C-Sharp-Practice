using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingWizard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;

            Console.WriteLine("Welcome to the Number Wizard!");
            Console.WriteLine("\nEnter a number between 0 and 100");
            Console.WriteLine("You Get 5 guesses");

            Random rand = new Random();
            int randomNum = rand.Next(1, 101);
            int guesses = 5;

            while (playing)
            {
                if (guesses == 0)
                {
                    Console.WriteLine("You ran out of guesses");
                    break;
                }

                int playerResponse;
                bool responseIsNum = int.TryParse(Console.ReadLine(), out playerResponse);

                if (responseIsNum)
                {
                    if (playerResponse.Equals(randomNum))
                    {
                        Console.WriteLine("Congrats! You guessed the right number!");
                        break;
                    }
                    else if (playerResponse > randomNum)
                    {
                        guesses--;
                        Console.WriteLine($"You have {guesses} left\nYour guess is too high");
                    }
                    else if (playerResponse < randomNum)
                    {
                        guesses--;
                        Console.WriteLine($"You have {guesses} left\nYour guess is too low");

                    }
                }
                else
                {
                    Console.WriteLine("Invalid Response. Please Provide a number");
                }
            }

        }
    }
}
