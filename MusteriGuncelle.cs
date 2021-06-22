using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebe
{
    public partial class MusteriGuncelle : Form
    {
        Data<Musteri> dt;
        Musteri musteri;
        public MusteriGuncelle(Musteri musteri)
        {
            this.musteri = musteri;
            InitializeComponent();
        }

        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {

            textBox1.Text = musteri.Adi;
            textBox2.Text = musteri.Soyadi;
            textBox3.Text = musteri.sirket;
            textBox4.Text = musteri.Tel;
            textBox5.Text = musteri.VergiNo;
            textBox6.Text = musteri.vergiDairesi;
            textBox7.Text = musteri.Il;
            textBox8.Text = musteri.Ilce;
            textBox9.Text = musteri.Adres;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = new Data<Musteri>();
           musteri.Adi = textBox1.Text;
           musteri.Soyadi = textBox2.Text;
           musteri.sirket = textBox3.Text;
            musteri.Tel = textBox4.Text;
            musteri.VergiNo = textBox5.Text;
            musteri.vergiDairesi = textBox6.Text;
            musteri.Il = textBox7.Text;
            musteri.Ilce = textBox8.Text;
            musteri.Adres= textBox9.Text;

            if (dt.UpdateSingle(musteri))
            {
                MessageBox.Show("Başarıyla Güncellendi");
            }
            else {
                MessageBox.Show("Hata Oluştu");
            }

        }
    }
}
