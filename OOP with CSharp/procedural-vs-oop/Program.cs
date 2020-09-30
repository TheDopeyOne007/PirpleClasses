using System;

namespace procedural_vs_oop
{
    // In OOP, you define classes that holds the methods/functions, properties, and fields to execute instructions.
    // Main advantages of OOP, is that you have special abilities like Inheritance, Encapsulation, and Polymorphism
    // that make OOP programming, easier to manage and reuse in the long term.
    // in the object you define everything you need, and it is easier to change and to maintain.
    // It follows the bottom up approach, when the class is made into an object and is called in the main function, it goes up to find the class
    // which acts as the blueprint, also objects are based on the real world.
    public class Users {
        public int id = 0;
        public string name = String.Empty;
        public Users(string name, int id) {
            this.name = name;
            this.id = id;
        }

        public string Name {
            get {return name;}
        }

        public int ID {
            get {return id;}
        }

        public void printInfo() {
            Console.WriteLine("Name: {0}\nID: {1}\n", this.name, this.id);
        }
    }
    class Program
    {
        // What is the difference between procedural and object oriented programming?
        // Procedural Programming depends on a list of instructions that are called step by step
        // to perform what it is told to, while OOP depends on the data type of a data structure that is defined by 
        // the programmer in an object, the programmer can as well define the functions and data members of the object.

        // Procedural Programming, I make two functions, one to print a message and the other to ask birthyear and then calculate age
        // When calling the these functions in the main function, the order of call is important, cause if we switch the calling of the function, it would ask for birthyear and then calculate age before it prints the welcome message, or vice versa.
        // So you need to execute each function line by line and in order in Procedural Programming.
        // Procedural Programing, is made up of functions and follows the top down approach.
        static void printWelcome() {
            Console.WriteLine("Hello, welcome to my program!");
        }

        static void calculateAge() {
            int age = 0;
            Console.Write("Enter your birth year: ");
            age = 2020 - Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} year(s) old.", age);
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Procedural Programming, really depends on the order of function call to execute procedures
            printWelcome();
            calculateAge();
            Console.WriteLine();

            string userName;

            // OOP, you instantiate an object from the class you defined 
            Users userA = new Users("Tony", 99);
            // Now you have access to all the functions and members that have an access identifier that allows you to access the content of the class
            // This makes OOP more secure when you are dealing with sensitive data
            userA.printInfo();
            // You can even access the members and save into other variables
            userName = userA.Name;
            Console.WriteLine(userName);


            // When would you want to use one versus the other?
            // I would use procedural if i wouldn't be writing too much functions to perform certain tasks and that
            // it isn't need to be maintained, but I prefer OOP for anything that would need complex functions and easier
            // ways to maintain and secure data. For really big projects, definitely would choose OOP over Procedural Programming
            // but procedural programming still has its advantages for problem solving.
        }
    }
}
