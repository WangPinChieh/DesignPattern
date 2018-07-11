using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignPattern.Decorator;
using DesignPattern.Proxy;
using DesignPattern.Factory;
namespace DesignPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person P = new Person("Jay");
            TShirts TShirt = new TShirts();
            BigTrouser BigTrouser = new BigTrouser();
            TShirt.Decorate(P);
            BigTrouser.Decorate(TShirt);

            BigTrouser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProxyAgent p = new ProxyAgent("嬌嬌");
            p.GiveChocolate();
            p.GiveDolls();
            p.GiveFlowers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IFactory F = new UndergraduateFactory();
            ConcreteComponent C = F.CreateCC();
            C.BuyRice();
            C.Sweep();
            C.Wash();
        }
    }
}
