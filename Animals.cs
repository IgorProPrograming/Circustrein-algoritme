using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_algoritme
{
    internal class Animals
    {
        public int size { get; set; }
        public bool carnivore { get; set; }

        public int Size { get { return size; } }
        public bool Carnivore { get {  return carnivore; } }

        public Animals(int _size, bool _carnivore)
        {
            size = _size;
            carnivore = _carnivore;
        }
    }
}
