using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_II_training
{
    internal class IMypets : IAnimal
    {
        private int eyes, ears, legs;
        private string? name = string.Empty;

        public IMypets(int eyes, int ears, int legs, string? name)
        {
            this.eyes = eyes;
            this.ears = ears;
            this.legs = legs;
            this.name = name;
        }

        public int Eyes { get => eyes; set => eyes = value; }
        public int Ears { get => ears; set => ears = value; }
        public int Legs { get => legs; set => legs = value; }
        public string? Name { get => name; set => name = value; }

        public void aboutme()
        {
            Console.WriteLine($"I have {eyes} eyes {ears} ears and {legs} legs ");
        }

        public void sleep()
        {
            Console.WriteLine("sleeping da thangam");
        }

        public void eat()
        {
            Console.WriteLine("Yummy");
        }
        public override void sound()
        {
            if (Name.Equals("Dog"))
            {
                Console.WriteLine("Dow Dow");
            }
        }

    }
}
