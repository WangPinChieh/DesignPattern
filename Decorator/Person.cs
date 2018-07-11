using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    class Person
    {
        private string Name;
        public Person() { }
        public Person(string name) {
            this.Name = name;
        }
        public virtual void Show() {
            Console.WriteLine("裝扮的{0}", this.Name);
        }
    }
}
