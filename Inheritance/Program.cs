//-JESUS
using System;
using System.Runtime.InteropServices;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes-

            // Create a class Animal
            // give this class 4 members that all Animals have in common-Done


            // Create a class Bird
            // give this class 4 members that are specific to Bird-Done
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile-Done
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
            =
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var hummingbird = new Bird();
            hummingbird.age = 4;

            hummingbird.chirp=true;
            hummingbird.name = "Bryan";
            hummingbird.canfly=true;


            hummingbird.Print(hummingbird.age, hummingbird.chirp, hummingbird.name, hummingbird.canfly);




            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var lizard = new Reptile();

            lizard.name = "Bob";
            lizard.chirp = false;
            lizard.age = 6;
            lizard.arecarnivore=true;


            Console.WriteLine($"Hey guys my name is {lizard.name} and I am a lizard. It is {lizard.chirp} that I can chirp. I dont have that capability. I am {lizard.age} years old!. It`s crazy because in the wild I only live for 5 years, but thankfully I have a owner and she takes good care of me and I can live up to 50 years!. My favorite food are flies and bugs. This makes it {lizard.arecarnivore} that I am a carnivore lolll");






        }
    }
}
