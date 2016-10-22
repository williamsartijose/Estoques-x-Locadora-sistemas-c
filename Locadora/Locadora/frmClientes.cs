using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora.Camadas; 

namespace Locadora
{
    public partial class frmClientes : Form
    {
        private char OP = 'X'; 

        public frmClientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            dtgClientes.DataSource = bllCliente.Select();

            habilitaCampos(false); 
        }

        private void habilitaCampos(bool status)
        {
            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;

            txtId.Enabled = false;
            txtNome.Enabled = status;
            txtEndereco.Enabled = status;
            txtCidade.Enabled = status;
            txtEstado.Enabled = status;
            txtAniversario.Enabled = status;
            dtgClientes.Enabled = !status; 
             
            if (OP!= 'E')
            {
                txtId.Text = "-1";
                txtNome.Text = "";
                txtEndereco.Text = string.Empty; // mesma coisa que ""
                txtCidade.Text = "";
                txtEstado.Text = "";
                txtAniversario.Text = ""; 
            }
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            OP = 'I'; 
            habilitaCampos(true);
            txtNome.Focus(); 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) > 0)
            {
                OP = 'E';
                habilitaCampos(true);
                txtNome.Focus();
            }
            else MessageBox.Show("Não há registro Selecionado");
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) > 0)
            {
                Camadas.MODEL.Cliente cliente = new Camadas.MODEL.Cliente();
                Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();

                cliente.id = Convert.ToInt32(txtId.Text);
                DialogResult result;
                result = MessageBox.Show("Deseja Remover o cliente Selecionado?",
                                          "Remover Cliente", 
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question, 
                                          MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    bllCliente.Delete(cliente);
                    MessageBox.Show("Cliente Removido com Sucesso...");
                }
                else MessageBox.Show("Não confirmada Remoção de Cliente...","Remover");

                
                dtgClientes.DataSource = bllCliente.Select(); //atualizar lista de registro
                habilitaCampos(false);
            }
            else MessageBox.Show("Não há registros Selecionados", "Remover"); 

           
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();  //fecha o formulário
            //this.Dispose(); //fecha a sua aplicação
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Camadas.MODEL.Cliente cliente = new Camadas.MODEL.Cliente();
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();

            //preencher o objeto cliente com os dados do formulario
            cliente.id = Convert.ToInt32(txtId.Text);
            cliente.nome = txtNome.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.cidade = txtCidade.Text;
            cliente.estado = txtEstado.Text;
            cliente.aniversario = Convert.ToDateTime(txtAniversario.Text);

            string msg;
            if (OP == 'I')
                msg = "Deseja Confirmar Inserção dos Dados?";
            else msg = "Deseja Confirmar Alteração dos Dados?";

            DialogResult resp;
            resp = MessageBox.Show(msg, "Gravar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1); 
            
            if (resp == DialogResult.OK)
            {
                if (OP == 'I')
                    bllCliente.Insert(cliente);
                else bllCliente.Update(cliente);  
            }

            dtgClientes.DataSource = bllCliente.Select(); 

            OP = 'X';
            habilitaCampos(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OP = 'X'; 
            habilitaCampos(false);
        }

        private void dtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgClientes_DoubleClick(object sender, EventArgs e)
        {
            if (dtgClientes.SelectedRows.Count > 0)
            {
                txtId.Text = dtgClientes.SelectedRows[0].Cells["id"].Value.ToString(); 
                txtNome.Text = dtgClientes.SelectedRows[0].Cells["nome"].Value.ToString();
                txtEndereco.Text = dtgClientes.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtCidade.Text = dtgClientes.SelectedRows[0].Cells["cidade"].Value.ToString();
                txtEstado.Text = dtgClientes.SelectedRows[0].Cells["estado"].Value.ToString();
                txtAniversario.Text = dtgClientes.SelectedRows[0].Cells["aniversario"].Value.ToString();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            pnlBusca.Visible = !pnlBusca.Visible; 
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblBusca.Visible = false;
            txtBusca.Visible = false; 
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            lblBusca.Text = "Informe o Codigo: ";
            txtBusca.Text = ""; 
            lblBusca.Visible = true;
            txtBusca.Visible = true;
            txtBusca.Focus(); 
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lblBusca.Text = "Informe o Nome: ";
            txtBusca.Text = "";
            lblBusca.Visible = true;
            txtBusca.Visible = true;
            txtBusca.Focus(); 
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            Camadas.BLL.Cliente bllCliente = new Camadas.BLL.Cliente();
            List<Camadas.MODEL.Cliente> lstCli = new List<Camadas.MODEL.Cliente>();

            if (rdbTodos.Checked)
                lstCli = bllCliente.Select();
            else if (txtBusca.Text != string.Empty)// "" 
            {
                if (rdbCodigo.Checked)
                    lstCli = bllCliente.SelectById(Convert.ToInt32(txtBusca.Text));
                else if (rdbNome.Checked)
                    lstCli = bllCliente.SelectByNome(txtBusca.Text); 
            }
            else MessageBox.Show("Não foi Informado Valor de Pesquisa");

            dtgClientes.DataSource = lstCli; 
        }
    }
}





