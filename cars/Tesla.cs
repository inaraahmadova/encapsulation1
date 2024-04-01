using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    internal class Tesla:ElectricCar
    {
        public string Model { get; set; }
        public void MaxSpeed()
        { 
            switch (Battery) 
            {
                case > 80:
                    Console.WriteLine("max speed is 350");
                    break;
                case > 60:
                    Console.WriteLine("max speed is 300");
                    break;
                case > 40:
                    Console.WriteLine("max speed is 220");
                    break;
                case > 20:
                    Console.WriteLine("max speed is 150");
                    break;
            }
        }
        public void Drive()
        {
            Random r = new Random();
            byte usedBattery = Convert.ToByte(r.Next(30));
            Battery -= usedBattery;
            Console.WriteLine($"Driver used {usedBattery}% battery. Battery: {Battery}");
        }
    }
}
