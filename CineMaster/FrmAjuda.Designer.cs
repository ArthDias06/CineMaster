namespace CineMaster
{
    partial class FrmAjuda
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
            this.LblExibicao = new System.Windows.Forms.Label();
            this.LblExibicao2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsmTelas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiIngresso = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiFilme = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSessao = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblExibicao
            // 
            this.LblExibicao.AutoSize = true;
            this.LblExibicao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblExibicao.Location = new System.Drawing.Point(31, 40);
            this.LblExibicao.Name = "LblExibicao";
            this.LblExibicao.Size = new System.Drawing.Size(35, 13);
            this.LblExibicao.TabIndex = 0;
            this.LblExibicao.Text = "label1";
            // 
            // LblExibicao2
            // 
            this.LblExibicao2.AutoSize = true;
            this.LblExibicao2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblExibicao2.Location = new System.Drawing.Point(31, 307);
            this.LblExibicao2.Name = "LblExibicao2";
            this.LblExibicao2.Size = new System.Drawing.Size(35, 13);
            this.LblExibicao2.TabIndex = 1;
            this.LblExibicao2.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmTelas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "MstMenu";
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
            this.TsmiIngresso.Size = new System.Drawing.Size(180, 22);
            this.TsmiIngresso.Text = "Comprar Ingresso";
            this.TsmiIngresso.Click += new System.EventHandler(this.TsmiIngresso_Click);
            // 
            // TsmiFilme
            // 
            this.TsmiFilme.Name = "TsmiFilme";
            this.TsmiFilme.Size = new System.Drawing.Size(180, 22);
            this.TsmiFilme.Text = "Cadastrar Filme";
            this.TsmiFilme.Click += new System.EventHandler(this.TsmiFilme_Click);
            // 
            // TsmiSessao
            // 
            this.TsmiSessao.Name = "TsmiSessao";
            this.TsmiSessao.Size = new System.Drawing.Size(180, 22);
            this.TsmiSessao.Text = "Cadastrar Sessão";
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
            // FrmAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblExibicao2);
            this.Controls.Add(this.LblExibicao);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAjuda";
            this.Text = "Ajuda";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblExibicao;
        private System.Windows.Forms.Label LblExibicao2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmTelas;
        private System.Windows.Forms.ToolStripMenuItem TsmiIngresso;
        private System.Windows.Forms.ToolStripMenuItem TsmiFilme;
        private System.Windows.Forms.ToolStripMenuItem TsmiSessao;
        private System.Windows.Forms.ToolStripMenuItem TsmiCliente;
        private System.Windows.Forms.ToolStripMenuItem TsmiCategoria;
    }
}