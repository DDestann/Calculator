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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        decimal Sonuc=0, Sayi1=0, Sayi2=0, Sayac=0;
        string Deger;
       
        private void button17_Click(object sender, EventArgs e)//c
        {
            Hesap();
            txtSayi.Text = "0";
            Sonuc = 0;
            Sayi1 = 0;
            Sayi2 = 0;
            Sayac = 0;
        }

        private void button18_Click(object sender, EventArgs e)//sil
        {
            txtSayi.Text = txtSayi.Text.Substring(0,txtSayi.Text.Length -1);
            if (txtSayi.Text=="")
            {
                txtSayi.Text = "0";
            }
        }

        private void btnSayi(object sender, EventArgs e)///Sayı
        {
            Button btn = (Button)sender;
            if (Sayac==0)
            {
                txtSayi.Clear();
                Sayac++;
            }
            txtSayi.Text += btn.Text;
        }


        public void Hesap()
        {
            string YeniDeger = Deger;

            

            if (Deger=="+")
            {
                Sayi2 = Convert.ToDecimal(txtSayi.Text);
                Sonuc = Sayi1 + Sayi2;
                txtSayi.Text = Sonuc.ToString();
                
            }
            else if(Deger=="-")
            {
                Sayi2 = Convert.ToDecimal(txtSayi.Text);
                Sonuc = Sayi1 - Sayi2;
                txtSayi.Text = Sonuc.ToString();
            }
            else if (Deger == "*")
            {
                Sayi2 = Convert.ToDecimal(txtSayi.Text);
                Sonuc = Sayi1 * Sayi2;
                txtSayi.Text = Sonuc.ToString();
            }
            else if (Deger == "/")
            {
                Sayi2 = Convert.ToDecimal(txtSayi.Text);
                Sonuc = Sayi1 / Sayi2;
                txtSayi.Text = Sonuc.ToString();
            }
            else if (Deger == "%")
            {
                Sayi2 = Convert.ToDecimal(txtSayi.Text);
                Sonuc = (Sayi1 * Sayi2) / 100;
                txtSayi.Text = Sonuc.ToString();
            }

            if (Sayi1!=0 && Sayi2!=0)
            {
               // lblislem.Text = lblislem.Text + " " + Sayi1.ToString() + " " + YeniDeger + " " + Sayi2.ToString();
                //lblislem.Text = lblislem.Text + " " + txtSayi.Text + " " + YeniDeger + " " + Sayi2.ToString();
            }
           
            
        }

        private void btnislem(object sender, EventArgs e)//= dahil
        {
            Button islem = (Button)sender;
            Hesap();

            string YeniDeger = islem.Text;

            if (islem.Text ==(Deger="+") )
            {
                Sayi1 =Convert.ToDecimal(txtSayi.Text);
                Sayac = 0;
            }
            else if (islem.Text == (Deger = "-"))
            {
                Sayi1 = Convert.ToDecimal(txtSayi.Text);
                Sayac = 0;
            }
            else if (islem.Text == (Deger = "*"))
            {
                Sayi1 = Convert.ToDecimal(txtSayi.Text);
                Sayac = 0;
            }
            else if (islem.Text == (Deger = "/"))
            {
                Sayi1 = Convert.ToDecimal(txtSayi.Text);
                Sayac = 0;
            }
            else if (islem.Text == (Deger = "%"))
            {
                Sayi1 = Convert.ToDecimal(txtSayi.Text);
                Sayac = 0;
            }

           // lblislem.Text = lblislem.Text + " " + Sayi1.ToString() + " " + YeniDeger + " " + Sayi2.ToString();

           // lblislem.Text = lblislem.Text + " " + Sayi2.ToString() + " " + YeniDeger;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Hesap();
            Deger = "";
            Sonuc = 0;
            Sayi1 = 0;
            Sayi2 = 0;
            Sayac = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!txtSayi.Text.Contains(",")) { txtSayi.Text += ","; }
            
            
        }

       

        
    }
}
