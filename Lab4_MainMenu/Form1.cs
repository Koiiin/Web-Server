using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_1;
using Task2_Lab4;
using WebBrowser;
using API_client;
using System.IO;
using System.Diagnostics;

namespace Lab4_MainMenu
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var task1 = new Task_1.Form1();
            task1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var task2 = new Task2_Lab4.Form1();
            task2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var task4 = new WebBrowser.Form1();
            task4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var task3 = new API_client.Form1();
            task3.Show();
        }
    }
}
