using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Muhasebe
{
 
    public class Fis 
    {

        public enum FisTuru
        {
            Fatura=0,
            Nakit=1,
            CekSenet=2,
            HavaleEFT=3,
            Kredi=4

        }

        public enum FisTipi
        {
            Borc = 0,
            Alacak = 1,
          
          

        }

        public enum FaturaTuru
        {
            eFatura = 0,
            eArsiv_Fatura = 1,
            Kagit_Fatura=2


        }
        public enum HavaleEFTTuru
        {
            Havale = 0,
            EFT = 1,
           


        }
        public enum CikisTuru
        {
            Gelen = 0,
            Giden = 1,



        }



        [DisplayName("Fiş No")]
        [Browsable(false)]
        public LiteDB.ObjectId ID { get; set; }
        [DisplayName("Fiş Türü")]
        public FisTuru Fisturu { get; set; }
        [DisplayName("Fiş Tipi")]
        public FisTipi Fistipi { get; set; }
        [DisplayName("Çıkış Türü")]
        public CikisTuru CikisTur { get; set; }
        public DateTime IslemTarihi { get; set; }
        [DisplayName("Fiş Tarihi")]
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public double Tutar{ get; set; }
        [DisplayName("Tutar Cinsi")]
        public MoneyType.Money TutarCinsi{ get; set; }
        [DisplayName("Ödeme Kalan Bakiye")]
        public double KalanBakiye { get; set; }
        public double Kur { get; set; }
        [DisplayName("Kur Tutarı")]
        public double KurTutari { get; set; }
        [DisplayName("Kur Farkı")]
        public double KurFarki{ get; set; }
        #region Fatura
        [Browsable(false)]
        public string FaturaNo { get; set; }
        [Browsable(false)]
        public FaturaTuru Faturaturu { get; set; }
        #endregion
        #region Çek Senet
        [Browsable(false)]
        [DisplayName("Çek/Senet No")]
        public string CekSenetNo{ get; set; }
        [Browsable(false)]
        [DisplayName("Çek/Senet Vade Tarihi")]
        public DateTime CekSenetVadeTarihi { get; set; }
        #endregion
        #region HavaleEFT
        [Browsable(false)]
        [DisplayName("Gelen IBAN")]
        public string GelenIBAN { get; set; }
        [Browsable(false)]
        [DisplayName("Gelen IBAN Adı ve Soyadı")]
        public string GelenAdiSoyadi { get; set; }
        [Browsable(false)]
        [DisplayName("Havale/EFT No")]
        public string HavaleEFTNo { get; set; }
        [Browsable(false)]
        [DisplayName("Havale İşlem Türü")]
        public HavaleEFTTuru HavaleEFTturu { get; set; }
        #endregion
        #region Nakit
        [Browsable(false)]
        [DisplayName("Nakit No")]
        public string NakitNo { get; set; }

        #endregion
        #region Kredi
        [Browsable(false)]
        [DisplayName("İş No")]
        public string IsNo { get; set; }

        #endregion
        [Browsable(false)]
        public virtual Musteri Musteri { get; set; }

       
    }
}
