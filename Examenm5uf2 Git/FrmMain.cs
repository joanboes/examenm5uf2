using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examenm5uf2_Git
{
    public partial class Form1 : Form
    {
        FrmMenjar fMenjar;
        FrmViatge frmViatge;
        FrmAnimal fAnimal;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fMenjar = new FrmMenjar();
            fMenjar.MdiParent = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmViatge = new FrmViatge();
            frmViatge.MdiParent = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fAnimal = new FrmAnimal();
            fAnimal.MdiParent = this;
        }
    }
}
