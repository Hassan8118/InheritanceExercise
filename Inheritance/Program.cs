using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            
            var myBird = new Bird();
            myBird.WingColor = "green";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.BeakLength = 2.5;

           
            var lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScary = true,
                Habitat = "swamp",
                CanGrowTail = true
            };
            var myAnimals = new Animal[] { myBird, lizard };

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

          

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.isAlive}");
                Console.WriteLine($"Age:{animal.Age}");
                Console.WriteLine($"It has {animal.LegCount} legs");
                Console.WriteLine($"Can Breathe: {animal.canBreathe}");
                Console.WriteLine($"");
            }
        }
    }
}
