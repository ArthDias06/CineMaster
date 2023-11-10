namespace CineMaster
{
    partial class FrmCliente
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
            this.MstMenu = new System.Windows.Forms.MenuStrip();
            this.TsmTelas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiIngresso = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiFilme = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSessao = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TslCliente = new System.Windows.Forms.ToolStripStatusLabel();
            this.TxtClienteNome = new System.Windows.Forms.TextBox();
            this.LblClienteNome = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.DtgCliente = new System.Windows.Forms.DataGridView();
            this.LblNascimento = new System.Windows.Forms.Label();
            this.DtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.LblTipoCliente = new System.Windows.Forms.Label();
            this.CblTipoCliente = new System.Windows.Forms.ComboBox();
            this.LblBusca = new System.Windows.Forms.Label();
            this.MstMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // MstMenu
            // 
            this.MstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmTelas,
            this.TsmAjuda});
            this.MstMenu.Location = new System.Drawing.Point(0, 0);
            this.MstMenu.Name = "MstMenu";
            this.MstMenu.Size = new System.Drawing.Size(800, 24);
            this.MstMenu.TabIndex = 0;
            this.MstMenu.Text = "Menu";
            // 
            // TsmTelas
            // 
            this.TsmTelas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiIngresso,
            this.TsmiFilme,
            this.TsmiSessao,
            this.TsmiCliente,
            this.TsmiCategoria});
            this.TsmTelas.Name = "TsmTelas";
            this.TsmTelas.Size = new System.Drawing.Size(50, 20);
            this.TsmTelas.Text = "Menu";
            // 
            // TsmiIngresso
            // 
            this.TsmiIngresso.Name = "TsmiIngresso";
            this.TsmiIngresso.Size = new System.Drawing.Size(178, 22);
            this.TsmiIngresso.Text = "Compara Ingesso";
            this.TsmiIngresso.Click += new System.EventHandler(this.TsmiIngresso_Click);
            // 
            // TsmiFilme
            // 
            this.TsmiFilme.Name = "TsmiFilme";
            this.TsmiFilme.Size = new System.Drawing.Size(178, 22);
            this.TsmiFilme.Text = "Cadastrar Filme";
            this.TsmiFilme.Click += new System.EventHandler(this.TsmiFilme_Click);
            // 
            // TsmiSessao
            // 
            this.TsmiSessao.Name = "TsmiSessao";
            this.TsmiSessao.Size = new System.Drawing.Size(178, 22);
            this.TsmiSessao.Text = "Cadastrar Sessao";
            this.TsmiSessao.Click += new System.EventHandler(this.TsmiSessao_Click);
            // 
            // TsmiCliente
            // 
            this.TsmiCliente.Name = "TsmiCliente";
            this.TsmiCliente.Size = new System.Drawing.Size(178, 22);
            this.TsmiCliente.Text = "Cadastrar Cliente";
            // 
            // TsmiCategoria
            // 
            this.TsmiCategoria.Name = "TsmiCategoria";
            this.TsmiCategoria.Size = new System.Drawing.Size(178, 22);
            this.TsmiCategoria.Text = "Cadastrar Categoria";
            this.TsmiCategoria.Click += new System.EventHandler(this.TsmiCategoria_Click);
            // 
            // TsmAjuda
            // 
            this.TsmAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiAjuda});
            this.TsmAjuda.Name = "TsmAjuda";
            this.TsmAjuda.Size = new System.Drawing.Size(50, 20);
            this.TsmAjuda.Text = "Ajuda";
            // 
            // TsmiAjuda
            // 
            this.TsmiAjuda.Name = "TsmiAjuda";
            this.TsmiAjuda.Size = new System.Drawing.Size(105, 22);
            this.TsmiAjuda.Text = "Ajuda";
            this.TsmiAjuda.Click += new System.EventHandler(this.TsmiAjuda_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TslCliente});
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TslCliente
            // 
            this.TslCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.TslCliente.Name = "TslCliente";
            this.TslCliente.Size = new System.Drawing.Size(28, 17);
            this.TslCliente.Text = "Erro";
            // 
            // TxtClienteNome
            // 
            this.TxtClienteNome.Location = new System.Drawing.Point(12, 68);
            this.TxtClienteNome.Name = "TxtClienteNome";
            this.TxtClienteNome.Size = new System.Drawing.Size(251, 20);
            this.TxtClienteNome.TabIndex = 2;
            // 
            // LblClienteNome
            // 
            this.LblClienteNome.AutoSize = true;
            this.LblClienteNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblClienteNome.Location = new System.Drawing.Point(13, 49);
            this.LblClienteNome.Name = "LblClienteNome";
            this.LblClienteNome.Size = new System.Drawing.Size(35, 13);
            this.LblClienteNome.TabIndex = 3;
            this.LblClienteNome.Text = "Nome";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblCpf.Location = new System.Drawing.Point(298, 117);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(27, 13);
            this.LblCpf.TabIndex = 7;
            this.LblCpf.Text = "CPF";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTelefone.Location = new System.Drawing.Point(13, 117);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(49, 13);
            this.LblTelefone.TabIndex = 8;
            this.LblTelefone.Text = "Telefone";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblSenha.Location = new System.Drawing.Point(567, 49);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(38, 13);
            this.LblSenha.TabIndex = 9;
            this.LblSenha.Text = "Senha";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblEmail.Location = new System.Drawing.Point(298, 49);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 10;
            this.LblEmail.Text = "Email";
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(301, 133);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(237, 20);
            this.TxtCpf.TabIndex = 13;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(12, 133);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(251, 20);
            this.TxtTelefone.TabIndex = 14;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(570, 68);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(200, 20);
            this.TxtSenha.TabIndex = 15;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(301, 68);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(237, 20);
            this.TxtEmail.TabIndex = 16;
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.Lime;
            this.BtnNovo.Location = new System.Drawing.Point(12, 218);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(97, 38);
            this.BtnNovo.TabIndex = 17;
            this.BtnNovo.Text = "Novo Cliente";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnCancelar.Location = new System.Drawing.Point(673, 218);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(97, 38);
            this.BtnCancelar.TabIndex = 18;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.Red;
            this.BtnExcluir.Location = new System.Drawing.Point(462, 218);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(97, 38);
            this.BtnExcluir.TabIndex = 19;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Yellow;
            this.BtnEditar.Location = new System.Drawing.Point(233, 218);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(97, 38);
            this.BtnEditar.TabIndex = 20;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // TxtBusca
            // 
            this.TxtBusca.Location = new System.Drawing.Point(12, 290);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(758, 20);
            this.TxtBusca.TabIndex = 22;
            this.TxtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBusca_KeyPress);
            // 
            // DtgCliente
            // 
            this.DtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgCliente.Location = new System.Drawing.Point(12, 316);
            this.DtgCliente.Name = "DtgCliente";
            this.DtgCliente.Size = new System.Drawing.Size(758, 150);
            this.DtgCliente.TabIndex = 23;
            this.DtgCliente.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgCliente_RowHeaderMouseClick);
            // 
            // LblNascimento
            // 
            this.LblNascimento.AutoSize = true;
            this.LblNascimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNascimento.Location = new System.Drawing.Point(567, 113);
            this.LblNascimento.Name = "LblNascimento";
            this.LblNascimento.Size = new System.Drawing.Size(102, 13);
            this.LblNascimento.TabIndex = 24;
            this.LblNascimento.Text = "Data de nascimento";
            // 
            // DtpNascimento
            // 
            this.DtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpNascimento.Location = new System.Drawing.Point(570, 130);
            this.DtpNascimento.Name = "DtpNascimento";
            this.DtpNascimento.Size = new System.Drawing.Size(200, 20);
            this.DtpNascimento.TabIndex = 25;
            // 
            // LblTipoCliente
            // 
            this.LblTipoCliente.AutoSize = true;
            this.LblTipoCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTipoCliente.Location = new System.Drawing.Point(9, 166);
            this.LblTipoCliente.Name = "LblTipoCliente";
            this.LblTipoCliente.Size = new System.Drawing.Size(77, 13);
            this.LblTipoCliente.TabIndex = 27;
            this.LblTipoCliente.Text = "Tipo do cliente";
            // 
            // CblTipoCliente
            // 
            this.CblTipoCliente.FormattingEnabled = true;
            this.CblTipoCliente.Location = new System.Drawing.Point(12, 182);
            this.CblTipoCliente.Name = "CblTipoCliente";
            this.CblTipoCliente.Size = new System.Drawing.Size(251, 21);
            this.CblTipoCliente.TabIndex = 28;
            // 
            // LblBusca
            // 
            this.LblBusca.AutoSize = true;
            this.LblBusca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblBusca.Location = new System.Drawing.Point(9, 274);
            this.LblBusca.Name = "LblBusca";
            this.LblBusca.Size = new System.Drawing.Size(37, 13);
            this.LblBusca.TabIndex = 29;
            this.LblBusca.Text = "Busca";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.LblBusca);
            this.Controls.Add(this.CblTipoCliente);
            this.Controls.Add(this.LblTipoCliente);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DtpNascimento);
            this.Controls.Add(this.LblNascimento);
            this.Controls.Add(this.DtgCliente);
            this.Controls.Add(this.TxtBusca);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblClienteNome);
            this.Controls.Add(this.TxtClienteNome);
            this.Controls.Add(this.MstMenu);
            this.MainMenuStrip = this.MstMenu;
            this.Name = "FrmCliente";
            this.Text = "Cadastar Cliente";
            this.MstMenu.ResumeLayout(false);
            this.MstMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MstMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmTelas;
        private System.Windows.Forms.ToolStripMenuItem TsmiIngresso;
        private System.Windows.Forms.ToolStripMenuItem TsmiFilme;
        private System.Windows.Forms.ToolStripMenuItem TsmiSessao;
        private System.Windows.Forms.ToolStripMenuItem TsmiCliente;
        private System.Windows.Forms.ToolStripMenuItem TsmAjuda;
        private System.Windows.Forms.ToolStripMenuItem TsmiAjuda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TslCliente;
        private System.Windows.Forms.TextBox TxtClienteNome;
        private System.Windows.Forms.Label LblClienteNome;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.DataGridView DtgCliente;
        private System.Windows.Forms.Label LblNascimento;
        private System.Windows.Forms.DateTimePicker DtpNascimento;
        private System.Windows.Forms.ToolStripMenuItem TsmiCategoria;
        private System.Windows.Forms.Label LblTipoCliente;
        private System.Windows.Forms.ComboBox CblTipoCliente;
        private System.Windows.Forms.Label LblBusca;
    }
}