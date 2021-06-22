using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Muhasebe
{
   static class Sabitler
    {

        public static string db = @"Filename=veritabani\veritabani.db; Connection=shared";
        public delegate void Musterilerload();
        public delegate void Fislerload();
        public delegate void Taksitlerload();
        public delegate void GenelToplam(Musteri musteri);

        public static Musterilerload musteriLoad { get; set; }
        public static Fislerload fislerLoad { get; set; }
        public static Taksitlerload taksitlerLoad { get; set; }
        public static GenelToplam genelToplam { get; set; }


        public static Musteri musteri { get; set; }
        public static Fis fis{ get; set; }
        public static WeifenLuo.WinFormsUI.Docking.DockPanel dockpanel{ get; set; }



    }


}
