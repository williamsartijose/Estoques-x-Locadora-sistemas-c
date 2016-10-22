namespace Locadora
{
    partial class frmLocacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblIdLoc = new System.Windows.Forms.Label();
            this.btnLocGravar = new System.Windows.Forms.Button();
            this.dtgLocacao = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLocNovo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblIdItLoc = new System.Windows.Forms.Label();
            this.txtFilme = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnItLocNovo = new System.Windows.Forms.Button();
            this.btnItLocGravar = new System.Windows.Forms.Button();
            this.dtgItensLocacao = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbFilme = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLocacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensLocacao)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data: ";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente:";
            // 
            // txtData
            // 
            this.txtData.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtData.Enabled = false;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(138, 79);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(123, 30);
            this.txtData.TabIndex = 4;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(138, 127);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(123, 30);
            this.txtIdCliente.TabIndex = 5;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            this.txtIdCliente.Leave += new System.EventHandler(this.txtIdCliente_Leave);
            // 
            // lblIdLoc
            // 
            this.lblIdLoc.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.lblIdLoc.AutoSize = true;
            this.lblIdLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLoc.Location = new System.Drawing.Point(133, 36);
            this.lblIdLoc.Name = "lblIdLoc";
            this.lblIdLoc.Size = new System.Drawing.Size(30, 25);
            this.lblIdLoc.TabIndex = 6;
            this.lblIdLoc.Text = "-1";
            this.lblIdLoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLocGravar
            // 
            this.btnLocGravar.Enabled = false;
            this.btnLocGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocGravar.Location = new System.Drawing.Point(128, 173);
            this.btnLocGravar.Name = "btnLocGravar";
            this.btnLocGravar.Size = new System.Drawing.Size(97, 35);
            this.btnLocGravar.TabIndex = 8;
            this.btnLocGravar.Text = "Gravar";
            this.btnLocGravar.UseVisualStyleBackColor = true;
            this.btnLocGravar.Click += new System.EventHandler(this.btnLocGravar_Click);
            // 
            // dtgLocacao
            // 
            this.dtgLocacao.AllowUserToResizeColumns = false;
            this.dtgLocacao.AllowUserToResizeRows = false;
            this.dtgLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLocacao.Location = new System.Drawing.Point(25, 214);
            this.dtgLocacao.Name = "dtgLocacao";
            this.dtgLocacao.RowTemplate.Height = 24;
            this.dtgLocacao.Size = new System.Drawing.Size(995, 129);
            this.dtgLocacao.TabIndex = 9;
            this.dtgLocacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLocacao_CellContentClick);
            this.dtgLocacao.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dtgLocacao_RowStateChanged);
            this.dtgLocacao.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgLocacao_MouseDoubleClick);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(242, 173);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 35);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLocNovo
            // 
            this.btnLocNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocNovo.Location = new System.Drawing.Point(25, 173);
            this.btnLocNovo.Name = "btnLocNovo";
            this.btnLocNovo.Size = new System.Drawing.Size(87, 35);
            this.btnLocNovo.TabIndex = 11;
            this.btnLocNovo.Text = "Nova";
            this.btnLocNovo.UseVisualStyleBackColor = true;
            this.btnLocNovo.Click += new System.EventHandler(this.btnLocNovo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Filme:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(124, 119);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 15;
            // 
            // lblIdItLoc
            // 
            this.lblIdItLoc.AutoSize = true;
            this.lblIdItLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdItLoc.Location = new System.Drawing.Point(124, 41);
            this.lblIdItLoc.Name = "lblIdItLoc";
            this.lblIdItLoc.Size = new System.Drawing.Size(30, 25);
            this.lblIdItLoc.TabIndex = 16;
            this.lblIdItLoc.Text = "-1";
            // 
            // txtFilme
            // 
            this.txtFilme.Enabled = false;
            this.txtFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilme.Location = new System.Drawing.Point(124, 77);
            this.txtFilme.Name = "txtFilme";
            this.txtFilme.Size = new System.Drawing.Size(100, 30);
            this.txtFilme.TabIndex = 17;
            this.txtFilme.Leave += new System.EventHandler(this.txtFilme_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 29);
            this.label10.TabIndex = 18;
            this.label10.Text = "Itens Locação ";
            // 
            // btnItLocNovo
            // 
            this.btnItLocNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItLocNovo.Location = new System.Drawing.Point(11, 163);
            this.btnItLocNovo.Name = "btnItLocNovo";
            this.btnItLocNovo.Size = new System.Drawing.Size(90, 40);
            this.btnItLocNovo.TabIndex = 19;
            this.btnItLocNovo.Text = "Novo";
            this.btnItLocNovo.UseVisualStyleBackColor = true;
            this.btnItLocNovo.Click += new System.EventHandler(this.btnItLocNovo_Click);
            // 
            // btnItLocGravar
            // 
            this.btnItLocGravar.Enabled = false;
            this.btnItLocGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItLocGravar.Location = new System.Drawing.Point(124, 163);
            this.btnItLocGravar.Name = "btnItLocGravar";
            this.btnItLocGravar.Size = new System.Drawing.Size(90, 40);
            this.btnItLocGravar.TabIndex = 20;
            this.btnItLocGravar.Text = "Gravar";
            this.btnItLocGravar.UseVisualStyleBackColor = true;
            this.btnItLocGravar.Click += new System.EventHandler(this.btnItLocGravar_Click);
            // 
            // dtgItensLocacao
            // 
            this.dtgItensLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItensLocacao.Location = new System.Drawing.Point(11, 209);
            this.dtgItensLocacao.Name = "dtgItensLocacao";
            this.dtgItensLocacao.RowTemplate.Height = 24;
            this.dtgItensLocacao.Size = new System.Drawing.Size(1000, 150);
            this.dtgItensLocacao.TabIndex = 21;
            this.dtgItensLocacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgItensLocacao_CellContentClick);
            this.dtgItensLocacao.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgItensLocacao_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbCliente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdCliente);
            this.panel1.Controls.Add(this.lblIdLoc);
            this.panel1.Controls.Add(this.btnLocGravar);
            this.panel1.Controls.Add(this.dtgLocacao);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnLocNovo);
            this.panel1.Location = new System.Drawing.Point(26, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 360);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbCliente
            // 
            this.cmbCliente.Enabled = false;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(284, 127);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(315, 33);
            this.cmbCliente.TabIndex = 12;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "LOCAÇÂO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cmbFilme);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtgItensLocacao);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnItLocGravar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnItLocNovo);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.lblIdItLoc);
            this.panel2.Controls.Add(this.txtFilme);
            this.panel2.Location = new System.Drawing.Point(26, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 382);
            this.panel2.TabIndex = 23;
            // 
            // cmbFilme
            // 
            this.cmbFilme.Enabled = false;
            this.cmbFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilme.FormattingEnabled = true;
            this.cmbFilme.Location = new System.Drawing.Point(242, 78);
            this.cmbFilme.Name = "cmbFilme";
            this.cmbFilme.Size = new System.Drawing.Size(326, 33);
            this.cmbFilme.TabIndex = 22;
            this.cmbFilme.SelectedIndexChanged += new System.EventHandler(this.cmbFilme_SelectedIndexChanged);
            // 
            // frmLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1143, 804);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locacao";
            this.Load += new System.EventHandler(this.frmLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLocacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensLocacao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblIdLoc;
        private System.Windows.Forms.Button btnLocGravar;
        private System.Windows.Forms.DataGridView dtgLocacao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLocNovo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblIdItLoc;
        private System.Windows.Forms.TextBox txtFilme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnItLocNovo;
        private System.Windows.Forms.Button btnItLocGravar;
        private System.Windows.Forms.DataGridView dtgItensLocacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbFilme;
    }
}