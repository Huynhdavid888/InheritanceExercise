using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public bool HasBeak { get; set; }
        public bool CanFly { get; set; }
        public int Wings { get; set; }
        public string Color { get; set; }

        public Bird()
        {

        }



        public Bird(string name, int age, int legs, bool hasTeeth, bool hasBeak, bool canFly, int wings, string color)
        {
            Name = name;
            Age = age;
            Legs = legs;
            HasTeeth = hasTeeth;
            HasBeak = hasBeak;
            CanFly = canFly;
            Wings = wings;
            Color = color;

        }
    }
}
