using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace celsiustofahrenhite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cel, fah;
            cel = (Convert.ToDouble(textBox1.Text) -32)/1.8;  
            celcius.Text = cel.ToString();

            fah = (Convert.ToDouble(textBox2.Text) * 1.8) + 32;
            fahrenhite.Text = fah.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }
    }
}
