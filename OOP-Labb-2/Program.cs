using System;

namespace OOP_Labb_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            App();
        }

        private static void App()
        {
            // Instantiate three animal classes that inherit properties from the class Animal
            Dog dog = new Dog(2, "Doggo", "This is a dog called doggo, he is a nice dog.", "Woof", "Brown", true);
            Cat cat = new Cat(12, "Ariana", "This cat is named after ariana grandes roll 'cat' in a series called 'sam and cat'.", "Meow", "White", true);
            Monkey monkey = new Monkey(8, "Donkey Kong", "The monkey Donkey Kong is a strong and stupid monkey.", "Ooooh Ooooh Aaaah Aaaah", "Black", 4);

            // Intantiate two different dogs that inherit from the Dog class
            Bulldog bulldog = new Bulldog(4, "Ford", "This is a Bulldog called Ford, he is named after the contry artist Colt Ford.",
                "*woof* Contry as Truck *woof*", "Orange", true, true);
            Chihuahua chihuahua = new Chihuahua(7, "Karen", "This dog is the definition of hell",
                "Wof wof wooof wof wof wooof", "Gray", true, 100);

            dog.MakeSound();
            cat.MakeSound();
            monkey.MakeSound();
            bulldog.MakeSound();
            chihuahua.MakeSound();
        }
    }
}
