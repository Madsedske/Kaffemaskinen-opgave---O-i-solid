using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kaffemaskinen_opgave____O__i_solid
{
    public class Program
    {
        static CoffeeMachine machine = new CoffeeMachine();
        static WaterContainer waterContainer = new WaterContainer();
        static CoffeeContainer coffeeContainer = new CoffeeContainer();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Insert filter? \n Yes or no?");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    coffeeContainer.InsertFilter();
                }
                else if (answer == "no")
                {
                    Console.WriteLine("Then u cant make coffee...");
                }

                Console.WriteLine("Fill it with coffee ground? How much in gram?");
                coffeeContainer.InsertCoffee(Convert.ToDouble(Console.ReadLine()));


                Console.WriteLine("Pour some water in the container in ml");
                waterContainer.PourWaterIn(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("Start it?");
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("The machine is making coffee");
                    machine.Start();
                    Thread.Sleep(5000);
                    machine.Stop();
                    Console.WriteLine("DONE!");
                }
                else if (answer == "no")
                {
                    Console.WriteLine("What else?");
                }

                Console.WriteLine("Remove the old filter? yes?");
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("It's in the garbage");
                    coffeeContainer.RemoveFilter();
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
