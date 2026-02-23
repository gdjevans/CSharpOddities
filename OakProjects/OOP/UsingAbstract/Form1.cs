using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingAbstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        abstract class Vehicle
        {
            public abstract double GetFuelAmount();

        }

        class Bus : Vehicle
        {
            public override double GetFuelAmount()
            {
                return 300;
            }
        }

        class Truck : Vehicle
        {
            public override double GetFuelAmount()
            {
                return 500;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            Vehicle vc;
            vc = new Bus();
            double busfuel = vc.GetFuelAmount();
            text = "Bus fuel amount is: " + busfuel.ToString() + Environment.NewLine;
            vc = new Truck();
            double truckfuel = vc.GetFuelAmount();
            text += "Truck fuel amount is: " + truckfuel.ToString() + Environment.NewLine;
            textBox1.Text = text;  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
