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
        Main m;
        List<Cart> carts;
        public Train(Main main)
        {
            m = main;
            carts = new List<Cart>();
        }

        public void AddToCart(Animals animal)
        {
            bool added = false;

            foreach (Cart c in carts)
            {
                if (c.TryAddAnimal(animal))
                {
                    return;
                }
            }

            if (!added)
            {
                carts.Add(new Cart());
                carts[carts.Count - 1].TryAddAnimal(animal);
            }
        }

        public void printTrain()
        {
            int CartCount = 1;
            m.Print("------------------------------------");
            m.Print("Train");

            foreach (Cart c in carts)
            {
                m.Print("cart: " + CartCount);
                c.PrintAnimals(m);
                CartCount++;
            }
            m.Print("------------------------------------");
        }
    }
}
