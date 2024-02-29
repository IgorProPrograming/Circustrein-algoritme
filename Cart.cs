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
            if (currentCapacity + Convert.ToInt32(animal.Size) > CARTSIZE || AnimalsWillEatMe(animal))
            {
                return false;
            } else
            {
                animals.Add(animal);
                currentCapacity += Convert.ToInt32(animal.Size);
                return true;
            }
        }

        private bool AnimalsWillEatMe(Animals animal)
        {
            foreach (Animals anim in animals)
            {
                if (anim.Carnivore && anim.Size >= animal.Size)
                {
                    return true;
                }
            }
            return false;
        }

        public void PrintAnimals() 
        {
            foreach (Animals animal in animals)
            {
                Console.WriteLine(animal.Size.ToString() + " " + animal.Carnivore.ToString());
            }
        }
    }
}
