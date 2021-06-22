
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
    public partial class OdemeEkleForm : Form
    {
         Fis fis;
         Data<Taksit> taksitler;

        public OdemeEkleForm()
        {
            this.fis = Sabitler.fis;
            InitializeComponent();
        }

        private async void TaksitEkleForm_Load(object sender, EventArgs e)
        {


            label6.Text = fis.TutarCinsi.ToString();
            if (!fis.TutarCinsi.Equals(MoneyType.Money.TL))
            {
                List<MoneyType> money = await Helper.KurGetir(dateTimePicker1.Value.AddDays(-1));
                if (money != null) { 
                double price = money.FindAll(x => x.moneyType.Equals(fis.TutarCinsi)).Select(x => x.price).FirstOrDefault();
                kur.Text = price.ToString("0.##");
                }
                kur.Enabled = true;

            }
            else
            {
                requiredFieldsChecker1.SetMissingBackColor(kur, null);
                kur.Text = "";
                kur.Enabled = false;

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control missing_field = requiredFieldsChecker1.FirstMissingField();

         
            taksitler = new Data<Taksit>();
            if (fis != null) {
                if (missing_field == null) {
                    
                        double tutar = Helper.convertDouble(this.tutar.Text);
                        if (fis.KalanBakiye >= tutar)
                        {

                        Taksit taksit = new Taksit(); 
                            taksit.Fis = fis;
                            taksit.Tarih = dateTimePicker1.Value;
                            taksit.TutarCinsi = fis.TutarCinsi;
                            taksit.Kur = fis.TutarCinsi.Equals(MoneyType.Money.TL) ? 0 : Helper.convertDouble(kur.Text);
                            taksit.Tutar = tutar;
                            taksit.KurTutari = fis.TutarCinsi.Equals(MoneyType.Money.TL) ? 0 : taksit.Tutar * taksit.Kur;
                            taksitler.AddSingle(taksit);
                        Sabitler.fislerLoad();
                        Sabitler.genelToplam(Sabitler.musteri);
                        Sabitler.taksitlerLoad();
                        this.Close();
                    }
                        else {

                            MessageBox.Show("Borcundan fazla taksit girmeye çalışıyorsunuz");

                        }
                  

                }
            
            else {

                    MessageBox.Show("Verileri Tam Giriniz");

            }
            }
            else {

                MessageBox.Show("Fiş Seçmediniz");

            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void tutar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                kurTutar.Text = (Helper.convertDouble(kur.Text) * Helper.convertDouble(tutar.Text)).ToString();

            }
            catch { }

        }

        private void kur_TextChanged(object sender, EventArgs e)
        {
            try
            {
                kurTutar.Text = (Helper.convertDouble(kur.Text) * Helper.convertDouble(tutar.Text)).ToString();

            }
            catch { }
        }
    }
}
