using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace add_remove_değiştir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EKLE
            listBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SİL DEĞER
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SİL YER
            int secili = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(secili);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //DEĞER GÜNCELLEME
            int index = listBox1.SelectedIndex;
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Items.Insert(index, textBox3.Text);
        }
        // AŞAĞIDA LİSTBOX ARASI AKTARMA GÖZÜKMEKTEDİR.
        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }
    }
}
