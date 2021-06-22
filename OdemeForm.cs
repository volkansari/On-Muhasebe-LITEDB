using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Muhasebe
{
    public partial class OdemeForm : DockContent
    {
        Fis fis = new Fis();
        Taksit taksit=new Taksit();
        Data<Taksit> taksitler;
        Data<Fis> fisler;
        public OdemeForm()
        {
            
          
            Sabitler.taksitlerLoad = load;
            InitializeComponent();
        }

        private void TaksitlerForm_Load(object sender, EventArgs e)
        {
      
            

        }


        public void load()
        {
            fis = Sabitler.fis;
            taksitler = new Data<Taksit>();
            if (fis != null) {
            treeView1.Nodes.Clear();
            foreach (Taksit m in taksitler.GetAll().Where(x=>x.Fis.ID==fis.ID))
            {
                TreeNode taksitNode = new TreeNode(m.Tarih.ToShortDateString() +" Kur:"+m.Kur +" Tutar:" + m.Tutar+" "+m.TutarCinsi+" Kur Tutarı:"+ m.KurTutari);
                taksitNode.Tag = m;
                treeView1.Nodes.Add(taksitNode);


            }

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Sabitler.fis != null)
            {
                if (Sabitler.fis.Fistipi == Fis.FisTipi.Borc)
                {
                    OdemeEkleForm tef = new OdemeEkleForm();
                    tef.Show();
                }

                else
                {

                    MessageBox.Show("Sadece Borç Fişine Taksit Girilebilir");

                }
            }
            else { MessageBox.Show("Taksit Girilecek Fiş Seçiniz"); }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            fisler = new Data<Fis>();
            DialogResult dialogResult = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Taksit Silme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                fis.KalanBakiye = fis.KalanBakiye + taksit.Tutar;
                fis.KurTutari = fis.KurTutari + taksit.Tutar;
                if (fisler.UpdateSingle(fis))
                if (taksit!=null && taksitler.DeleteSingle(taksit.ID))
                {
                    treeView1.Nodes.Remove(treeView1.SelectedNode);
                    MessageBox.Show("Başarıyla Silindi");
                    Sabitler.fislerLoad();

                }
                else
                {

                    MessageBox.Show("Taksit Seçiniz");
                }
            }

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            taksit = (Taksit)e.Node.Tag;
         
            
        }

        private void treeView1_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
           
        }
    }
}