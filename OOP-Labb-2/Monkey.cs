using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Labb_2
{
    internal class Monkey : Animal
    {
        protected int IQ = 0;

        public Monkey(int age, string name, string description, string sound, string color, int iq) : base(age, name, description, sound, color)
        {
            this.IQ = iq;
        }

        public void DevelopSpyEquipment() {
            if (this.IQ <= 50) {
                Console.WriteLine("{0} lack the inteligence to develop spy gear.");
            } else if (this.IQ <= 100) {
                Console.WriteLine("{0} will take 30 years to develop spy gear.");
            } else if (this.IQ > 100) {
                Console.WriteLine("{0} is a smart boy, he can develop everything!");
            }
        }
    }
}
