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
    public partial class FisEkleGuncelle : Form
    {
        Data<Fis> fisler;
        Musteri musteri;
        Fis fis;
        int islem;
    
        public FisEkleGuncelle(Fis fis,int islem)
        {
            this.fis = fis;
            this.islem =islem;
            InitializeComponent();
        }

        public FisEkleGuncelle(Musteri musteri,int islem)
        {
            this.musteri = musteri;
            this.islem = islem;
            InitializeComponent();
        }

     
      
        private void FisEkle_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(MoneyType.Money));
            comboBox2.DataSource = Enum.GetValues(typeof(Fis.FaturaTuru));
            comboBox3.DataSource = Enum.GetValues(typeof(Fis.HavaleEFTTuru));

            button1.Visible = islem == 0 ? true : false;
            button2.Visible = islem == 1 ? true : false;



            if (islem>0 && fis != null) {
                dateTimePicker1.Value = fis.Tarih;
                comboBox1.SelectedItem = fis.TutarCinsi;
                textBox1.Text = fis.Tutar.ToString();
                textBox2.Text = fis.Kur.ToString();
                textBox4.Text=fis.KurTutari.ToString();
                richTextBox1.Text = fis.Aciklama;
                if (fis.Fistipi.Equals(Fis.FisTipi.Alacak))
                {
                    radioButton1.Checked = true; radioButton2.Checked = false;
                }
                else { radioButton1.Checked = false; radioButton2.Checked = true; }
               

                switch (fis.Fisturu)
                {
                    case Fis.FisTuru.Fatura:
                        comboBox2.SelectedItem = fis.Faturaturu;
                        textBox12.Text = fis.FaturaNo;
                        tabControl1.SelectTab(0);
                        tabControl1.TabPages.Remove(tabPage2);
                        tabControl1.TabPages.Remove(tabPage3);
                        tabControl1.TabPages.Remove(tabPage4);
                        tabControl1.TabPages.Remove(tabPage5);

                        break;
                    case Fis.FisTuru.HavaleEFT:
                        textBox5.Text = fis.GelenAdiSoyadi;
                        textBox7.Text = fis.GelenIBAN;
                        textBox6.Text = fis.HavaleEFTNo;
                        comboBox3.SelectedItem = fis.HavaleEFTturu;
                        tabControl1.SelectTab(1);
                        tabControl1.TabPages.Remove(tabPage1);
                        tabControl1.TabPages.Remove(tabPage3);
                        tabControl1.TabPages.Remove(tabPage4);
                        tabControl1.TabPages.Remove(tabPage5);

                        break;
                    case Fis.FisTuru.Nakit:
                        textBox8.Text = fis.NakitNo;
                        tabControl1.SelectTab(2);
                        tabControl1.TabPages.Remove(tabPage1);
                        tabControl1.TabPages.Remove(tabPage2);
                        tabControl1.TabPages.Remove(tabPage4);
                        tabControl1.TabPages.Remove(tabPage5);
                        break;
                    case Fis.FisTuru.CekSenet:
                        dateTimePicker6.Value = fis.CekSenetVadeTarihi > DateTime.MaxValue || fis.CekSenetVadeTarihi < DateTime.MinValue ? fis.CekSenetVadeTarihi : dateTimePicker6.Value;
                        tabControl1.SelectTab(3);
                        tabControl1.TabPages.Remove(tabPage1);
                        tabControl1.TabPages.Remove(tabPage2);
                        tabControl1.TabPages.Remove(tabPage3);
                        tabControl1.TabPages.Remove(tabPage5);
                        break;
                    case Fis.FisTuru.Kredi:
                        textBox11.Text = fis.IsNo;
                        tabControl1.SelectTab(4);
                        tabControl1.TabPages.Remove(tabPage1);
                        tabControl1.TabPages.Remove(tabPage2);
                        tabControl1.TabPages.Remove(tabPage3);
                        tabControl1.TabPages.Remove(tabPage4);
                        break;
                }
           
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fisler = new Data<Fis>();
            Fis fis = new Fis();
            Control missing_field = requiredFieldsChecker1.FirstMissingField();
            if (missing_field == null)
            {
                if (musteri != null)
                {
                    if (radioButton1.Checked) fis.Fistipi = Fis.FisTipi.Alacak;
                    else if (radioButton2.Checked) fis.Fistipi = Fis.FisTipi.Borc;

                    if (radioButton10.Checked) fis.CikisTur = Fis.CikisTuru.Gelen;
                    else if (radioButton11.Checked) fis.CikisTur = Fis.CikisTuru.Giden;

                    fis.IslemTarihi = DateTime.Today;
                    fis.Musteri = musteri;
                    fis.Tarih = dateTimePicker1.Value.Date;
                    fis.Aciklama = richTextBox1.Text;
                    fis.TutarCinsi = (MoneyType.Money)comboBox1.SelectedValue;
                    fis.Tutar = Helper.convertDouble(textBox1.Text);

                    if (fis.TutarCinsi.Equals(MoneyType.Money.TL))
                    {
                        fis.Kur = 0d;
                        fis.KurTutari = 0d;

                    }
                    else
                    {
                        fis.Kur = Math.Round(Helper.convertDouble(textBox2.Text), 4);
                        fis.KurTutari = Math.Round(fis.Tutar * fis.Kur, 4);
                        requiredFieldsChecker1.SetMissingBackColor(textBox2, null);
                    }
                    switch (tabControl1.SelectedIndex)
                    {
                        case 0:
                            fis.Fisturu = Fis.FisTuru.Fatura;
                            fis.FaturaNo = textBox12.Text;
                            fis.Faturaturu = (Fis.FaturaTuru)comboBox2.SelectedItem;
                            break;
                        case 1:
                            fis.Fisturu = Fis.FisTuru.HavaleEFT;
                            fis.GelenIBAN = textBox7.Text;
                            fis.GelenAdiSoyadi = textBox5.Text;
                            fis.HavaleEFTNo = textBox6.Text;
                            fis.HavaleEFTturu = (Fis.HavaleEFTTuru)comboBox3.SelectedItem;
                            break;
                        case 2:
                            fis.Fisturu = Fis.FisTuru.Nakit;
                            fis.NakitNo = textBox8.Text;
                            break;
                        case 3:
                            fis.Fisturu = Fis.FisTuru.CekSenet;
                            fis.CekSenetNo = textBox10.Text;
                            fis.CekSenetVadeTarihi = dateTimePicker6.Value;
                            fis.GelenAdiSoyadi = textBox9.Text;
                            break;
                        case 4:
                            fis.Fisturu = Fis.FisTuru.Kredi;
                            fis.IsNo = textBox11.Text;
                            break;
                    }

                    if (fisler.AddSingle(fis))
                    {

                        Sabitler.fislerLoad();
                        Sabitler.genelToplam(Sabitler.musteri);
                    }
                    else
                    {
                        MessageBox.Show("Hata Oluştu");
                    }

                }
                else { MessageBox.Show("Müşteri Seçiniz"); }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fisler = new Data<Fis>();
            Control missing_field = requiredFieldsChecker1.FirstMissingField();
            if (missing_field == null)
            {
                if (fis.Tutar - fis.KalanBakiye <= Helper.convertDouble(textBox1.Text))
                {
                    MessageBox.Show((fis.Tutar - fis.KalanBakiye).ToString());
                    if (radioButton1.Checked) fis.Fistipi = Fis.FisTipi.Alacak;
                    else if (radioButton2.Checked) fis.Fistipi = Fis.FisTipi.Borc;

                    if (radioButton10.Checked) fis.CikisTur = Fis.CikisTuru.Gelen;
                    else if (radioButton11.Checked) fis.CikisTur = Fis.CikisTuru.Giden;

                    fis.Tarih = dateTimePicker1.Value;
                    fis.Aciklama = richTextBox1.Text;
                    fis.TutarCinsi = (MoneyType.Money)comboBox1.SelectedValue;
                    fis.Tutar = Helper.convertDouble(textBox1.Text);
                    if (fis.TutarCinsi != MoneyType.Money.TL)
                    {
                        fis.Kur = Helper.convertDouble(textBox2.Text);
                        fis.KurTutari = fis.Tutar * fis.Kur;
                    }
                    switch (fis.Fisturu)
                    {
                        case Fis.FisTuru.Fatura:
                            fis.FaturaNo = textBox12.Text;
                            fis.Faturaturu = (Fis.FaturaTuru)comboBox2.SelectedItem;
                            break;
                        case Fis.FisTuru.HavaleEFT:

                            fis.GelenIBAN = textBox7.Text;
                            fis.GelenAdiSoyadi = textBox5.Text;
                            fis.HavaleEFTNo = textBox6.Text;
                            fis.HavaleEFTturu = (Fis.HavaleEFTTuru)comboBox2.SelectedItem;
                            break;
                        case Fis.FisTuru.Nakit:
                            fis.NakitNo = textBox8.Text;
                            break;
                        case Fis.FisTuru.CekSenet:
                            fis.CekSenetNo = textBox10.Text;
                            fis.CekSenetVadeTarihi = dateTimePicker6.Value;
                            fis.GelenAdiSoyadi = textBox9.Text;
                            break;
                        case Fis.FisTuru.Kredi:
                            fis.IsNo = textBox11.Text;
                            break;
                    }

                    if (fisler.UpdateSingle(fis))
                    {


                        Sabitler.fislerLoad();
                    }
                    else
                    {
                        MessageBox.Show("Hata Oluştu");
                    }
                }
                else {
                    MessageBox.Show("Ödenen taksitten az tutar girilemez");


                }


            }



        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!((MoneyType.Money)comboBox1.SelectedItem).Equals(MoneyType.Money.TL) && islem < 2)
            {
                List<MoneyType> money = await Helper.KurGetir(dateTimePicker1.Value.AddDays(-1));
                double price = money.FindAll(x => x.moneyType.Equals((MoneyType.Money)comboBox1.SelectedValue)).Select(x => x.price).FirstOrDefault();
                textBox2.Enabled = true;
                textBox2.Text = price.ToString("0.####");
                textBox4.Text = (Helper.convertDouble(textBox1.Text) * price).ToString();
                requiredFieldsChecker1.SetMissingBackColor(textBox2, null);
            }
            else {

                textBox2.Text="";
                textBox2.Enabled = false;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox4.Text = (Helper.convertDouble(textBox1.Text) * Helper.convertDouble(textBox2.Text)).ToString();

            }
            else
            {
                textBox2.Text = "";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)  radioButton2.Checked = false; else radioButton2.Checked = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true) radioButton1.Checked = false; else radioButton1.Checked = true;
        }

        private async void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!((MoneyType.Money)comboBox1.SelectedItem).Equals(MoneyType.Money.TL) && islem < 2)
            {
                List<MoneyType> money = await Helper.KurGetir(dateTimePicker1.Value.AddDays(-1));
                double price = money.FindAll(x => x.moneyType.Equals((MoneyType.Money)comboBox1.SelectedValue)).Select(x => x.price).FirstOrDefault();
                textBox2.Enabled = true;
                textBox2.Text = price.ToString("0.##");

            }
            else
            {
                textBox2.Text = "";
                textBox2.Enabled = false;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox4.Text = (Helper.convertDouble(textBox1.Text) * Helper.convertDouble(textBox2.Text == "" ? "1" : textBox2.Text)).ToString();

            }
            else
            {
                textBox2.Text = "";
            }
        }

       

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox4.Text = (Helper.convertDouble(textBox1.Text) * Helper.convertDouble(textBox2.Text)).ToString();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox4.Text = (Helper.convertDouble(textBox1.Text) * Helper.convertDouble(textBox2.Text)).ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true) radioButton11.Checked = false; else radioButton11.Checked = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true) radioButton11.Checked = false; else radioButton11.Checked = true;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
