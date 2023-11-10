namespace CineMaster
{
    partial class FrmSessao
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
            this.MstTelas = new System.Windows.Forms.MenuStrip();
            this.TsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiIngresso = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiFilme = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSessao = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.StsErro = new System.Windows.Forms.StatusStrip();
            this.TslSessao = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblNomeFilme = new System.Windows.Forms.Label();
            this.LblSala = new System.Windows.Forms.Label();
            this.LblHorarrio = new System.Windows.Forms.Label();
            this.DtpHorario = new System.Windows.Forms.DateTimePicker();
            this.TxtSala = new System.Windows.Forms.TextBox();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.DtgSessao = new System.Windows.Forms.DataGridView();
            this.CblFilme = new System.Windows.Forms.ComboBox();
            this.LblBusca = new System.Windows.Forms.Label();
            this.MstTelas.SuspendLayout();
            this.StsErro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgSessao)).BeginInit();
            this.SuspendLayout();
            // 
            // MstTelas
            // 
            this.MstTelas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmMenu,
            this.TsmAjuda});
            this.MstTelas.Location = new System.Drawing.Point(0, 0);
            this.MstTelas.Name = "MstTelas";
            this.MstTelas.Size = new System.Drawing.Size(800, 24);
            this.MstTelas.TabIndex = 0;
            this.MstTelas.Text = "Menu";
            // 
            // TsmMenu
            // 
            this.TsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiIngresso,
            this.TsmiFilme,
            this.TsmiSessao,
            this.TsmiCliente,
            this.TsmiCategoria});
            this.TsmMenu.Name = "TsmMenu";
            this.TsmMenu.Size = new System.Drawing.Size(50, 20);
            this.TsmMenu.Text = "Menu";
            // 
            // TsmiIngresso
            // 
            this.TsmiIngresso.Name = "TsmiIngresso";
            this.TsmiIngresso.Size = new System.Drawing.Size(183, 22);
            this.TsmiIngresso.Text = "Comprar Ingresso";
            this.TsmiIngresso.Click += new System.EventHandler(this.TsmiIngresso_Click);
            // 
            // TsmiFilme
            // 
            this.TsmiFilme.Name = "TsmiFilme";
            this.TsmiFilme.Size = new System.Drawing.Size(183, 22);
            this.TsmiFilme.Text = "Cadastrar FIlmes";
            this.TsmiFilme.Click += new System.EventHandler(this.TsmiFilme_Click);
            // 
            // TsmiSessao
            // 
            this.TsmiSessao.Name = "TsmiSessao";
            this.TsmiSessao.Size = new System.Drawing.Size(183, 22);
            this.TsmiSessao.Text = "Cadastrar Sessões";
            this.TsmiSessao.Click += new System.EventHandler(this.TsmiSessao_Click);
            // 
            // TsmiCliente
            // 
            this.TsmiCliente.Name = "TsmiCliente";
            this.TsmiCliente.Size = new System.Drawing.Size(183, 22);
            this.TsmiCliente.Text = "Cadastrar Clientes";
            this.TsmiCliente.Click += new System.EventHandler(this.TsmiCliente_Click);
            // 
            // TsmiCategoria
            // 
            this.TsmiCategoria.Name = "TsmiCategoria";
            this.TsmiCategoria.Size = new System.Drawing.Size(183, 22);
            this.TsmiCategoria.Text = "Cadastrar Categorias";
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
            this.TsmiAjuda.Size = new System.Drawing.Size(107, 22);
            this.TsmiAjuda.Text = "AJuda";
            this.TsmiAjuda.Click += new System.EventHandler(this.TsmiAjuda_Click);
            // 
            // StsErro
            // 
            this.StsErro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TslSessao});
            this.StsErro.Location = new System.Drawing.Point(0, 428);
            this.StsErro.Name = "StsErro";
            this.StsErro.Size = new System.Drawing.Size(800, 22);
            this.StsErro.TabIndex = 0;
            this.StsErro.Text = "TslSessao";
            // 
            // TslSessao
            // 
            this.TslSessao.BackColor = System.Drawing.Color.Gainsboro;
            this.TslSessao.Name = "TslSessao";
            this.TslSessao.Size = new System.Drawing.Size(28, 17);
            this.TslSessao.Text = "Erro";
            // 
            // LblNomeFilme
            // 
            this.LblNomeFilme.AutoSize = true;
            this.LblNomeFilme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNomeFilme.Location = new System.Drawing.Point(22, 48);
            this.LblNomeFilme.Name = "LblNomeFilme";
            this.LblNomeFilme.Size = new System.Drawing.Size(31, 13);
            this.LblNomeFilme.TabIndex = 2;
            this.LblNomeFilme.Text = "Filme";
            // 
            // LblSala
            // 
            this.LblSala.AutoSize = true;
            this.LblSala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblSala.Location = new System.Drawing.Point(581, 48);
            this.LblSala.Name = "LblSala";
            this.LblSala.Size = new System.Drawing.Size(81, 13);
            this.LblSala.TabIndex = 3;
            this.LblSala.Text = "Número da sala";
            // 
            // LblHorarrio
            // 
            this.LblHorarrio.AutoSize = true;
            this.LblHorarrio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblHorarrio.Location = new System.Drawing.Point(271, 48);
            this.LblHorarrio.Name = "LblHorarrio";
            this.LblHorarrio.Size = new System.Drawing.Size(92, 13);
            this.LblHorarrio.TabIndex = 4;
            this.LblHorarrio.Text = "Horário da sessão";
            // 
            // DtpHorario
            // 
            this.DtpHorario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpHorario.Location = new System.Drawing.Point(274, 66);
            this.DtpHorario.Name = "DtpHorario";
            this.DtpHorario.Size = new System.Drawing.Size(248, 20);
            this.DtpHorario.TabIndex = 5;
            // 
            // TxtSala
            // 
            this.TxtSala.Location = new System.Drawing.Point(584, 69);
            this.TxtSala.Name = "TxtSala";
            this.TxtSala.Size = new System.Drawing.Size(124, 20);
            this.TxtSala.TabIndex = 6;
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.Lime;
            this.BtnNovo.Location = new System.Drawing.Point(22, 137);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(99, 36);
            this.BtnNovo.TabIndex = 7;
            this.BtnNovo.Text = "Nova Sessão";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnCancelar.Location = new System.Drawing.Point(495, 137);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(99, 36);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.Red;
            this.BtnExcluir.Location = new System.Drawing.Point(340, 137);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(99, 36);
            this.BtnExcluir.TabIndex = 9;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Yellow;
            this.BtnEditar.Location = new System.Drawing.Point(177, 137);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(99, 36);
            this.BtnEditar.TabIndex = 10;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // TxtBusca
            // 
            this.TxtBusca.Location = new System.Drawing.Point(22, 219);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(417, 20);
            this.TxtBusca.TabIndex = 11;
            this.TxtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBusca_KeyPress);
            // 
            // DtgSessao
            // 
            this.DtgSessao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgSessao.Location = new System.Drawing.Point(22, 261);
            this.DtgSessao.Name = "DtgSessao";
            this.DtgSessao.Size = new System.Drawing.Size(572, 150);
            this.DtgSessao.TabIndex = 12;
            this.DtgSessao.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgSessao_RowHeaderMouseClick);
            // 
            // CblFilme
            // 
            this.CblFilme.FormattingEnabled = true;
            this.CblFilme.Location = new System.Drawing.Point(25, 67);
            this.CblFilme.Name = "CblFilme";
            this.CblFilme.Size = new System.Drawing.Size(221, 21);
            this.CblFilme.TabIndex = 13;
            this.CblFilme.SelectedIndexChanged += new System.EventHandler(this.CblFilme_SelectedIndexChanged);
            // 
            // LblBusca
            // 
            this.LblBusca.AutoSize = true;
            this.LblBusca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblBusca.Location = new System.Drawing.Point(19, 203);
            this.LblBusca.Name = "LblBusca";
            this.LblBusca.Size = new System.Drawing.Size(37, 13);
            this.LblBusca.TabIndex = 14;
            this.LblBusca.Text = "Busca";
            // 
            // FrmSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblBusca);
            this.Controls.Add(this.StsErro);
            this.Controls.Add(this.CblFilme);
            this.Controls.Add(this.DtgSessao);
            this.Controls.Add(this.TxtBusca);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.TxtSala);
            this.Controls.Add(this.DtpHorario);
            this.Controls.Add(this.LblHorarrio);
            this.Controls.Add(this.LblSala);
            this.Controls.Add(this.LblNomeFilme);
            this.Controls.Add(this.MstTelas);
            this.MainMenuStrip = this.MstTelas;
            this.Name = "FrmSessao";
            this.Text = "Cadastro de sessão";
            this.MstTelas.ResumeLayout(false);
            this.MstTelas.PerformLayout();
            this.StsErro.ResumeLayout(false);
            this.StsErro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgSessao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MstTelas;
        private System.Windows.Forms.ToolStripMenuItem TsmMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmiIngresso;
        private System.Windows.Forms.ToolStripMenuItem TsmiFilme;
        private System.Windows.Forms.ToolStripMenuItem TsmiSessao;
        private System.Windows.Forms.ToolStripMenuItem TsmiCliente;
        private System.Windows.Forms.ToolStripMenuItem TsmiCategoria;
        private System.Windows.Forms.ToolStripMenuItem TsmAjuda;
        private System.Windows.Forms.ToolStripMenuItem TsmiAjuda;
        private System.Windows.Forms.StatusStrip StsErro;
        private System.Windows.Forms.ToolStripStatusLabel TslSessao;
        private System.Windows.Forms.Label LblNomeFilme;
        private System.Windows.Forms.Label LblSala;
        private System.Windows.Forms.Label LblHorarrio;
        private System.Windows.Forms.DateTimePicker DtpHorario;
        private System.Windows.Forms.TextBox TxtSala;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.DataGridView DtgSessao;
        private System.Windows.Forms.ComboBox CblFilme;
        private System.Windows.Forms.Label LblBusca;
    }
}