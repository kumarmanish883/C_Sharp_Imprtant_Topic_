using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //string car1 = "Maruti";
            //string car2 = "Ford";
            //string car3 = "B&W";
            //string car4 = "Ferrari";


            string[] Cars = new string[4 ]{ "Maruti", "Ford", "B&W", "Ferrari" };
            //for(int i = 0; i < Cars.Length; i++)
            //{
            //    Console.WriteLine(Cars[i]);
            //}
            foreach(string car in Cars)
            {
                Console.WriteLine(car);
            }
            
            Console.ReadLine();
        }

    }
}
