using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    class ConcreteComponent
    {
        public void Sweep()
        {
            Console.WriteLine("Sweep");
        }
        public void Wash()
        {
            Console.WriteLine("Wash");
        }
        public void BuyRice()
        {
            Console.WriteLine("BuyRice");
        }
    }
    class UndergraduateStudent : ConcreteComponent
    {
    }
    class Volunteer : ConcreteComponent
    {
    }


    interface IFactory
    {
        ConcreteComponent CreateCC();
    }
    class UndergraduateFactory : IFactory
    {
        public ConcreteComponent CreateCC()
        {
            return new UndergraduateStudent();
        }
    }
    class VolunteerFactory : IFactory
    {
        public ConcreteComponent CreateCC()
        {
            return new Volunteer();
        }
    }
}
