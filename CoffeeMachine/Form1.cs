using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMachine
{
    public partial class Form1 : Form
    {
        WaterModule waterModule = new WaterModule();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int units = Convert.ToInt32(textBox1.Text);
            waterModule.FillWater(units);
            label1.Text = waterModule.WaterLevel.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int units = Convert.ToInt32(textBox1.Text);
            waterModule.TakeWater(units);
            label1.Text = waterModule.WaterLevel.ToString();
        }


    }
}
