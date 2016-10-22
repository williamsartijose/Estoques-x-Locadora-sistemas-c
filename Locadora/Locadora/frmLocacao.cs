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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void frmLocacao_Load(object sender, EventArgs e)
        {
            // carregar dados combo cliente
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = bllCliente.Select();

            //carregar dados combo filme
            Camadas.BLL.Filme bllFilme = new Camadas.BLL.Filme();
            cmbFilme.DisplayMember = "titulo";
            cmbFilme.ValueMember = "id";
            cmbFilme.DataSource = bllFilme.Select();

            //preencher grid locação
            Camadas.BLL.Locacao bllLocacao = new Camadas.BLL.Locacao();
            dtgLocacao.DataSource = bllLocacao.Select();
            lblIdLoc.Text = dtgLocacao.Rows[0].Cells["id"].Value.ToString(); 
            txtData.Text = dtgLocacao.Rows[0].Cells["data"].Value.ToString();
            txtIdCliente.Text = dtgLocacao.Rows[0].Cells["cliente_id"].Value.ToString();
            cmbCliente.SelectedValue = Convert.ToInt32(txtIdCliente.Text);

            carrega_Itens_Locacao(); 
        }

        private void carrega_Itens_Locacao()
        {
            Camadas.BLL.Itens_Locacao bllItLocacao = new Camadas.BLL.Itens_Locacao();
            int idLocacao = Convert.ToInt32(lblIdLoc.Text);
            dtgItensLocacao.DataSource = bllItLocacao.SelectByLocacao (idLocacao);

            //preencher campos itens locação
            if (dtgItensLocacao.RowCount > 0)
            {
                lblIdItLoc.Text = dtgItensLocacao.Rows[0].Cells["id"].Value.ToString();
                txtFilme.Text = dtgItensLocacao.Rows[0].Cells["filme_id"].Value.ToString();
                lblStatus.Text = dtgItensLocacao.Rows[0].Cells["status"].Value.ToString();
                cmbFilme.SelectedValue = Convert.ToInt32(txtFilme.Text);
            }
            else
            {
                lblIdItLoc.Text = "";
                txtFilme.Text = "";
                lblStatus.Text = "";
                cmbFilme.SelectedValue = 1;


            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocNovo_Click(object sender, EventArgs e)
        {
            lblIdLoc.Text = "-1";
            txtData.Text = DateTime.Now.ToShortDateString();

            txtData.Enabled = true;
            txtIdCliente.Enabled= true;
            cmbCliente.Enabled = true;
            btnLocNovo.Enabled = false;
            btnLocGravar.Enabled = true; 

            txtData.Focus(); 

        }

        private void btnLocGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Locacao bllLocacao = new Camadas.BLL.Locacao();
            Camadas.MODEL.Locacao locacao = new Camadas.MODEL.Locacao();

            locacao.id = Convert.ToInt32(lblIdLoc.Text);
            locacao.data = Convert.ToDateTime(txtData.Text);
            locacao.cliente_id = Convert.ToInt32(txtIdCliente.Text);

            bllLocacao.Insert(locacao);

            dtgLocacao.DataSource = bllLocacao.Select();
            int ultimo = dtgLocacao.RowCount - 1;
            dtgLocacao.Rows[ultimo].Selected = true; // seleciona o ultimo registro
            dtgLocacao.CurrentCell = dtgLocacao.Rows[ultimo].Cells[0];

            
            lblIdLoc.Text = dtgLocacao.Rows[ultimo].Cells["id"].Value.ToString(); 
            txtData.Text = dtgLocacao.Rows[ultimo].Cells["data"].Value.ToString();
            txtIdCliente.Text = dtgLocacao.Rows[ultimo].Cells["cliente_id"].Value.ToString();
            cmbCliente.SelectedValue = Convert.ToInt32(txtIdCliente.Text);

         

            txtData.Enabled = false;
            txtIdCliente.Enabled = false;
            cmbCliente.Enabled = false;
            btnLocNovo.Enabled = true;
            btnLocGravar.Enabled = false;

            carrega_Itens_Locacao(); 

        }

        private void dtgLocacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void dtgLocacao_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
          
        }

        private void btnItLocNovo_Click(object sender, EventArgs e)
        {
            lblIdItLoc.Text = "-1";
            lblStatus.Text = "E";

            txtFilme.Enabled = true;
            cmbFilme.Enabled = true;
            btnItLocGravar.Enabled = true;
            btnItLocNovo.Enabled = false; 
            cmbFilme.Focus(); 

        }

        private void btnItLocGravar_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Itens_Locacao bllItLoc = new Camadas.BLL.Itens_Locacao();
            Camadas.MODEL.Itens_Locacao item_locacao = new Camadas.MODEL.Itens_Locacao();

            item_locacao.id = Convert.ToInt32(lblIdItLoc.Text);
            int idLoc = Convert.ToInt32(lblIdLoc.Text);
            item_locacao.locacao_id = idLoc;
            item_locacao.filme_id = Convert.ToInt32(txtFilme.Text);
            item_locacao.status = 'E';

            bllItLoc.Insert(item_locacao);

            dtgItensLocacao.DataSource = bllItLoc.SelectByLocacao(idLoc);

            int ultimo = dtgItensLocacao.RowCount - 1;

            dtgItensLocacao.Rows[ultimo].Selected = true;//seleciona a linha desejada
            dtgItensLocacao.CurrentCell = dtgItensLocacao.Rows[ultimo].Cells[0];  //move para a ultima linha

            lblIdItLoc.Text = dtgItensLocacao.Rows[ultimo].Cells["id"].Value.ToString();
            txtFilme.Text = dtgItensLocacao.Rows[ultimo].Cells["filme_id"].Value.ToString();
            lblStatus.Text = dtgItensLocacao.Rows[ultimo].Cells["status"].Value.ToString();
            cmbFilme.SelectedValue = Convert.ToInt32(txtFilme.Text);

            txtFilme.Enabled = false;
            cmbFilme.Enabled = false;
            btnItLocGravar.Enabled = false;
            btnItLocNovo.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgItensLocacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdCliente.Text = cmbCliente.SelectedValue.ToString(); 
        }

        private void txtIdCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbCliente.SelectedValue = Convert.ToInt32(txtIdCliente.Text); 
            }
            catch
            {
                MessageBox.Show("Cliente não cadastrado..");
                txtIdCliente.Focus();                
            }
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbFilme_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilme.Text = cmbFilme.SelectedValue.ToString();
        }

        private void dtgLocacao_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dtgLocacao.SelectedRows.Count > 0)
            {
                lblIdLoc.Text = dtgLocacao.SelectedRows[0].Cells["id"].Value.ToString();
                txtData.Text = dtgLocacao.SelectedRows[0].Cells["data"].Value.ToString();
                txtIdCliente.Text = dtgLocacao.SelectedRows[0].Cells["cliente_id"].Value.ToString();
                cmbCliente.SelectedValue = Convert.ToInt32(txtIdCliente.Text);

                carrega_Itens_Locacao();
            }
        }

        private void dtgItensLocacao_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //preencher campos itens locação
            if (dtgItensLocacao.SelectedRows.Count > 0)
           {
                lblIdItLoc.Text = dtgItensLocacao.SelectedRows[0].Cells["id"].Value.ToString();
                txtFilme.Text = dtgItensLocacao.SelectedRows[0].Cells["filme_id"].Value.ToString();
                lblStatus.Text = dtgItensLocacao.SelectedRows[0].Cells["status"].Value.ToString();
                cmbFilme.SelectedValue = Convert.ToInt32(txtFilme.Text);
            }
        }

        private void txtFilme_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbFilme.SelectedValue = Convert.ToInt32(txtFilme.Text);
            }
            catch 
            {
                MessageBox.Show("Filme não encontrado...");
                txtFilme.Focus(); 
            }
        }
    }
}
