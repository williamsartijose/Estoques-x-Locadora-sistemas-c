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
    public partial class frmRelatorios : Form
    {
        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void btnRelClientes_Click(object sender, EventArgs e)
        {
            rptClientes relCli = new rptClientes();
            dtsLocadora dsLoc = new dtsLocadora();
            dtsLocadoraTableAdapters.ClientesTableAdapter taCli = new dtsLocadoraTableAdapters.ClientesTableAdapter();
            taCli.Fill(dsLoc.Clientes);
            relCli.SetDataSource(dsLoc); 
            crystalReportViewer1.ReportSource = relCli; 

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
