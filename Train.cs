using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_algoritme
{
    internal class Train
    {
        const int ONE = 1;
        List<Cart> carts;
        public Train()
        {
            carts = new List<Cart>();
        }

        public void AddToCart(Animals animal)
        {
            foreach (Cart c in carts)
            {
                if (c.TryAddAnimal(animal))
                {
                    return;
                }
            }

            if (carts.Count == 0)
            {
                carts.Add(new Cart());
            }
            bool result = carts[carts.Count - ONE].TryAddAnimal(animal);
            if (!result) 
            {
                carts.Add(new Cart());
                carts[carts.Count - ONE].TryAddAnimal(animal);
            }
        }

        public void printTrain()
        {
            int CartCount = 1;
            Console.WriteLine("Train");

            foreach (Cart c in carts)
            {
                Console.WriteLine("cart: " + CartCount);
                c.PrintAnimals();
                CartCount++;
            }
        }
    }
}
