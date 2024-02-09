using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label3.BackColor = Color.Red;
            label4.BackColor = Color.Red;
            label5.Text = "Meltdown Imminent";
            Refresh();
            Thread.Sleep(1000);
            label3.BackColor = Color.White; //
            label4.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            label3.BackColor = Color.Red;
            label4.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);
            label3.BackColor = Color.White;
            label4.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
        }
    }
}
