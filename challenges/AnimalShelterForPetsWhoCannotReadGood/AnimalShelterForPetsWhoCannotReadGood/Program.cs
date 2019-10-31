using System;
using static AnimalShelterForPetsWhoCannotReadGood.Animal;

namespace AnimalShelterForPetsWhoCannotReadGood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animal Shelter!");

            var dog1 = new Animal("hatchiko", "dog");

            Animal animal = new Animal(string animalName, string animalType);
            animal.Enqueue(dog1);
            animal.Enqueue("dog");
            animal.Enqueue("cat");
            animal.Enqueue("dog");
            animal.Enqueue("cat");

            Console.WriteLine("What type of animal do you want to adopt? (cat or dog)");
            string input = Console.ReadLine();
            string pref = input.ToLower();


            Console.WriteLine(animal.Dequeue());
            Console.WriteLine(animal.Dequeue());
            Console.WriteLine(animal.Dequeue());
            Console.WriteLine(animal.Dequeue());
            Console.WriteLine(animal.Dequeue());
        }
    }
}
