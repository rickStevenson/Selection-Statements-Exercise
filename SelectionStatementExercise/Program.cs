using System.Xml;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(); //This line creates a new `Random` object, which is used to generate random numbers.
            int favNumber = r.Next(1, 1000);  //This line generates a random integer between 1 and 999 and assigns it to the `favNumber` variable.


            Console.WriteLine("Guess my favorite number");
            int guess = int.Parse(Console.ReadLine());

            if (guess < favNumber)
            {
                Console.WriteLine("Guess is too low");
            }
            else if (guess > favNumber)
            {
                Console.WriteLine("Guess is too high");
            }
            else 
            { 
                Console.WriteLine("That's correct!"); 
            }




        }
    }
}
