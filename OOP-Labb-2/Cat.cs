using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace OOP_Labb_2
{
    internal class Cat : Animal
    {
        protected bool IsInsideCat = false;
        public Cat(int age, string name, string description, string sound, string color, bool isInsideCat) : base(age, name, description, sound, color)
        {
            this.IsInsideCat = isInsideCat;
        }
        
        public void GetCatLocation() {
            if (!IsInsideCat) {
                Console.WriteLine("{0} the cat, is probably outside.", this.Name);
            } else { 
                Console.WriteLine("{0} the cat, is probably inside.", this.Name);
            }
        }

    }
}
