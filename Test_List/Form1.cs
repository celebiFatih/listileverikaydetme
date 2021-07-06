using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Arabalar> araba = new List<Arabalar>();
            araba.Add(new Arabalar()
            {
                MARKASI = "Mitsubishi",
                MODELI = "Lancer",
                MODELYILI = 2011
            });

            foreach (var item in araba)
            {
                listBox1.Items.Add(item.MARKASI + " " + item.MODELI + " " + item.MODELYILI);
            }
        }
        List<int> sayilar = new List<int>();
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            for(int i = 0; i < 10; i++)
            {
                sayilar.Add(rnd.Next(50));                
            }
            foreach (var item in sayilar)
            {
                listBox2.Items.Add(item);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Kisiler> kisi = new List<Kisiler>();
            kisi.Add(new Kisiler()
            {
                ADI = "Ali",
                SOYADI = "Çınar",
                MESLEKI = "Öğretmen"
            });
            foreach (Kisiler k in kisi)
            {
                listBox3.Items.Add(k.ADI + " " + k.SOYADI + " " + k.MESLEKI);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sayilar.Contains(int.Parse(textBox1.Text))) {
                MessageBox.Show("Sayı Mevcut");
            }           
            else
            {
                MessageBox.Show("Sayı Mevcut Değil");                
            }
            textBox1.Clear();
        }
    }
}
