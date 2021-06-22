using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public bool HasScales { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool HasClaws { get; set; }
        public int Eyes { get; set; }

        public Reptile()
        {

        }

        public Reptile(string name, int age, int legs, bool hasTeeth, bool hasScales, bool isColdBlooded, bool hasClaws, int eyes)
        {
            Name = name;
            Age = age;
            Legs = legs;
            HasTeeth = hasTeeth;
            HasScales = hasScales;
            IsColdBlooded = isColdBlooded;
            HasClaws = hasClaws;
            Eyes = 2;

        }


    }

}
