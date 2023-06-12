using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR16_Sydorenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Cufry
        {
            private string a;
            public string A { get { return a; } set { a = value; } }
            private string b;
            public string B { get { return b; } set { b = value; } }
            public Cufry()
            {
            }
            public Cufry(string g, string v)
            {
                this.a = g;
                this.b = v;
            }
            public int Add()
            {                
                int s = Convert.ToInt32(a,16) + Convert.ToInt32(b,16);
                return s;
            }
            public int Vid()
            {
                int s = Convert.ToInt32(a,16) - Convert.ToInt32(b,16);
                return s;
            }
            public int Mnohz()
            {
                int s = Convert.ToInt32(a,16) * Convert.ToInt32(b,16);
                return s;
            }
            public double Dil()
            {
                int s = Convert.ToInt32(a,16) / Convert.ToInt32(b,16);
                return s;
            }
            public int Dw(string g)
            {
                int f = Convert.ToInt32(g, 2);
                return f;
               
            }
            public int Des(string g)
            {
                int f = Convert.ToInt32(g, 10);
                return f;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Відсортовати в порядку убування в шіснадцятковій системі числення";
            button2.Text = "Відсортовати в порядку убування в десятковій системі числення";
            label2.Text = "";
            label3.Text = "";
            button3.Text = "Вивети числа в шістнадцятковій системі";
            button4.Text = "Додати числа";
            button5.Text = "відняти числа";
            button6.Text = "Помножити числа";
            button7.Text = "Поділити числа";
            button8.Text = "Перевести в двійкову систему";
            button9.Text = "Перевести в десяткову систему";
            label11.Text = "сума";
            label12.Text = "різниця";
            label13.Text = "добуток";
            label14.Text = "частка";
            label15.Text = "нове число";
            label16.Text = "нове число";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ter = textBox1.Text;
            string[] ger = ter.Split(',');
            int jok = ger.Length;
            int[] hk = new int[jok];
            for (int i = 0; i < jok; i++)
            {
                hk[i] = Convert.ToInt32(ger[i], 16);
            }            
            Array.Sort(hk, Comparer<int>.Create((x, y) => y.CompareTo(x)));
            label2.Text = string.Join(",", hk);
            /*48,65,6C,6C,6F,20,57,6F,72,6C,64,21*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fg = textBox1.Text;
            string[] ger = fg.Split(',');
            int jok = ger.Length;
            int[] hk = new int[jok];
            for (int i = 0; i < jok; i++)
            {
                hk[i] = Convert.ToInt32(ger[i], 10);
            }
            Array.Sort(hk, Comparer<int>.Create((x, y) => y.CompareTo(x)));
            label3.Text = string.Join(",", hk);
            label3.Text.Trim();
            /*48,65,6C,6C,6F,20,57,6F,72,6C,64,21*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cufry se = new Cufry(textBox2.Text, textBox3.Text);
            textBox4.Text = textBox6.Text = textBox8.Text = textBox10.Text = textBox12.Text = textBox14.Text = se.A;
            textBox5.Text = textBox11.Text = textBox7.Text = textBox13.Text = textBox9.Text = textBox15.Text = se.B; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cufry se = new Cufry(textBox4.Text, textBox5.Text);
            se.A = textBox4.Text;
            se.B = textBox5.Text;
            label11.Text = Convert.ToString(se.Add());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cufry se = new Cufry(textBox6.Text, textBox7.Text);
            se.A = textBox6.Text;
            se.B = textBox7.Text;
            label12.Text = Convert.ToString(se.Vid());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cufry se = new Cufry(textBox8.Text, textBox9.Text);
            se.A = textBox8.Text;
            se.B = textBox9.Text;
            label13.Text = Convert.ToString(se.Mnohz());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cufry se = new Cufry(textBox10.Text, textBox11.Text);
            se.A = textBox10.Text;
            se.B = textBox11.Text;
            label14.Text = Convert.ToString(se.Dil());
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Cufry se = new Cufry(textBox12.Text, textBox13.Text);
            se.A = textBox12.Text;
            se.B = textBox13.Text;
            string fo = Convert.ToString(se.Des(se.A));
            string fl = Convert.ToString(se.Des(se.B));
            label15.Text = $"{fo} and {fl}";
            label15.Text.Trim();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Cufry se = new Cufry(textBox14.Text, textBox15.Text);
            se.A = textBox14.Text;
            se.B = textBox15.Text;
            string fo = Convert.ToString(se.Des(se.A));
            string fl = Convert.ToString(se.Des(se.B));
            label16.Text = $"{fo} and {fl}";
            label16.Text.Trim();
        }




        /*private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }

            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }            
            if (e.KeyChar == 'A')
            {
                // цифра
                return;
            }
            if (e.KeyChar == 'B')
            {
                // цифра
                return;
            }
            if (e.KeyChar == 'C')
            {
                // цифра
                return;
            }
            if (e.KeyChar == 'E')
            {
                // цифра
                return;
            }
            if (e.KeyChar == 'F')
            {
                // цифра
                return;
            }
            if (e.KeyChar == ',')
            {
                // цифра
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button2.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }*/
    }
}
