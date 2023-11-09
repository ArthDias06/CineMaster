namespace CineMaster
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
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
            this.TxtPreco = new System.Windows.Forms.TextBox();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblPreco = new System.Windows.Forms.Label();
            this.LblSala = new System.Windows.Forms.Label();
            this.LblSessao = new System.Windows.Forms.Label();
            this.LblFilme = new System.Windows.Forms.Label();
            this.CblCliente = new System.Windows.Forms.ComboBox();
            this.CblFilme = new System.Windows.Forms.ComboBox();
            this.CblHorario = new System.Windows.Forms.ComboBox();
            this.CblSala = new System.Windows.Forms.ComboBox();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.DtgPrincipal = new System.Windows.Forms.DataGridView();
            this.StsErro = new System.Windows.Forms.StatusStrip();
            this.TslPrincipal = new System.Windows.Forms.ToolStripStatusLabel();
            this.MstMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPrincipal)).BeginInit();
            this.StsErro.SuspendLayout();
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
            this.TsmiIngresso.Text = "Comprar ingresso";
            // 
            // TsmiFilme
            // 
            this.TsmiFilme.Name = "TsmiFilme";
            this.TsmiFilme.Size = new System.Drawing.Size(178, 22);
            this.TsmiFilme.Text = "Cadastrar Filmes";
            this.TsmiFilme.Click += new System.EventHandler(this.TsmiFilme_Click);
            // 
            // TsmiSessao
            // 
            this.TsmiSessao.Name = "TsmiSessao";
            this.TsmiSessao.Size = new System.Drawing.Size(178, 22);
            this.TsmiSessao.Text = "Cadastrar Sessões";
            this.TsmiSessao.Click += new System.EventHandler(this.TsmiSessao_Click);
            // 
            // TsmiCliente
            // 
            this.TsmiCliente.Name = "TsmiCliente";
            this.TsmiCliente.Size = new System.Drawing.Size(178, 22);
            this.TsmiCliente.Text = "Cadastrar Clientes";
            this.TsmiCliente.Click += new System.EventHandler(this.TsmiCliente_Click);
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
            // TxtPreco
            // 
            this.TxtPreco.Location = new System.Drawing.Point(698, 73);
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.ReadOnly = true;
            this.TxtPreco.Size = new System.Drawing.Size(73, 20);
            this.TxtPreco.TabIndex = 3;
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblCliente.Location = new System.Drawing.Point(12, 56);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(39, 13);
            this.LblCliente.TabIndex = 8;
            this.LblCliente.Text = "Cliente";
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPreco.Location = new System.Drawing.Point(695, 56);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(35, 13);
            this.LblPreco.TabIndex = 9;
            this.LblPreco.Text = "Preço";
            // 
            // LblSala
            // 
            this.LblSala.AutoSize = true;
            this.LblSala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblSala.Location = new System.Drawing.Point(610, 56);
            this.LblSala.Name = "LblSala";
            this.LblSala.Size = new System.Drawing.Size(28, 13);
            this.LblSala.TabIndex = 11;
            this.LblSala.Text = "Sala";
            // 
            // LblSessao
            // 
            this.LblSessao.AutoSize = true;
            this.LblSessao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblSessao.Location = new System.Drawing.Point(486, 56);
            this.LblSessao.Name = "LblSessao";
            this.LblSessao.Size = new System.Drawing.Size(42, 13);
            this.LblSessao.TabIndex = 12;
            this.LblSessao.Text = "Sessão";
            // 
            // LblFilme
            // 
            this.LblFilme.AutoSize = true;
            this.LblFilme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFilme.Location = new System.Drawing.Point(252, 56);
            this.LblFilme.Name = "LblFilme";
            this.LblFilme.Size = new System.Drawing.Size(31, 13);
            this.LblFilme.TabIndex = 13;
            this.LblFilme.Text = "Filme";
            // 
            // CblCliente
            // 
            this.CblCliente.FormattingEnabled = true;
            this.CblCliente.Location = new System.Drawing.Point(15, 72);
            this.CblCliente.Name = "CblCliente";
            this.CblCliente.Size = new System.Drawing.Size(216, 21);
            this.CblCliente.TabIndex = 14;
            this.CblCliente.SelectedIndexChanged += new System.EventHandler(this.CblCliente_SelectedIndexChanged);
            // 
            // CblFilme
            // 
            this.CblFilme.FormattingEnabled = true;
            this.CblFilme.Location = new System.Drawing.Point(255, 72);
            this.CblFilme.Name = "CblFilme";
            this.CblFilme.Size = new System.Drawing.Size(216, 21);
            this.CblFilme.TabIndex = 15;
            this.CblFilme.SelectedIndexChanged += new System.EventHandler(this.CblFilme_SelectedIndexChanged);
            // 
            // CblHorario
            // 
            this.CblHorario.FormattingEnabled = true;
            this.CblHorario.Location = new System.Drawing.Point(489, 72);
            this.CblHorario.Name = "CblHorario";
            this.CblHorario.Size = new System.Drawing.Size(100, 21);
            this.CblHorario.TabIndex = 16;
            this.CblHorario.SelectedIndexChanged += new System.EventHandler(this.CblHorario_SelectedIndexChanged);
            // 
            // CblSala
            // 
            this.CblSala.FormattingEnabled = true;
            this.CblSala.Location = new System.Drawing.Point(613, 72);
            this.CblSala.Name = "CblSala";
            this.CblSala.Size = new System.Drawing.Size(67, 21);
            this.CblSala.TabIndex = 17;
            this.CblSala.SelectedIndexChanged += new System.EventHandler(this.CblSala_SelectedIndexChanged);
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.Lime;
            this.BtnNovo.Location = new System.Drawing.Point(15, 120);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(105, 34);
            this.BtnNovo.TabIndex = 19;
            this.BtnNovo.Text = "Comprar";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnCancelar.Location = new System.Drawing.Point(498, 120);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(105, 34);
            this.BtnCancelar.TabIndex = 20;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.Red;
            this.BtnExcluir.Location = new System.Drawing.Point(340, 120);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(105, 34);
            this.BtnExcluir.TabIndex = 21;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Yellow;
            this.BtnEditar.Location = new System.Drawing.Point(178, 120);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(105, 34);
            this.BtnEditar.TabIndex = 22;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // TxtBusca
            // 
            this.TxtBusca.Location = new System.Drawing.Point(15, 177);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(430, 20);
            this.TxtBusca.TabIndex = 23;
            // 
            // DtgPrincipal
            // 
            this.DtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPrincipal.Location = new System.Drawing.Point(15, 220);
            this.DtgPrincipal.Name = "DtgPrincipal";
            this.DtgPrincipal.Size = new System.Drawing.Size(773, 150);
            this.DtgPrincipal.TabIndex = 24;
            // 
            // StsErro
            // 
            this.StsErro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TslPrincipal});
            this.StsErro.Location = new System.Drawing.Point(0, 401);
            this.StsErro.Name = "StsErro";
            this.StsErro.Size = new System.Drawing.Size(800, 22);
            this.StsErro.TabIndex = 25;
            this.StsErro.Text = "statusStrip1";
            // 
            // TslPrincipal
            // 
            this.TslPrincipal.BackColor = System.Drawing.Color.Gainsboro;
            this.TslPrincipal.Name = "TslPrincipal";
            this.TslPrincipal.Size = new System.Drawing.Size(28, 17);
            this.TslPrincipal.Text = "Erro";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.StsErro);
            this.Controls.Add(this.DtgPrincipal);
            this.Controls.Add(this.TxtBusca);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.CblSala);
            this.Controls.Add(this.CblHorario);
            this.Controls.Add(this.CblFilme);
            this.Controls.Add(this.CblCliente);
            this.Controls.Add(this.LblFilme);
            this.Controls.Add(this.LblSessao);
            this.Controls.Add(this.LblSala);
            this.Controls.Add(this.LblPreco);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.TxtPreco);
            this.Controls.Add(this.MstMenu);
            this.MainMenuStrip = this.MstMenu;
            this.Name = "FrmPrincipal";
            this.Text = "CineMaster";
            this.MstMenu.ResumeLayout(false);
            this.MstMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPrincipal)).EndInit();
            this.StsErro.ResumeLayout(false);
            this.StsErro.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem TsmiCategoria;
        private System.Windows.Forms.TextBox TxtPreco;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.Label LblSala;
        private System.Windows.Forms.Label LblSessao;
        private System.Windows.Forms.Label LblFilme;
        private System.Windows.Forms.ComboBox CblCliente;
        private System.Windows.Forms.ComboBox CblFilme;
        private System.Windows.Forms.ComboBox CblHorario;
        private System.Windows.Forms.ComboBox CblSala;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.DataGridView DtgPrincipal;
        private System.Windows.Forms.StatusStrip StsErro;
        private System.Windows.Forms.ToolStripStatusLabel TslPrincipal;
    }
}

