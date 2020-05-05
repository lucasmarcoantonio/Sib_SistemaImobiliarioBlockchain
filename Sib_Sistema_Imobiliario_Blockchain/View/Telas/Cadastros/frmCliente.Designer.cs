namespace Sib_Sistema_Imobiliario_Blockchain.View.Telas.Cadastros
{
    partial class frmCliente
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
            this.pnlResumoCliente = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvViewClientes = new System.Windows.Forms.DataGridView();
            this.lbClientes = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.maskPesquisarCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlResumoCliente
            // 
            this.pnlResumoCliente.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlResumoCliente.Location = new System.Drawing.Point(801, 0);
            this.pnlResumoCliente.Name = "pnlResumoCliente";
            this.pnlResumoCliente.Size = new System.Drawing.Size(233, 504);
            this.pnlResumoCliente.TabIndex = 6;
            this.pnlResumoCliente.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbCPF);
            this.panel2.Controls.Add(this.maskPesquisarCPF);
            this.panel2.Controls.Add(this.lbClientes);
            this.panel2.Controls.Add(this.btnCadastrar);
            this.panel2.Controls.Add(this.dgvViewClientes);
            this.panel2.Controls.Add(this.btnPesquisar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 504);
            this.panel2.TabIndex = 7;
            // 
            // dgvViewClientes
            // 
            this.dgvViewClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewClientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewClientes.Location = new System.Drawing.Point(60, 72);
            this.dgvViewClientes.Name = "dgvViewClientes";
            this.dgvViewClientes.Size = new System.Drawing.Size(684, 375);
            this.dgvViewClientes.TabIndex = 7;
            // 
            // lbClientes
            // 
            this.lbClientes.AutoSize = true;
            this.lbClientes.Font = new System.Drawing.Font("Arial", 15F);
            this.lbClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(54)))));
            this.lbClientes.Location = new System.Drawing.Point(56, 34);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(156, 23);
            this.lbClientes.TabIndex = 6;
            this.lbClientes.Text = "Lista de Clientes";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(156)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 8F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.Location = new System.Drawing.Point(492, 28);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(111, 29);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(156)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 8F);
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.Location = new System.Drawing.Point(633, 28);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(111, 29);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // maskPesquisarCPF
            // 
            this.maskPesquisarCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskPesquisarCPF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.maskPesquisarCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskPesquisarCPF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskPesquisarCPF.Location = new System.Drawing.Point(356, 33);
            this.maskPesquisarCPF.Mask = "000\\.000\\.000 - 00";
            this.maskPesquisarCPF.Name = "maskPesquisarCPF";
            this.maskPesquisarCPF.Size = new System.Drawing.Size(114, 21);
            this.maskPesquisarCPF.TabIndex = 15;
            this.maskPesquisarCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCPF
            // 
            this.lbCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(324, 37);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(31, 15);
            this.lbCPF.TabIndex = 16;
            this.lbCPF.Text = "CPF";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlResumoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCliente";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlResumoCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox maskPesquisarCPF;
        private System.Windows.Forms.Label lbClientes;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvViewClientes;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lbCPF;
    }
}