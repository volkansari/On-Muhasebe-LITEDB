
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Muhasebe
{
    public static class Helper
    {
        private static List<MoneyType> moneyList;
        public static List<MoneyType> generalMoneyList;



        public static double convertDouble(string str) {
            double a = 0d;
            double.TryParse(str, out a);
            return a;

        }

        public static async Task<List<MoneyType>> KurGetir(DateTime date)
        {
            string url = "";

            if (date == null) return null;

        
            if (date.DayOfWeek.Equals(DayOfWeek.Saturday))
             {
                date = date.AddDays(-1);
   
             }
             else if (date.DayOfWeek.Equals(DayOfWeek.Sunday))
             {
                date = date.AddDays(-2);

            }
            else{
                date = date.AddDays(-1);

            }

            if (date >= DateTime.Today)
                url = "http://www.tcmb.gov.tr/kurlar/today.xml";
            else
            {
                url = "http://www.tcmb.gov.tr/kurlar/" + date.ToString("yyyyMM") + "/" + date.ToString("ddMMyyyy") + ".xml";
            }


            try {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.DtdProcessing = DtdProcessing.Ignore;
                settings.ValidationType = ValidationType.DTD;
                settings.Async = true;
                XmlReader rdr = XmlReader.Create(url, settings);
                
                bool succes = await rdr.ReadAsync();

                if (succes) {
                    moneyList = new List<MoneyType>();
                    XmlDocument myxml = new XmlDocument();
                    myxml.Load(rdr);
                    XmlNodeList kod = myxml.SelectNodes("/ Tarih_Date / Currency / @Kod");
                    XmlNodeList doviz_alis = myxml.SelectNodes("/ Tarih_Date / Currency / ForexBuying");
                    for (int i = 0; i < kod.Count; i++)
                    {
                        foreach (MoneyType.Money m in Enum.GetValues(typeof(MoneyType.Money)))

                            if (kod.Item(i).InnerText.ToString() == m.ToString()) moneyList.Add(
                                             new MoneyType
                                             {
                                                 moneyType = m,
                                                 price = Math.Round(convertDouble(doviz_alis.Item(i).InnerText.Replace(".", ",")), 4)

                                             });

                    }

                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }


            return moneyList;
        }




        public static DataTable ToDataTable<T>(this IEnumerable<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name,
                    Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }


    }


    }



