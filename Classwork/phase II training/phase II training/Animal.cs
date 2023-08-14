using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_II_training
{
    //abstract two types -- method and class 
    //aatract =>  base class la declarion (abstract) and  definition in derived class (concrete)
    internal abstract class Animal
    {
        private int eyes, ears, legs;

        public Animal(int eyes, int ears, int legs)
        {
            this.eyes = eyes;
            this.ears = ears;
            this.legs = legs;
        }

        public int Eyes { get => eyes; set => eyes = value; }
        public int Ears { get => ears; set => ears = value; }
        public int Legs { get => legs; set => legs = value; }

        public static void sleep()
        {
            Console.WriteLine("sleeping da thangam");
        }
        
        public static void eat()
        {
            Console.WriteLine("Yummy");
        }
        public void aboutme()
        {
            Console.WriteLine($"I have {eyes} eyes {ears} ears and {legs} legs ");
        }
        public abstract void sound();

    }

}
