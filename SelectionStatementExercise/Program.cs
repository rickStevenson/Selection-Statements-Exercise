using System.Xml;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "Math":
                    Console.WriteLine("He likes math");
                    break;

                case "History":
                    Console.WriteLine("He likes history");
                    break;

                case "Science":
                    Console.WriteLine("He likes Science");
                    break;

                case "Gym":
                    Console.WriteLine("He likes Gym");
                    break;

                default:
                    Console.WriteLine("Have fun!");
                    break;

            }
        }
    }
}
