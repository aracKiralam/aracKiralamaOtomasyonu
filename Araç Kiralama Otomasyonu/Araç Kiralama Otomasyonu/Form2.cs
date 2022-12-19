using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Kiralama_Otomasyonu
{
    public partial class araclar : Form
    {
        public araclar()
        {
            InitializeComponent();
        }

        private void araclar_Load(object sender, EventArgs e)
        {

        }

        private void araclar_FormClosing(object sender, FormClosingEventArgs e)
        {
            main main = new main();
            main.Show();
        }
    }
}
