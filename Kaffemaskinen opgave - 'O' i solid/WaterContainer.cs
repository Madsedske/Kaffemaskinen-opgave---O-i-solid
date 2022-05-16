using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen_opgave____O__i_solid
{
    public class WaterContainer
    {
        private double waterCapacityML;

        public double WaterCapacityML
        {
            get { return waterCapacityML; }
            set { waterCapacityML = value; }
        }

        public void PourWaterIn(double water)
        {
            WaterCapacityML = water;
        }
    }
}
