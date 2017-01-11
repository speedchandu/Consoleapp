using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationTest
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
            button1.DoubleClick += Button1_DoubleClick;
            button2.DoubleClick += Button2_DoubleClick;
            button1.Click += Button1_Click;
            button2.Click += Button1_Click;
            button1.Click += Button1_Click1;
            button2.Click+= Button1_Click1;
        }

        private void Button1_Click1(object sender, EventArgs e)
        {
            label2.Text = (count * 3).ToString();
        }
        int count = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = count.ToString();
        }

        
        private void Button2_DoubleClick(object sender, EventArgs e)
        {
            txtlabel.Text = "cancel button double clicked";
        }

        private void Button1_DoubleClick(object sender, EventArgs e)
        {
            txtlabel.Text = "ok button double clicked";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtlabel.Text = "ok button clicked";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtlabel.Text = "Cancel button clicked";
        }
    }
}
