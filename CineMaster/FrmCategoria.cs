using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CineMaster
{
    public partial class FrmCategoria : Form
    {
        NpgsqlConnection conexao;
        int Id_categoria = 0;

        public FrmCategoria()
        {
            InitializeComponent();
            conexao = new NpgsqlConnection(connectionString: "Server=localhost; " +
                "Port=5432; " +
                "User ID=postgres; " +
                "Password=postgres; " +
                "Database=postgres; " +
                "Pooling=true;");
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Preenchimento(null);
            BtnEditar.Visible = false;
            BtnExcluir.Visible = false;
            BtnCancelar.Visible = false;
            BtnNovo.Visible = true;
        }
        private void Preenchimento(string comando)
        {
            string query = comando != null ? comando : "SELECT * FROM tbl_categoria ORDER BY id_categoria;";
            try
            {
                conexao.Open();
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        DtgCategoria.DataSource = dt;
                    }
                }
                conexao.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslCategoria.Text = ex.Message;
                conexao.Close();
            }
        }

        private void TsmiIngresso_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmprincipal = new FrmPrincipal();
            frmprincipal.ShowDialog();
        }

        private void TsmiFilme_Click(object sender, EventArgs e)
        {
            FrmFilme frmfilme = new FrmFilme();
            frmfilme.ShowDialog();
        }

        private void TsmiSessao_Click(object sender, EventArgs e)
        {
            FrmSessao frmsessao = new FrmSessao();
            frmsessao.ShowDialog();
        }

        private void TsmiCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmcliente = new FrmCliente();
            frmcliente.ShowDialog();
        }

        private void TsmiAjuda_Click(object sender, EventArgs e)
        {
            FrmAjuda frmajuda = new FrmAjuda();
            frmajuda.ShowDialog();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCategoria.Text))
            {
                try
                {
                    string nome = this.TxtCategoria.Text;
                    string query = "INSERT INTO tbl_categoria(categoria) " +
                    $"VALUES('{nome}');";
                    conexao.Query(sql: query);
                    MessageBox.Show("Categoria cadastrada com sucesso!");
                    LimpaCampos();
                    Preenchimento(null);
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    TslCategoria.Text = ex.Message;
                }
            }
            else
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!!");
                if (string.IsNullOrEmpty(TxtCategoria.Text))
                    LblCategoria.Font = new Font(this.Font, FontStyle.Bold);
            }
        }
        private void LimpaCampos()
        {
            TxtCategoria.ResetText();
        }


        public void Limpar()
        {
            BtnEditar.Visible = false;
            BtnExcluir.Visible = false;
            BtnCancelar.Visible = false;
            BtnNovo.Visible = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = TxtCategoria.Text;

                var update = $"UPDATE tbl_categoria SET categoria = '{nome}'" +
                    $"WHERE id_categoria = {this.Id_categoria}";
                conexao.Query(sql: update);
                MessageBox.Show("Dados atualizados com sucesso!!!");
                LimpaCampos();
                Limpar();
                Preenchimento(null);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslCategoria.Text = ex.Message;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var delete = $"DELETE FROM tbl_categoria WHERE id_categoria = {this.Id_categoria}";
                conexao.Query(sql: delete);
                MessageBox.Show("Categoria deletada com sucesso!");
                LimpaCampos();
                Limpar();
                Preenchimento(null);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslCategoria.Text = ex.Message;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            Limpar();
            Preenchimento(null);
        }

        private void DtgCategoria_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.Id_categoria = (int)DtgCategoria.SelectedRows[0].Cells[0].Value;

                var nomeCategoria = DtgCategoria.SelectedRows[0].Cells[1].Value;

                TxtCategoria.Text = nomeCategoria.ToString();

                BtnEditar.Visible = true;
                BtnExcluir.Visible = true;
                BtnCancelar.Visible = true;
                BtnNovo.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslCategoria.Text = ex.Message;
            }
        }

        private void TxtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                string query = $"SELECT * FROM tbl_categoria WHERE categoria LIKE '%{TxtBusca.Text}%'";
                Preenchimento(query);
            }
        }
    }
}
