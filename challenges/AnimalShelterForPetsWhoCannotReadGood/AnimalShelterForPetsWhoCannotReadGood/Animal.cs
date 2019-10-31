using System.Collections;

namespace AnimalShelterForPetsWhoCannotReadGood
{
    internal class Animal
    {

        public Animal(string animalName, string animalType)
        {
        AnimalName = animalName;
        AnimalType = animalType;
        }
        public string AnimalName { get; set; }
        public string AnimalType { get; set; }


        Stack stack1 = new Stack();

        Stack stack2 = new Stack();

        public void Enqueue(string animal)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(animal);
        }

        public string Dequeue(string pref)
        {
            string animal = (string)stack1.Pop();
            return pref;
        }
    }
}