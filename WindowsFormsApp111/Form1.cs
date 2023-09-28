using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int x = int.Parse(textBox2.Text);
            cTarkib t = new cTarkib();
            t.n = n;
            t.x = x;
            int result = t.Combinition(Factorial);
            listBox1.Items.Add(result);
        }

        private double Factorial(int n)
        {
            double s = 1;

            for (int i = n; i >= 1; i--)
                s *= i;
            return s;
        }
    }
}
