using System;

namespace logic
{
    class logic
    {
        static void Main(string[] args)
        {
            // Argument 1
            // Started with a bool to set if it's either chocolate or not
            bool isCakeChocolate = false;
            // Made a string to hold the type of cake
            string cake;
            // If-else statement to set to chocolate or vanilla based on the bool isCakeChocolate
            if(isCakeChocolate) {
                cake = "chocolate";
            } else {
                cake = "vanilla";
            }
            // Printed out the cake
            Console.Write("What is the cake? ");
            Console.WriteLine(cake);

            // Argument 2
            // Made bool variables for if all men are moral and for if socrates is a man
            // Which are both true
            bool allMenMortal = true;
            bool isSocratesMan = true;
            bool isSocratesMortal;
            // Using the and logical, both must be true to confrim Socrates is mortal else he isn't
            if(allMenMortal && isSocratesMan) {
                isSocratesMortal = true;
            } else {
                isSocratesMortal = false;
            }
            Console.Write("Socrates is mortal? ");
            Console.WriteLine(isSocratesMortal);
        }
    }
}
