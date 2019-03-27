using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListElement
{
    //Example with .NET Generics applied on a vehicle list
    class Vehicle : IComparable<Vehicle>
    {
        //Vehicles property
        public uint NumOfWheels { get; set; }
        public string Color { get; set; }

        //Implement IComparable<Vehicle> CompareTo method in order 
        //to determine sort order on the Vehicle using NumOfWheels
        public int CompareTo(Vehicle that)
        {
            if (this.NumOfWheels > that.NumOfWheels) return 1;
            if (this.NumOfWheels == that.NumOfWheels) return 0;
            return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Create list of Vehicles
            List<Vehicle> vlst = new List<Vehicle>();
            vlst.Add(new Vehicle() {NumOfWheels=4, Color="Red"});
            vlst.Add(new Vehicle() { NumOfWheels = 2, Color = "Blue" });
            vlst.Add(new Vehicle() { NumOfWheels = 6, Color = "Green" });

            //Sort vehicle list - depends on IComparable<Vehicle>
            //in class Vehicle
            vlst.Sort();

            //Write Vehicle list to console
            foreach (Vehicle v in vlst)
            {
                Console.WriteLine("{0},{1}", v.Color, v.NumOfWheels);      
            }
            Console.ReadLine();
        }

        
    }
}
