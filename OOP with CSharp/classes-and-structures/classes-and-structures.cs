using System;

namespace classes_and_structures
{
    // 1. What is the difference between a class and a structure?
    // The main key difference between a class and a structure, is that a class is a reference type and
    // a struct is a value type. When an Object is created from class, it holds only the reference in memory while
    // when a struct is made, it holds a copy of the values of the data in the stuct instead of an address. Stucts are 
    // basically a light weight version of a Class.
    // Another difference between classes and structs is that structs can't have default constructors while class can.
    // Structs have some limiting features like inheritance and polymorphism that Classes can do. But both can hold 
    // different types of data and even user-defined types.

    // 2. When would you want to use one versus the other?
    // I believe I would use objects over struct if I need to model more complex data types, and that will change 
    // or need inheritance or polymorphishm. And I think I will use struct if I will make small data structures that contain mostly data
    // and that it wouldn't need to be inherited to other data types. Each can perform well depending on how the data is used and how
    // complex it is. So class if there are any reference data type, but if all are value type, I would choose struct.

    // CLASS
    //  A class is a blueprint for an object. It combines the fields and methods
    // into one unit.
    // Name of the example class is Teacher
    class Teacher { 
        // Data members of the class Teacher
        // These describe the Teacher 
        public string name_;
        public string subject_;
        public int age_;
        public int noOfYearsTeaching_;
        public int noOfTeachers;
        // Default Constructor - a constructor when no values are passed at instantiation, so we set default values for the object
        // Which can only be created in Class
        public Teacher() {
            name_ = "Newton";
            subject_ = "Physics";
            age_ = 99;
            noOfYearsTeaching_ = 66;
            noOfTeachers++;
        }
        // Non-default Constructor - a construtcor with values passed and that will set the data members
        public Teacher(string name, string subject, int age, int noOfYearsTeaching) {
            name_ = name;
            subject_ = subject;
            age_ = age;
            noOfYearsTeaching_ = noOfYearsTeaching;
            noOfTeachers++;
        }
        // A method in the class Teacher
        public void print(){
            Console.WriteLine("Name: " + name_);
            Console.WriteLine("Subject: " + subject_);
            Console.WriteLine("Age: " + age_);
            Console.WriteLine("Number of Years Teaching: " + noOfYearsTeaching_);
        }
    }

    // STRUCTS
    // A struct is a collection of variables of different data types under one unit.
    // It is similar to a Class because both are user-defined data types and can hold different types of data. However it has less features.
    public struct Position {
        // Data Members of Struct Position
        public float x_coor, y_coor;
        // Non-default Contructor, however you can't add a Deafult Constructor
        public Position(float x, float y) {
            x_coor = x;
            y_coor = y;
        }
        // public Position() { // will cause error cause structs can't have deffault constructor
        //     x_coor = 2;
        //     y_coor = 3;
        // }
        // A method in struct
        public void print() {
            Console.WriteLine("Position: (" + x_coor + ", " + y_coor + ")");
        }
    }
    class classes_and_structures
    {
        static void Main(string[] args)
        {
            // Instantiating an Object from Class
            Teacher Feynman = new Teacher("Feynman", "Physics", 71, 45);
            Feynman.print();
            Console.WriteLine();
            Teacher Newton = new Teacher();
            Newton.print();
            Console.WriteLine();
            // Instantiatin a Struct
            Position myPosition = new Position(12, 34);
            // Position yourPosition = new Position(); will cause error cause structs can't do this
            myPosition.print();
            // yourPosition.print();
        }
    }
}
