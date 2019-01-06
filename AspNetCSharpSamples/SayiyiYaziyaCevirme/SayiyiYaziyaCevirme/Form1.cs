using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SayiyiYaziyaCevirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void BasamakKontrol()
        {
            if ((textBox1.Text.Length > 7))
            {
                MessageBox.Show("Sayı basamağı 7'den Büyük.HESAPLAMAZ!!!");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SayiOkuma sayi = new SayiOkuma();


            richTextBox1.Text = sayi.oku(textBox1.Text);

         
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


            e.Handled = !((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8);
        }

     

    
    }

    }

