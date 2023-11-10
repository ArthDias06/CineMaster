namespace CineMaster
{
    partial class FrmCategoria
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
            this.LblCategoria = new System.Windows.Forms.Label();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.DtgCategoria = new System.Windows.Forms.DataGridView();
            this.TsErro = new System.Windows.Forms.StatusStrip();
            this.TslCategoria = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblBusca = new System.Windows.Forms.Label();
            this.MstMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCategoria)).BeginInit();
            this.TsErro.SuspendLayout();
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
            this.TsmiIngresso.Text = "Comprar Ingresso";
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
            this.TsmiSessao.Text = "Cadastrar Sessão";
            this.TsmiSessao.Click += new System.EventHandler(this.TsmiSessao_Click);
            // 
            // TsmiCliente
            // 
            this.TsmiCliente.Name = "TsmiCliente";
            this.TsmiCliente.Size = new System.Drawing.Size(178, 22);
            this.TsmiCliente.Text = "Cadastrar Cliente";
            this.TsmiCliente.Click += new System.EventHandler(this.TsmiCliente_Click);
            // 
            // TsmiCategoria
            // 
            this.TsmiCategoria.Name = "TsmiCategoria";
            this.TsmiCategoria.Size = new System.Drawing.Size(178, 22);
            this.TsmiCategoria.Text = "Cadastrar Categoria";
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
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblCategoria.Location = new System.Drawing.Point(31, 107);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(52, 13);
            this.LblCategoria.TabIndex = 1;
            this.LblCategoria.Text = "Categoria";
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(34, 123);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(245, 20);
            this.TxtCategoria.TabIndex = 2;
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.Lime;
            this.BtnNovo.Location = new System.Drawing.Point(34, 183);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(99, 38);
            this.BtnNovo.TabIndex = 3;
            this.BtnNovo.Text = "Nova categoria";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnCancelar.Location = new System.Drawing.Point(530, 183);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(99, 38);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.Red;
            this.BtnExcluir.Location = new System.Drawing.Point(370, 183);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(99, 38);
            this.BtnExcluir.TabIndex = 5;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Yellow;
            this.BtnEditar.Location = new System.Drawing.Point(199, 183);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(99, 38);
            this.BtnEditar.TabIndex = 6;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // TxtBusca
            // 
            this.TxtBusca.Location = new System.Drawing.Point(34, 256);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(336, 20);
            this.TxtBusca.TabIndex = 8;
            this.TxtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBusca_KeyPress);
            // 
            // DtgCategoria
            // 
            this.DtgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgCategoria.Location = new System.Drawing.Point(34, 297);
            this.DtgCategoria.Name = "DtgCategoria";
            this.DtgCategoria.Size = new System.Drawing.Size(233, 150);
            this.DtgCategoria.TabIndex = 9;
            this.DtgCategoria.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgCategoria_RowHeaderMouseClick);
            // 
            // TsErro
            // 
            this.TsErro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TslCategoria});
            this.TsErro.Location = new System.Drawing.Point(0, 450);
            this.TsErro.Name = "TsErro";
            this.TsErro.Size = new System.Drawing.Size(800, 22);
            this.TsErro.TabIndex = 10;
            this.TsErro.Text = "Erro";
            // 
            // TslCategoria
            // 
            this.TslCategoria.BackColor = System.Drawing.Color.Gainsboro;
            this.TslCategoria.Name = "TslCategoria";
            this.TslCategoria.Size = new System.Drawing.Size(28, 17);
            this.TslCategoria.Text = "Erro";
            // 
            // LblBusca
            // 
            this.LblBusca.AutoSize = true;
            this.LblBusca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblBusca.Location = new System.Drawing.Point(31, 240);
            this.LblBusca.Name = "LblBusca";
            this.LblBusca.Size = new System.Drawing.Size(37, 13);
            this.LblBusca.TabIndex = 11;
            this.LblBusca.Text = "Busca";
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.LblBusca);
            this.Controls.Add(this.TsErro);
            this.Controls.Add(this.DtgCategoria);
            this.Controls.Add(this.TxtBusca);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.TxtCategoria);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.MstMenu);
            this.MainMenuStrip = this.MstMenu;
            this.Name = "FrmCategoria";
            this.Text = "FrmCategoria";
            this.MstMenu.ResumeLayout(false);
            this.MstMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCategoria)).EndInit();
            this.TsErro.ResumeLayout(false);
            this.TsErro.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem TsmiCategoria;
        private System.Windows.Forms.ToolStripMenuItem TsmAjuda;
        private System.Windows.Forms.ToolStripMenuItem TsmiAjuda;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.DataGridView DtgCategoria;
        private System.Windows.Forms.StatusStrip TsErro;
        private System.Windows.Forms.ToolStripStatusLabel TslCategoria;
        private System.Windows.Forms.Label LblBusca;
    }
}