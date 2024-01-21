using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Намиране_на_факториел
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Iteration(int n)
        {
            int sum = 1;
            for(int i=1;i<=n; i++) { sum *= i; }
            return sum;
        }
        int Recursion(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Recursion(n - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(numericUpDown1.Text);
            label1.Text=Recursion(n).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(numericUpDown1.Text);
            label1.Text = Iteration(n).ToString();
        }
    }
    
}
