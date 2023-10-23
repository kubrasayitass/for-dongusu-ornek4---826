using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_dongusu_ornek4___826
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            int baslangic, bitiş;
            baslangic = Convert.ToInt32(txtBaslangic.Text);
            bitiş = Convert.ToInt32(txtBitis.Text);
            for(int i = baslangic;1 <= bitiş; i++)
            {
                lbSayilar.Items.Add(i);
            }
        }
    }
}
