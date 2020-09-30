using System;
using System.Linq;

namespace homework8
{
    class Program
    {
        static void printError() {
            Console.WriteLine("Invalid Inputs");
        }
        // This might be a messy solution, and I think there are faster and cleaner ways to make this, but I 
        // really wanted to minimize the code and use less if-else statements to check every possible inputs and check
        // so here we go. So I had to define an array where there are pairs and used modulus to get each pair
        static (int, string) timeAdder(int value1, string label1, int value2, string label2) {
            // So we initialize label3 and otherLabel
            // otherLabel holds the string of the secondary time unit
            // seconds < minutes < hours < days; from lowest to greatest
            // we want the label to be the greatest time unit possible, so for example
            // if we were given hours and seconds, we want the label to most possibly be hours since it is greater
            string label3, otherLabel;
            int value3;
            // This tuple is what we will return if the inputs are invalid for calculation
            (int, string) error = (-1, "Error");
            // Here is the string array, I ordered them by putting the plural versions first then after the first half, places
            // the singular ones after, the goal is that each plural-singular units act as pairs when you use modulo
            string[] unitTimes = {"seconds", "minutes", "hours", "days", "second", "minute", "hour", "day"};
                                //    0          1         2        3        4         5        6      7

            int prio1, prio2, prio3 = 0, otherPrio = 0, conversion, temp, otherValue = 0;

            // We check if the label is in the list of unitTimes, and then check if it is singular and only equal to 1,
            // if not, we will return error
            if(unitTimes.Contains(label1) || unitTimes.Contains(label2)) {
                if(!(label1.EndsWith("s")) && (value1 != 1) || !(label2.EndsWith("s")) && (value2 != 1)) {
                    Console.WriteLine("One or both of the inputs is/are singular but does not have a value of just 1");
                    return error;
                }
            } 
            // We check if the label is in the list of unitTimes, and then check if it is plural and that it is greater than 1,
            // if not, we will return error
            if(unitTimes.Contains(label1) && unitTimes.Contains(label2)) {
                if(label1.EndsWith("s") && value1 == 1 || label2.EndsWith("s") && value2 == 1) {
                    Console.WriteLine("One or both of the inputs is/are plural but had a value just one");
                    return error;
                }
            }

            // prio1 = priority 1, or the index of the time unit of the first value in the array
            // prio2 = priority 2, or the index of the time unit of the second value in the array
            prio1 = Array.IndexOf(unitTimes, label1)%4;
            prio2 = Array.IndexOf(unitTimes, label2)%4;
            // Console.WriteLine("prio1 = {0} prio2 = {1}", prio1, prio2);
            // The goal is to always prioritize the time that is higher and then convert the other number to
            // the higher time

            // prior3 = priority 3, gets the index of the higher time
            // otherPrio = other priority, gets the index of the other value
            prio3 = Math.Max(prio1, prio2)%4;
            otherPrio = Math.Min(prio1, prio2)%4;
            // Console.WriteLine("prio3 = {0} otherPrio = {1}", prio3, otherPrio);

            // conversion = how many times we need to convert from one unit to another, so 
            // for converting seconds to hours, we will do it twice, one from seconds to minutes by dividing 60 and
            // then minutes to hours by dividing again by 60, however day will be different since we divide hours by 24 to get days
            conversion = Math.Abs((prio1%4) - (prio2%4));
            // Console.WriteLine("conversion = {0}", conversion);
            
            // label3 = this will hold the higher time label, and will be returned, but can be changed along the way
            // otherLabel = the other label of the other time, just in case, but we didnt really need it since we focused on the higher time label
            label3 = unitTimes[prio3%4];
            otherLabel = unitTimes[otherPrio%4];
            // Console.WriteLine("label3 = {0} otherLabel = {1}", label3, otherLabel);

            // value3 = this holds the value of the higher time
            // otherValue = this holds the lower time which we will convert to the higher time
            value3 = (prio3 == prio1) ? value1 : value2;
            otherValue = (otherPrio == prio2) ? value2: value1;
            // Console.WriteLine("value3 = {0} otherValue = {1}", value3, otherValue);
            
            // if both of the times are on the same level, like seconds and seconds, so we just set each value seperately and it wouldn't matter
            // which is which
            if(prio1 == prio2) {
                value3 = value1;
                otherValue = value2;
                // Console.WriteLine("value3 = {0} otherValue = {1}", value3, otherValue);
            }

            // First if statement, checks if the labels are pairs or are the same
            // if they are, we can add the two values and return it together with the label of the higher time
            // example : 5, "seconds, 6, "seconds" = 11, "seconds"
            // example : 1, "second", 1, "second" = 2, "seconds"
            // example : 1, "day", 5, "days" = 6, "days"

            // First Else if statement, checks if the time unit of our values isn't days, and if they are not the same
            // if they are, we convert the other value into the higher time and if it is greater than 1, we add that value 
            // to value 3, and keep the label of the higher time, so conversion comes into play, which will divide the other value
            // by 60 until it is equal time units
            // example: 11, "minutes", 120, "seconds" = 13, "minutes"
            //    conversion: 1 time     1: 120 / 60 = 2 minutes
            //             so therefore, (11, "minutes + 2, "minutes" = 13, "minutes")

            // Second Else if statement, checks if the higher time unit is days, it does the same thing as the first else if statement, but
            // after it converts to hours, it will check if it can be converted to days and will add that to value3 and keep the label days
            // example: 11, "minutes", 1, "day"
            //    conversion: 2 times    1: 11 / 60 = < 0, so we can ignore this and keep the number of days and return that: 1, "day"
            // example: 25, "days", 1, "second"
            //    conversion: 3 times    1: 1 / 60 = < 0, so we can ignore this and keep the number of days and return that: 25, "days"
            // example: 1, "day", 3600, "seconds"
            //    conversion: 3 times    1: 86400 / 60 = 1,440 minutes
            //                           2: 1,440 / 60 = 24 hours
            //                           3: 24 / 24 - 1 day  now we convert hours to day(s)
            //    so in this example we can add 1 day to the 1 day we already have and return 2, "days"
            if(label1 == label2 || (otherPrio == prio3)) {
                value3 = value1 + value2; 
            } else if(prio3 < 3 && otherPrio < 3) {
                temp = otherValue;
                if(temp >= 60) {
                    for(int i = 0; i < conversion; i++) {
                        temp /= 60;
                    }
                    if(temp > 0) {
                        value3 += temp;
                    }
                }
            } else if(prio3 == 3) {
                temp = otherValue;
                // If the value is in hours, we can convert it to days and add it to value 3
                if(temp >= 24 && otherPrio == 2) {
                    temp /= 24;
                    if(temp > 0) {
                        value3 += temp;
                    }
                } else if(prio3 != 2) {
                    // We convert the value to hours if it isn't hours
                    // and after we convert to hours, we convert to days but only add if the number of days is greater than 1
                    // in our list, hours is set to 2, so if the current isn' t equal 2 we know we need to convert
                    if(temp >= 60) {
                        for(int i = 0; i < conversion - 1; i++) {
                            temp /= 60;
                        }
                        if(temp > 0) {
                            value3 += temp / 24;
                        }
                    }
                }
            }

            // This checks if the value if more than 60 and is in seconds, minutes, hours, and then convert it to the next time unit
            // example: 120, "mins" = 2, "hours"
            if((prio3 == 0 && value3 >= 60) || (prio3 == 1 && value3 >= 60)) {
                value3 /= 60;
                label3 = unitTimes[prio3+1];
            }

            // This checks if the value is more than 24 and its time unit is in hours, so we
            // divide by 24, to get how many days
            if(prio3 == 2 && value3 >= 24) {
                value3 /= 24;
                label3 = unitTimes[prio3+1];
            }

            // Adds "s" to the end of the label if the value is greater than 1, or removes "s" if the value is exactly 1
            if(!(label3.EndsWith("s")) && value3 > 1) {
                label3 = label3.Insert(unitTimes[prio3].Length, "s");
            } else if(label3.EndsWith("s") && value3 == 1) {
                label3 = label3.Remove(label3.Length - 1);
            }

            // We return the value3 and label3, after we have converted to the highest possible time
            return (value3, label3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(timeAdder(47, "hours", 59, "minutes"));
        }
    }
}
