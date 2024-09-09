using System;
using System.Xml;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            FavNumber();
            //SwitchExercis();
        }

        public static void FavNumber()
        {
            Random r = new Random();
            int favNumber = r.Next(1, 21); // 1 to 20 inclusive
            int guess = -1;
            string answer = "";

            Console.WriteLine("Guess my favorite number between 1 and 20");

            do
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out guess))
                {

                    if (guess < 1 || guess > 20)
                    {
                        Console.WriteLine("Please guess a number between 1 and 20.");
                    }
                    else
                    {
                        answer = guess < favNumber ? "Too Low" :
                                 guess > favNumber ? "Too High" :
                                 "That's correct!";
                        Console.WriteLine(answer);

                        if (answer != "That's correct!")
                        {
                            Console.WriteLine("Guess again");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            } while (answer != "That's correct!");
        }
        public static void SwitchExercis()
        {
            Console.WriteLine("What is your favorite school subject?");
            string favSubject = Console.ReadLine().ToLower();

            switch (favSubject)
            {
                case "math":
                    Console.WriteLine("He likes math");
                    break;

                case "history":
                    Console.WriteLine("He likes history");
                    break;

                case "science":
                    Console.WriteLine("He likes Science");
                    break;

                case "gym":
                    Console.WriteLine("He likes Gym");
                    break;

                default:
                    Console.WriteLine("Have fun!");
                    break;

            }
        }
    }
}
