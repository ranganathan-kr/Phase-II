using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_II_training
{
    internal class Mypets : Animal
    {
        private string? name =string.Empty;


        public Mypets(int eyes, int ears, int legs,string name) : base(eyes, ears, legs)
        {
            this.Name = name;
        }

        public string? Name { get => name; set => name = value; }

        public void sound()
        {
            if(Name.Equals("Dog"))
            {
                Console.WriteLine("Dow Dow");
            }
        }
    }
}
