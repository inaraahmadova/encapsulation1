using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    internal class ElectricCar:Car
    {
        private byte _battery=100;
        protected byte Battery 
        {  
            get => _battery;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("+battery empty");

                    _battery = 0;
                }
                else
                {
                    _battery = value;
                }
            }
        }
    }
}
