using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kelimeTahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        string randomKelime;

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            listHarf.Items.Clear();
           
            string[] kelimeler = {"oguzhan","ankara","ece","ebrar","inci","prenses","konya","istanbul" };
            randomKelime=kelimeler[random.Next(0,8)];
            textKontrol.Enabled = true;
            btnKontrol.Enabled = true;
            textKontrol.Text = "";


        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            string tahminKelime = textKontrol.Text;
            if (tahminKelime == randomKelime)
            {
                MessageBox.Show("Tebrikler kazandınız");
            }
            else
            {
                char[] harfler = tahminKelime.ToCharArray();
                string eslesenHarfler = "";
                foreach (char harf in harfler)
                {
                    if (randomKelime.Contains(harf))
                    {
                        eslesenHarfler += $"{harf},";
                    }
                }
                if(eslesenHarfler != "")
                {
                    eslesenHarfler = eslesenHarfler.TrimEnd(',');
                    listHarf.Items.Add(eslesenHarfler);
                }
            }
        }
    }
}
