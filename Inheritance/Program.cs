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
            Bird peacock = new Bird()
            {
                Name = "Peacock",
                Age = 25,
                Legs = 2,
                HasTeeth = false,
                HasBeak = true,
                CanFly = false,
                Wings = 2,
                Color = "Blue & Green"
            };

            Console.WriteLine($"The {peacock.Name} is a beautiful bird that can live up to {peacock.Age} years." + 
                $" This bird is known to have {peacock.Legs} legs, {peacock.Wings} wings, and a beautiful {peacock.Color} color.");
            Console.WriteLine($"Is the {peacock.Name} an animal that has teeth, a beak and can it fly?" + $"{peacock.HasTeeth}, {peacock.HasBeak}, and {peacock.CanFly}");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Reptile gecko = new Reptile()
            {
                Name = "Gecko",
                Age = 15,
                Legs = 4,
                HasTeeth = true,
                HasScales = false,
                IsColdBlooded = true,
                HasClaws = true,
                Eyes = 2,
            };

            Console.WriteLine($"The {gecko.Name} is a small lizard that has {gecko.Legs} legs that give them stability and locomotion while their {gecko.Eyes} eyes are super sensative to light."
                 + $" The {gecko.Name} can live up to {gecko.Age} years but some types of geckos can live even longer!");
            Console.WriteLine($" Is the {gecko.Name} an animal that has teeth, is cold blooded, has claws and scales?" + 
                $"{gecko.HasTeeth}, {gecko.IsColdBlooded}, {gecko.HasClaws} and {gecko.HasScales}");
        }
    }
}
