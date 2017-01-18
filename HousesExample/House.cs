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

        public House(string color, int rooms, int size, int doors)
        {
            this.color = color;
            this.rooms = rooms;
            this.size  = size;
            this.doors = doors;
        }

        public void Paint(string newColor)
        {
            color = newColor;
        }
        public string CurrentColor()
        {
            return color;
        }
        public void DisplayHouseInfo()
        {
            Console.Write("House Color: " + color);
            Console.Write(", Rooms: " + rooms);
            Console.Write(", Size is: " + size + " sq/ft");
            Console.WriteLine(", with: " + doors + " doors");
        }
    }
}
