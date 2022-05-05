using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIST_3_UKOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<char> znaky;
        string Vypis(List<char> list)
        {
            string znak1 = "";
            foreach (char znaky in list)
            {
                znak1 += znaky;
            }
            return znak1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            string veta = textBox1.Text;
            znaky = new List<char>();
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button) 
                {
                    (ctrl as Button).Enabled = true;
                } 
            }
            foreach (char c in veta) {
                znaky.Add(c);
                listBox1.Items.Add(c);
            }
            button1.Enabled = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
            Button tlc = (sender as Button);
            char pis = Convert.ToChar(tlc.Text);

            while (znaky.Contains(pis))
            {
                znaky.Remove(pis);
            }
            textBox1.Text = Vypis(znaky);
            tlc.Enabled = false;
            listBox1.Items.Clear();
            foreach (char c in znaky)
            {
                listBox1.Items.Add(c);
            }
        }
    }
}
