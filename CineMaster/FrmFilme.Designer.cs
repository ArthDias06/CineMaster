namespace CineMaster
{
    partial class FrmFilme
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
            this.TsmAções = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiIngresso = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiFilme = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSessao = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.DtgFilme = new System.Windows.Forms.DataGridView();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.CblGenero = new System.Windows.Forms.ComboBox();
            this.LblGenero = new System.Windows.Forms.Label();
            this.LblClassificacao = new System.Windows.Forms.Label();
            this.LblSinopse = new System.Windows.Forms.Label();
            this.RtxtSinopse = new System.Windows.Forms.RichTextBox();
            this.DtpEstreia = new System.Windows.Forms.DateTimePicker();
            this.LblEstreia = new System.Windows.Forms.Label();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TslFilme = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblBusca = new System.Windows.Forms.Label();
            this.CblClassificacao = new System.Windows.Forms.ComboBox();
            this.MstMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFilme)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MstMenu
            // 
            this.MstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmAções,
            this.TsmAjuda});
            this.MstMenu.Location = new System.Drawing.Point(0, 0);
            this.MstMenu.Name = "MstMenu";
            this.MstMenu.Size = new System.Drawing.Size(746, 24);
            this.MstMenu.TabIndex = 0;
            this.MstMenu.Text = "Cadastro de filmes";
            // 
            // TsmAções
            // 
            this.TsmAções.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiIngresso,
            this.TsmiFilme,
            this.TsmiSessao,
            this.TsmiCliente,
            this.TsmiCategoria});
            this.TsmAções.Name = "TsmAções";
            this.TsmAções.Size = new System.Drawing.Size(50, 20);
            this.TsmAções.Text = "Menu";
            // 
            // TsmiIngresso
            // 
            this.TsmiIngresso.Name = "TsmiIngresso";
            this.TsmiIngresso.Size = new System.Drawing.Size(180, 22);
            this.TsmiIngresso.Text = "Comprar Ingresso";
            this.TsmiIngresso.Click += new System.EventHandler(this.TsmiIngresso_Click);
            // 
            // TsmiFilme
            // 
            this.TsmiFilme.Name = "TsmiFilme";
            this.TsmiFilme.Size = new System.Drawing.Size(180, 22);
            this.TsmiFilme.Text = "Cadastrar Filme";
            // 
            // TsmiSessao
            // 
            this.TsmiSessao.Name = "TsmiSessao";
            this.TsmiSessao.Size = new System.Drawing.Size(180, 22);
            this.TsmiSessao.Text = "Cadastrar Sessao";
            this.TsmiSessao.Click += new System.EventHandler(this.TsmiSessao_Click);
            // 
            // TsmiCliente
            // 
            this.TsmiCliente.Name = "TsmiCliente";
            this.TsmiCliente.Size = new System.Drawing.Size(180, 22);
            this.TsmiCliente.Text = "Cadastrar Cliente";
            this.TsmiCliente.Click += new System.EventHandler(this.TsmiCliente_Click);
            // 
            // TsmiCategoria
            // 
            this.TsmiCategoria.Name = "TsmiCategoria";
            this.TsmiCategoria.Size = new System.Drawing.Size(180, 22);
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
            // DtgFilme
            // 
            this.DtgFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgFilme.Location = new System.Drawing.Point(40, 366);
            this.DtgFilme.Name = "DtgFilme";
            this.DtgFilme.Size = new System.Drawing.Size(676, 150);
            this.DtgFilme.TabIndex = 1;
            this.DtgFilme.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgFilme_RowHeaderMouseClick);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblNome.Location = new System.Drawing.Point(37, 42);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(74, 13);
            this.LblNome.TabIndex = 3;
            this.LblNome.Text = "Nome do filme";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(40, 69);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(153, 20);
            this.TxtNome.TabIndex = 4;
            // 
            // CblGenero
            // 
            this.CblGenero.FormattingEnabled = true;
            this.CblGenero.Location = new System.Drawing.Point(250, 68);
            this.CblGenero.Name = "CblGenero";
            this.CblGenero.Size = new System.Drawing.Size(141, 21);
            this.CblGenero.TabIndex = 5;
            this.CblGenero.SelectedIndexChanged += new System.EventHandler(this.CblGenero_SelectedIndexChanged);
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblGenero.Location = new System.Drawing.Point(247, 42);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(81, 13);
            this.LblGenero.TabIndex = 6;
            this.LblGenero.Text = "Gênero do filme";
            // 
            // LblClassificacao
            // 
            this.LblClassificacao.AutoSize = true;
            this.LblClassificacao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblClassificacao.Location = new System.Drawing.Point(443, 42);
            this.LblClassificacao.Name = "LblClassificacao";
            this.LblClassificacao.Size = new System.Drawing.Size(98, 13);
            this.LblClassificacao.TabIndex = 8;
            this.LblClassificacao.Text = "Classificação etária";
            // 
            // LblSinopse
            // 
            this.LblSinopse.AutoSize = true;
            this.LblSinopse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblSinopse.Location = new System.Drawing.Point(37, 106);
            this.LblSinopse.Name = "LblSinopse";
            this.LblSinopse.Size = new System.Drawing.Size(45, 13);
            this.LblSinopse.TabIndex = 9;
            this.LblSinopse.Text = "Sinopse";
            // 
            // RtxtSinopse
            // 
            this.RtxtSinopse.Location = new System.Drawing.Point(40, 132);
            this.RtxtSinopse.Name = "RtxtSinopse";
            this.RtxtSinopse.Size = new System.Drawing.Size(211, 96);
            this.RtxtSinopse.TabIndex = 10;
            this.RtxtSinopse.Text = "";
            // 
            // DtpEstreia
            // 
            this.DtpEstreia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpEstreia.Location = new System.Drawing.Point(319, 132);
            this.DtpEstreia.Name = "DtpEstreia";
            this.DtpEstreia.Size = new System.Drawing.Size(142, 20);
            this.DtpEstreia.TabIndex = 11;
            // 
            // LblEstreia
            // 
            this.LblEstreia.AutoSize = true;
            this.LblEstreia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblEstreia.Location = new System.Drawing.Point(316, 106);
            this.LblEstreia.Name = "LblEstreia";
            this.LblEstreia.Size = new System.Drawing.Size(79, 13);
            this.LblEstreia.TabIndex = 12;
            this.LblEstreia.Text = "Data de estreia";
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.Lime;
            this.BtnNovo.Location = new System.Drawing.Point(40, 258);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(102, 34);
            this.BtnNovo.TabIndex = 13;
            this.BtnNovo.Text = "Novo filme";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnCancelar.Location = new System.Drawing.Point(493, 258);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(102, 34);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.Red;
            this.BtnExcluir.Location = new System.Drawing.Point(348, 258);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(102, 34);
            this.BtnExcluir.TabIndex = 15;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Yellow;
            this.BtnEditar.Location = new System.Drawing.Point(198, 258);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(102, 34);
            this.BtnEditar.TabIndex = 16;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // TxtBusca
            // 
            this.TxtBusca.Location = new System.Drawing.Point(40, 328);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(410, 20);
            this.TxtBusca.TabIndex = 18;
            this.TxtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBusca_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TslFilme});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(746, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TslFilme
            // 
            this.TslFilme.BackColor = System.Drawing.Color.Gainsboro;
            this.TslFilme.Name = "TslFilme";
            this.TslFilme.Size = new System.Drawing.Size(28, 17);
            this.TslFilme.Text = "Erro";
            // 
            // LblBusca
            // 
            this.LblBusca.AutoSize = true;
            this.LblBusca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblBusca.Location = new System.Drawing.Point(37, 312);
            this.LblBusca.Name = "LblBusca";
            this.LblBusca.Size = new System.Drawing.Size(37, 13);
            this.LblBusca.TabIndex = 20;
            this.LblBusca.Text = "Busca";
            // 
            // CblClassificacao
            // 
            this.CblClassificacao.FormattingEnabled = true;
            this.CblClassificacao.Location = new System.Drawing.Point(446, 68);
            this.CblClassificacao.Name = "CblClassificacao";
            this.CblClassificacao.Size = new System.Drawing.Size(149, 21);
            this.CblClassificacao.TabIndex = 21;
            // 
            // FrmFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(746, 548);
            this.Controls.Add(this.CblClassificacao);
            this.Controls.Add(this.LblBusca);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TxtBusca);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.LblEstreia);
            this.Controls.Add(this.DtpEstreia);
            this.Controls.Add(this.RtxtSinopse);
            this.Controls.Add(this.LblSinopse);
            this.Controls.Add(this.LblClassificacao);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.CblGenero);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.DtgFilme);
            this.Controls.Add(this.MstMenu);
            this.MainMenuStrip = this.MstMenu;
            this.Name = "FrmFilme";
            this.Text = "Cadastro de Filme";
            this.MstMenu.ResumeLayout(false);
            this.MstMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFilme)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MstMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmAções;
        private System.Windows.Forms.ToolStripMenuItem TsmiIngresso;
        private System.Windows.Forms.ToolStripMenuItem TsmiFilme;
        private System.Windows.Forms.ToolStripMenuItem TsmiSessao;
        private System.Windows.Forms.ToolStripMenuItem TsmiCliente;
        private System.Windows.Forms.ToolStripMenuItem TsmAjuda;
        private System.Windows.Forms.ToolStripMenuItem TsmiAjuda;
        private System.Windows.Forms.DataGridView DtgFilme;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.ComboBox CblGenero;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.Label LblClassificacao;
        private System.Windows.Forms.Label LblSinopse;
        private System.Windows.Forms.RichTextBox RtxtSinopse;
        private System.Windows.Forms.DateTimePicker DtpEstreia;
        private System.Windows.Forms.Label LblEstreia;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TslFilme;
        private System.Windows.Forms.ToolStripMenuItem TsmiCategoria;
        private System.Windows.Forms.Label LblBusca;
        private System.Windows.Forms.ComboBox CblClassificacao;
    }
}