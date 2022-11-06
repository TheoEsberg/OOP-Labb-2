using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_2
{
    internal class Chihuahua : Dog
    {

        protected int ProbabilityToKillYou = 100;

        public Chihuahua(int age, string name, string description, string sound, string color, bool isFriendly, int probabilityToKillYou)
            : base(age, name, description, sound, color, isFriendly)
        {
            this.ProbabilityToKillYou = probabilityToKillYou;
        }

        public void WillItKillMe() {
            if (this.ProbabilityToKillYou < 50) {
                Console.WriteLine("Well yeah. {0} the bastard will probably kill you!", this.Name);
            } else if (this.ProbabilityToKillYou >= 75)
            {
                Console.WriteLine("Yes! You are fucking dead, {0} will kill you!", this.Name);
            } else {
                Console.WriteLine("No you are okay, {0} is a friendly thing!", this.Name);
            }
        }
    }
}
