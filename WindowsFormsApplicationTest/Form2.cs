using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryTest.Computer;
namespace WindowsFormsApplicationTest
{
    public partial class Form2 : Form
    {
        GenericStack<string> stack = new GenericStack<string>();
        public Form2()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            button1.Click += Display;
            button3.Click += Button3_Click;
            button3.Click += Display;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            stack.Pop();
        }

        private void Display(object sender, EventArgs e)
        {
            label1.Text = stack.DisplayAll();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                stack.Push(textBox1.Text);
                textBox1.Text = "";
            }
        }
    }
}
