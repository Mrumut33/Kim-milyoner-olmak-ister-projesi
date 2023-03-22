using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Karar_Yapıları
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2;
            string islem;           
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            islem = comboBox1.Text;
            switch (islem)
            {
                case "+": textBox3.Text = Convert.ToString(s1 + s2); break;
                case "-": textBox3.Text = Convert.ToString(s1 - s2); break;
                case "*": textBox3.Text = Convert.ToString(s1 * s2); break;
                case "/": textBox3.Text = Convert.ToString(s1 / s2); break;
                default: textBox3.Text = "Hatalı işlem girdiniz"; break;
                   
            }
            s1 = Math.Round(s1, 2);
            s2 = Math.Round(s2, 2);



        }

       
        }
    }
    

