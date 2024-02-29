using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_algoritme
{
    internal class Cart
    {
        const int CARTSIZE = 10;
        int currentCapacity = 0;

        List<Animals> animals;

        public Cart()
        {
            animals = new List<Animals>();
        }

        public bool TryAddAnimal(Animals animal)
        {
            if (currentCapacity + Convert.ToInt32(animal.size) > CARTSIZE)
            {
                return false;
            } else
            {
                animals.Add(animal);
                currentCapacity += Convert.ToInt32(animal.size);
                return true;
            }
            
        }

        public void PrintAnimals() 
        {
            foreach (Animals animal in animals)
            {
                Console.WriteLine(animal.size.ToString() + " " + animal.carnivore.ToString());
            }
        }
    }
}
