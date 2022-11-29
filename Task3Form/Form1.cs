using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            x = (double) XnumericUpDown.Value;
            y = (double) YnumericUpDown.Value;

            if ((x > -15 && y > -15 && y < 0 && x < 0))
                MessageBox.Show("Вне");
            else if (x < -15 || y < -15 || y > 0 || x > 0)
                MessageBox.Show("Внутри");
            else MessageBox.Show("На границе");



        }
    }
}
