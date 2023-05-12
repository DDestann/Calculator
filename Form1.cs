using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal Sonuc=0, Sayi2=0, Sayi1=0 , Sayac=0;
        string deger;


        

        private void btnSayi(object sender, EventArgs e)
        {
            Button btnsayi = (Button)sender;

            if (txtSayi.Text == "0") txtSayi.Text = "";

            if (Sayac==0)
            {
                txtSayi.Clear();
                Sayac++; 
            }
            txtSayi.Text += btnsayi.Text;
            
            


        }
       
       
       


         void islem()
        {
            if (deger=="+")
            {
                Sayi2 = Convert.ToDecimal(txtSayi.Text);
                Sonuc = Sayi1 + Sayi2;
                txtSayi.Text = Sonuc.ToString();
                
            }
             if (deger == "-")
            {
                Sayi2 = Convert.ToDecimal(txtSayi.Text);
                Sonuc = Sayi1 - Sayi2;
                txtSayi.Text = Sonuc.ToString();

            }
             if (deger == "*")
            {
                Sayi2 = Convert.ToDecimal(txtSayi.Text);
                Sonuc = Sayi1 * Sayi2;
                txtSayi.Text = Sonuc.ToString();

            }
             if (deger == "/")
            {
                if (txtSayi.Text!="0")
                {
                     Sayi2 = Convert.ToDecimal(txtSayi.Text);
                Sonuc = Sayi1 / Sayi2;
                txtSayi.Text = Sonuc.ToString();
                }

            }
            if (deger == "%")
            {
                Sayi2 = Convert.ToDecimal(txtSayi.Text);
                Sonuc = (Sayi1 * Sayi2)/100;
                txtSayi.Text = Sonuc.ToString();

            }

            
        }



       

       

        private void button17_Click(object sender, EventArgs e)
        {
            txtSayi.Text = "0";
            islem();
            deger="";
            Sonuc = 0;
            Sayi2 = 0;
            Sayi1 = 0;
            Sayac = 0;
          
        }


        private void button18_Click(object sender, EventArgs e)
        {
                txtSayi.Text = txtSayi.Text.Substring(0, txtSayi.Text.Length - 1);
                if (txtSayi.Text == "")
                {
                    txtSayi.Text = "0";
                }
            
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            islem();
            Sonuc = 0;
            Sayi2 = 0;
            Sayi1 = 0;
            Sayac = 0;
        }

        private void btnArti_Click(object sender, EventArgs e)
        {
            islem();
            deger = "+";
            Sayi1 = Convert.ToDecimal(txtSayi.Text);
            Sayac = 0;
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            islem();
            deger = "-";
            Sayi1 = Convert.ToDecimal(txtSayi.Text);
            Sayac = 0;
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            islem();
            deger = "/";
            Sayi1 = Convert.ToDecimal(txtSayi.Text);
            Sayac = 0;
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            islem();
            deger = "*";
            Sayi1 = Convert.ToDecimal(txtSayi.Text);
            Sayac = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            islem();
            deger = "%";
            Sayi1 = Convert.ToDecimal(txtSayi.Text);
            Sayac = 0;
        }

       
    }
}
