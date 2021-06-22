using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Muhasebe
{
    public partial class MusterilerForm : DockContent
    {


        Musteri musteri;
        private Data<Musteri> dt;
      
        public MusterilerForm()
        {
            InitializeComponent();
        }

        private void MusterilerForm_Load(object sender, EventArgs e)
        {
            Sabitler.musteriLoad = load;
            load();
         

        }


    public void load()
{
           dt = new Data<Musteri>();
            treeView1.Nodes.Clear();
           foreach(Musteri m in dt.GetAll()) {
                TreeNode customerNode = new TreeNode(string.IsNullOrEmpty(m.sirket)?m.Adi+" "+m.Soyadi: m.sirket);
                customerNode.Tag = m;
                treeView1.Nodes.Add(customerNode);
             
           
            }
}

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           musteri=(Musteri) e.Node.Tag;
            Sabitler.musteri = musteri;
          
                if (musteri != null)
                {
                    Sabitler.fislerLoad();
                }
                else
                {
                    MessageBox.Show("Müşteri Seçmediniz");
                }
           
         

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (Helper.generalMoneyList != null) { 
            
                if (musteri != null)
                {
                    Sabitler.fislerLoad();
                    
                }
                else
                {
                    MessageBox.Show("Müşteri Seçmediniz");
                }
            }
            else {

                MessageBox.Show("Sistem kur bilgisini almaya çalışıyor veya alamadı\nDevam edebilmek için kur bilgisini giriniz");
             

            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Müşteri Silme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Data<Fis> fis=new Data<Fis>();
                Data<Taksit> taksit=new Data<Taksit>();

                if (musteri!=null)
                {
                    foreach (Fis _fis in fis.GetAll().FindAll(x => x.Musteri.ID.Equals(musteri.ID))) { 
                        foreach (Taksit _taksit in taksit.GetAll().FindAll(x => x.Fis.ID.Equals(_fis.ID))) {
                            taksit.DeleteSingle(_taksit.ID);
                        }
                        fis.DeleteSingle(_fis.ID);
                    }
                    dt.DeleteSingle(musteri.ID);
                    treeView1.Nodes.Remove(treeView1.SelectedNode);
                    MessageBox.Show("Başarıyla Silindi");

                }
                else {

                    MessageBox.Show("Hata Oluştu");
                }
            }
        

           
           
        }

      

        private void fişEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (musteri != null)
            {
              
                FisEkleGuncelle fs = new FisEkleGuncelle(musteri, 0);
                fs.Show();
            }
            else {
                MessageBox.Show("Müşteri Seçmediniz");
            }

        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriGuncelle mg = new MusteriGuncelle(musteri);
            mg.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_Click(object sender, EventArgs e)
        {

        }
    }
}
