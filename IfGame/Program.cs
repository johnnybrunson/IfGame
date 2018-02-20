using System;

namespace IfGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a game. You must select door 1, 2 or 3 to see what you have won.");
            string UserValue = Console.ReadLine();

            string message = "";

            if (UserValue == "1")
                message = "You won a new MacBookPro!"; //Curly brces not necessary if only one line of code in the statement
            else if (UserValue == "2")
                message = "You won a new SurfacePro!";
            else if (UserValue == "3")
                message = "You won a 1 year MSDN subscription!";
            else
            {
                message = "Since you can't follow instructions, you win nothing.";
            }

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
