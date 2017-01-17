using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesExample
{
    class House
    {
        private string color;
        private int rooms;
        private int size;
        private int doors;
        static private int avgHousePrice;

        public void Paint(string newColor)
        {
            color = newColor;
        }
        public string CurrentColor()
        {
            return color;
        }
    }
}
