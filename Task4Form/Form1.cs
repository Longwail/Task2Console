using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] maleNames = { "Василий", "Виктор", "Александр", "Анатолий" };
            string[] femaleNames = { "Анжелика", "Анна", "Виктория", "Светлана" };
            Random r = new Random();
            switch (comboBox1.Text)
            {
                case "Мужской":
                    string male = maleNames[r.Next(0, maleNames.Length - 1)];
                    MessageBox.Show(male);
                    break;
                case "Женский":
                    string female = femaleNames[r.Next(0, femaleNames.Length - 1)];
                    MessageBox.Show(female);
                    break;
                default:
                    MessageBox.Show("Выберите пол");
                    break;
            }
        }
    }
}
