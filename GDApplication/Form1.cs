using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDApplication
{
    public partial class AnasayfaForm : Form
    {
        public AnasayfaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminGirisForm ekle = new AdminGirisForm();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboneGirisForm ekle = new AboneGirisForm();
            ekle.ShowDialog();
        }
    }
}
