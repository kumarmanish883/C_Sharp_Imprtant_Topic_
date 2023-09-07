using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
    class Car
    {
        string carModel;
        int carYear;

        public Car(string model,int year)
        {
            carModel = model;
            carYear = year;
        }
        public Car(int year,string model)
        {
            carModel = model;
            carYear = year;
        }
        static void Main(string[] args)
        {
            Car mycar = new Car("Suzuki",1998);
            Console.WriteLine("CarModel:" +mycar.carModel);
            Console.WriteLine("Year:" +mycar.carYear);
            Console.ReadLine();
        }
    }
}

