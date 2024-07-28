using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bahşiş_Dağıtma_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kullaniciadi, sifre;
        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciadi = "admin";
            sifre = "0101";
            if(textBox1.Text == "")
            {
                MessageBox.Show("Lütfen bir kullanıcı adı giriniz!");
            }
            else if(textBox2.Text == "")
            {
                MessageBox.Show("Lütfen bir şifre giriniz!!!");
            }
            if (textBox1.Text == "admin" && textBox2.Text == "0101")
            {
                // Kullanıcı adı ve şifre doğruysa yapılacak işlemler
                MessageBox.Show("Giriş başarılı!");
                Form2 form2 = new Form2();
                form2.Show();
                Form1 form1 = new Form1();
                this.Hide();
            }
            else
            {
                // Kullanıcı adı ve/veya şifre yanlışsa hata mesajı gösterilir
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış! Tekrar Deneyiniz!");
            }

        }
    }
}
