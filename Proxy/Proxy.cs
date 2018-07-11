using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
    class ProxyAgent : IGiveGift
    {
        Pursuit p;
        public ProxyAgent(string name) {
            p = new Pursuit(name);
        }
        public void GiveDolls()
        {
            p.GiveDolls();
        }

        public void GiveChocolate()
        {
            p.GiveChocolate();
        }

        public void GiveFlowers()
        {
            p.GiveFlowers();
        }
    }
}
