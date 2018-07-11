using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    class Finery : Person
    {
        protected Person component;

        public void Decorate(Person component) {
            this.component = component;
        }

        public override void Show()
        {
            if (this.component != null)
                this.component.Show();
        }
    }
}
