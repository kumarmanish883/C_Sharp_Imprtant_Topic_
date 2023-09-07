using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methhod_Overriding
{
    class Animal
    {
        //This is Metod of parent class
        public void Eat()
        {
            Console.WriteLine("Animal is eating food.");
        }

        
    }
    class Dog:Animal
    {
        //this is the same method  as parent class in Child class .
        public void Eat()
        {
            Console.WriteLine("Dog is eating food.");
        }
        public static void Main (string[] args)
        {
            Dog GermenSepherd = new Dog();
            GermenSepherd.Eat();
            Console.ReadLine();
        }
    }
}
