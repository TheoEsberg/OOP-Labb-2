using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Labb_2
{
    internal class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sound { get; set; }  
        public string Color { get; set; }

        public Animal(int age, string name, string description, string sound, string color)
        {
            this.Age = age;
            this.Name = name;
            this.Description = description;
            this.Sound = sound;
            this.Color = color;
        }

        public void Eat() { Console.WriteLine("{0} åt lite mat.", this.Name); }
        public void MakeSound() { Console.WriteLine("{0}!", this.Sound); }
        public void GetAge() { Console.WriteLine("{0} är {1} år gammal.", this.Name, this.Age); }
        
    }
}
