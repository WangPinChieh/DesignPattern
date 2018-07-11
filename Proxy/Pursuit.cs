using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
    class Pursuit : IGiveGift
    {
        public string SchoolGirl;

        public Pursuit(string name) {
            this.SchoolGirl = name;
        }

        public void GiveDolls()
        {
            Console.WriteLine(this.SchoolGirl + "GiveDolls");
        }

        public void GiveChocolate()
        {
            Console.WriteLine(this.SchoolGirl + "GiveChocolate");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(this.SchoolGirl + "GiveFlowers");
        }
    }
}
