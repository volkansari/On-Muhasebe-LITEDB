using LiteDB;
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
    public partial class MusteriEkle : Form
    {
        Data<Musteri> dt = new Data<Musteri>();
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Control missing_field = requiredFieldsChecker1.FirstMissingField();

            if (missing_field == null)
            {

                if (dt.AddSingle(new Musteri
                {
                    sirket = textBox1.Text,
                    TCKN = textBox10.Text,
                    Adi = textBox2.Text,
                    Soyadi = textBox3.Text,
                    VergiNo = textBox4.Text,
                    vergiDairesi = textBox5.Text,
                    Adres = textBox6.Text,
                    Tel = textBox7.Text,
                    Il = textBox8.Text,
                    Ilce = textBox9.Text

                }))
                {

                    MessageBox.Show("Başarıyla Eklendi");

                }
                else
                {

                    MessageBox.Show("Hata Oluştu");
                }
                Sabitler.musteriLoad();

            }
        }
        }

}
  