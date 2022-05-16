using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen_opgave____O__i_solid
{
    public class CoffeeContainer
    {
        private double groundCoffeeGram;

        public double GroundCoffeeGram
        {
            get { return groundCoffeeGram; }
            set { groundCoffeeGram = value; }
        }

        private bool filterIn;

        public bool FilterIn
        {
            get { return filterIn; }
            set { filterIn = value; }
        }

        public void InsertFilter()
        {
            filterIn = true;
        }

        public void RemoveFilter()
        {
            groundCoffeeGram = 0;
            filterIn = false;
        }

        public void InsertCoffee(double coffee)
        {
            GroundCoffeeGram = coffee;
        }
    }
}
