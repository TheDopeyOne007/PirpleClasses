using System;

namespace homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++) {
                bool isPrime = true;
                string str = "";
                if(i % 3 == 0) {
                    str += "Fizz";
                } 
                if(i % 5 == 0) {
                    str += "Buzz";
                } 
                int newNum = (int)Math.Floor(Math.Sqrt(i));
                for(int j = 2; j <= newNum; j++) {
                    if(i % j == 0) {
                        isPrime = false;
                        break;
                    } 
                }
                if(i == 1) {
                    isPrime = false;
                }
                if(isPrime) {
                    str += " Prime";
                }
                Console.WriteLine(i + " " + str);
            }
        }
    }
}
