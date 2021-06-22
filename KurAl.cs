using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Muhasebe
{
    public partial class KurAl : Form
    {
        
        public KurAl()
        {
    
            InitializeComponent();
        }

        private  void KurAl_Load(object sender, EventArgs e)
        {

            if (Helper.generalMoneyList == null)
                load();
            else {
                try { 
            textBox1.Text = Helper.generalMoneyList.Find(x => x.moneyType == MoneyType.Money.USD).price.ToString();
            textBox2.Text = Helper.generalMoneyList.Find(x => x.moneyType == MoneyType.Money.EUR).price.ToString();
            textBox3.Text = Helper.generalMoneyList.Find(x => x.moneyType == MoneyType.Money.GBP).price.ToString();
            }catch { }
        }
    }




        private void button2_Click(object sender, EventArgs e)
        {
            load();
        }


         public async void load() {
               
                Helper.generalMoneyList = await Helper.KurGetir(DateTime.Today.AddDays(-1));
            if (Helper.generalMoneyList!=null) { 
                foreach (MoneyType m in Helper.generalMoneyList)
                {
                    textBox1.Text = m.moneyType == MoneyType.Money.USD ? Math.Round(m.price,2).ToString() : textBox1.Text;
                    textBox2.Text = m.moneyType == MoneyType.Money.EUR ? Math.Round(m.price,2).ToString() : textBox2.Text;
                    textBox3.Text = m.moneyType == MoneyType.Money.GBP ? Math.Round(m.price,2).ToString() : textBox3.Text;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Helper.generalMoneyList == null)
                Helper.generalMoneyList = new List<MoneyType>() { 
                    new MoneyType (){
                    moneyType = MoneyType.Money.USD,
                    price = Helper.convertDouble(textBox1.Text)

                },new MoneyType
               {
                    moneyType = MoneyType.Money.EUR,
                    price = Helper.convertDouble(textBox2.Text)

                }, new MoneyType
               {
                moneyType = MoneyType.Money.GBP,
                    price = Helper.convertDouble(textBox3.Text)

                }
    };
            else {
                Helper.generalMoneyList = new List<MoneyType>();
                Helper.generalMoneyList.Add(new MoneyType { moneyType = MoneyType.Money.USD, price = Math.Round(Helper.convertDouble(textBox1.Text), 2) });
                Helper.generalMoneyList.Add(new MoneyType { moneyType = MoneyType.Money.USD, price = Math.Round(Helper.convertDouble(textBox2.Text), 2) });
                Helper.generalMoneyList.Add(new MoneyType { moneyType = MoneyType.Money.USD, price = Math.Round(Helper.convertDouble(textBox3.Text), 2) });

            }
        }
    }
}
