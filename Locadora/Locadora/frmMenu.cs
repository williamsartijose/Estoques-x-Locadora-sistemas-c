using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmCli = new frmClientes();
            frmCli.MdiParent = this; 
            frmCli.Show(); 
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLocacao frmLoc = new frmLocacao();
            frmLoc.MdiParent = this;
            frmLoc.Show(); 
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRelatorios frmRel = new frmRelatorios();
            frmRel.MdiParent = this;
            frmRel.Show(); 
        }
    }
}
