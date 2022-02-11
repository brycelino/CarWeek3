using System;

namespace week3String
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car(); // declaring car class in main class to use the car class in main
            Console.WriteLine("Enter the speed limit: " ); // ask the user to enter speed limit
            int speedLimit = Convert.ToInt32(Console.ReadLine()); // converts speedlimit to int so the user can input numbers 
            
            

            Console.WriteLine("\nEnter the make of your car: " ); // ask user to enter the make of the car 
            c.make = Console.ReadLine(); // allows user to enter make of their car

            Console.WriteLine("\nEnter the model of your car: "); // asks user to enter the model of their car
            c.model = Console.ReadLine(); // allows the user to enter the model of their car 

            Console.WriteLine("\nEnter the mph you're currently going: "); // asks user to enter the mph they're going 
            c.speed = Convert.ToInt32(Console.ReadLine()); // converts speed to int allows the user to input the speed they're going
            c.demerit = (c.speed - speedLimit) / 5; // calculate the total number of demerits 

            if (c.speed <= speedLimit) // compares the speed to speed limit if under the speed limit they're ok
                Console.WriteLine("\n" + c.make + " " + c.model + " " + c.speed + "mph: " + "OK");
            else if (c.demerit < 10 && speedLimit < c.speed) // determines if user has demerits and compares speed limit to user speed
            {

                Console.WriteLine("\n" + c.make + " " + c.model + " " + c.speed + "mph: " + c.demerit + " demerits ");

            }
            else
               if (c.demerit >= 10 && speedLimit < c.speed) // determines if the user has over 10 demerits if so license suspended and compares user speed to speed limit, 
                    Console.WriteLine("\n" + c.make + " " + c.model + " " + c.speed + "mph: " + c.demerit + " demerits " + "<LICENSE SUSPENDED>");
        }
    }
    public class Car // car class stores attributes of car 
    {
        public string make; // string for make of the car
        public string model; // string for model of the car
        public int speed; // int for speed the user car is going 
        public int demerit; // int for the demerits
    }
}
