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

            
            House house2 = new House("Blue", 700);
            House house3 = new House();

            //house2.DisplayHouseInfo();
            //house2.Paint("Yellow");

            //house1.DisplayHouseInfo();
            //house2.DisplayHouseInfo();
            //house3.DisplayHouseInfo();
            //house1.Paint("Green");
            //Console.WriteLine(house1.CurrentColor());
            house2.Name = "The blue house!";
            Console.WriteLine("This is the name of thy house " + house2.Name);
        }
    }
}
