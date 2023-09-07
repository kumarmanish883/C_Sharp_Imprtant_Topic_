using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloading
{
    class Program
    {
        public void Test()
        {
            Console.WriteLine("First Method ");
        }
        public void Test(int i)
        {
            Console.WriteLine("Second Method ");
        }
        public void Test(string s)
        {
            Console.WriteLine("Third Method ");
        }
        public void Test(int i,string s)
        {
            Console.WriteLine("Fourth Method ");
        }
        public void Test(string i,int s)
        {
            Console.WriteLine("Fifth Method ");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test();
            p.Test(12);
            
            p.Test("Manish");
            p.Test(45, "Manish");
            p.Test("MAnish", 25);
            Console.ReadLine();
        }
    }
}
