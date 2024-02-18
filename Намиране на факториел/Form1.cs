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

        //метод за намиране на факториел итеративно
        long Iteration(int n)//методът ще връща число от тип long и има параметър n
        {
            //променлива, в която ще се запазва сумата
            long sum = 1;

            //цикъл, чрез който ще обходим всички числа от 1 до n
            for(int i=1;i<=n; i++) 
            { 
                //сумата става равна на старата си стойност умножена по i
                sum *= i; 
            }

            //ретърнваме сумата
            return sum;
        }

        //метод за намиране на факториел рекурсивно
        long Recursion(int n)//методът отново ще връща long и има параметър n
        {
            //краят на рекурсията ще бъде 0

            //проверяваме дали n е 0
            if (n == 0)
            {
                //ако е връщаме 1
                return 1;
            }

            //ако не викаме метода отново умножен с n
            return n * Recursion(n - 1);
        }

        //Рекурсивно
        private void button1_Click(object sender, EventArgs e)
        {
            //взимаме стойноста на n от потребителя
            int n = int.Parse(numericUpDown1.Text);

            //извеждаме резултата
            label1.Text=Recursion(n).ToString();

        }

        //Итеративно
        private void button2_Click(object sender, EventArgs e)
        {
            //взимаме стойноста на n от потребителя
            int n = int.Parse(numericUpDown1.Text);

            //извеждаме резултата
            label1.Text = Iteration(n).ToString();
        }
    }
    
}
