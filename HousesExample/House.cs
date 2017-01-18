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
        private string name;
  

        public string Name
        {
            get { return this.name;  }
            set { this.name = value; }
     
        }

        public House()
        {
            this.color = "Steel";
            this.rooms = 6;
            this.size = 1230;
            this.doors = 2;
        }

        public House(string color, int size)
        {
            this.color = color;
            this.size = size;
            this.rooms = 3;
            this.doors = 5;
        }
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
