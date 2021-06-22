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
    public partial class Rapor : Form
    {
        List<Fis> fis;
        BindingSource bs;
        public Rapor()
        {
            fis = new List<Fis>();
           
    
            InitializeComponent();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            bs = new BindingSource();
            this.reportViewer2.RefreshReport();
        }
    }
}
