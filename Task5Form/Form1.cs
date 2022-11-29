using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 12, 55, 44, 56, 79, 63, 90, 32, 21, 61, 89 };
            string result = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 11 != 0)
                    result+= numbers[i] + " ";
            }
            int iterator = 0;
            while (iterator < numbers.Length)
            {
                if (numbers[iterator] % 11 != 0)
                    result += numbers[iterator] + " ";
                iterator++;
            }
            iterator = 0;
            result = string.Empty;
            do
            {
                if (numbers[iterator] % 11 != 0)
                    result += numbers[iterator] + " ";
                iterator++;

            } while (iterator < numbers.Length);
            MessageBox.Show(result);
        }
    }
}
