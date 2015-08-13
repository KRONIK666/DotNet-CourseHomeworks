using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects2
{
    class Automobile : Car
    {
        private float fuelConsumption;
        public float FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public Automobile(int price, float fuelConsumption)
            : base(price)
        {
            this.fuelConsumption = fuelConsumption;
        }
    }
}