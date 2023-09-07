using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("Hello, i am constructor");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.ReadLine();
        }
    }
}
