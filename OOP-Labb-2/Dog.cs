using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OOP_Labb_2
{
    internal class Dog : Animal
    {

        protected bool IsFriendly { get; set; }

        public Dog(int age, string name, string description, string sound, string color, bool isFriendly) : base(age, name, description, sound, color)
        {
            this.IsFriendly = isFriendly;
        }

        public void GiveDogTreats()
        {
            if (!this.IsFriendly) { 
                Console.WriteLine("{0} chewed on your hand like a chewing toy.", this.Name); 
            } else { 
                Console.WriteLine("{0} enjoyed your treats.", this.Name); 
            }
        }
    }
}
