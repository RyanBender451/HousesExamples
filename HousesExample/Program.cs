using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House("Green", 4, 1000, 3);
            house1.DisplayHouseInfo();

            //house1.Paint("Green");
            //Console.WriteLine(house1.CurrentColor());

            //house1.Paint("White");
            //Console.WriteLine(house1.CurrentColor());

            //House house2 = new House();
            //house2.Paint("Blue");

            //Console.WriteLine("House 1 is: " + house1.CurrentColor());
            //Console.WriteLine("House 2 is: " + house2.CurrentColor());
          
        }
    }
}
