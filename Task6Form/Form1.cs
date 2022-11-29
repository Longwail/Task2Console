using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 1;
            int[] arr = { 1, 6, 2, 7, 3, 8, 4, 9 };
            string result = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < count; j++)
                    result+=arr[i] + " ";
                result += "\n";
                if (i % 2 == 1)
                    count++;
            }
            richTextBox1.Text = result;
        }
    }
}
