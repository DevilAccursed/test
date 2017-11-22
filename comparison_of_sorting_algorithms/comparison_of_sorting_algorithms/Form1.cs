using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace comparison_of_sorting_algorithms
{
    public partial class Form1 : Form
    {
        // поля класса - формы для тестирования
        Solution testsolution;  //задание формы ,кот будет вызываться из главной формы; testsolution объект класса Solution
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            testsolution = new Solution();          
            testsolution.Show();                    // показ формы на экран
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar>='0') && (e.KeyChar)<='9')
            {
                return;
            }
            e.Handled = true;
           
        }

        private void TextBox2_keyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar) <= '9')
            {
                return;
            }
            e.Handled = true;

        }

        private void inp_TextChanged(object sender, EventArgs e)
        {
            string s;
            s = textBox1.Text;
            Console.WriteLine(s);
        }
    }
}
