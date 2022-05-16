using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen_opgave____O__i_solid
{
    public class CoffeeMachine : Appliance, IStartStop
    {
        WaterContainer waterContainer = new WaterContainer();

        private int temperatur;

        public int Temperatur
        {
            get { return temperatur; }
            set { temperatur = value; }
        }

        public void HeatWater()
        {
            for (int i = 0; i <= 90; i++)
            {
                temperatur++;
            }
        }

        public void Start()
        {
            HeatWater();
        }

        public void Stop()
        {
            temperatur = 0;
            waterContainer.WaterCapacityML = 0;
        }
    }
}
