using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_2
{
    internal class Bulldog : Dog
    {

        protected bool IsEasyToTrain = false;
        
        public Bulldog(int age, string name, string description, string sound, string color, bool isFriendly, bool isEasyToTrain) 
            : base(age, name, description, sound, color, isFriendly)
        {
            this.IsEasyToTrain = isEasyToTrain;
        }

        public void Train() {
            if (!this.IsEasyToTrain) {
                Console.WriteLine("{0} the bulldog did not want to train.", this.Name);
            } else {
                Console.WriteLine("{0} would gladly train.", this.Name);
            }
        }
    }
}
