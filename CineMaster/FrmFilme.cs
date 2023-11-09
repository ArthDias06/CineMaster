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

namespace CineMaster
{
    public partial class FrmFilme : Form
    {
        NpgsqlConnection conexao;
        int Id_filme = 0;
        int Id_categoria = 0;
        public FrmFilme()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            conexao = new NpgsqlConnection(connectionString: "Server=localhost; " +
               "Port=5432; " +
               "User ID=postgres; " +
               "Password=postgres; " +
               "Database=postgres; " +
               "Pooling=true;");
            Preenchimento(null);
            CarregarComboBox();
            BtnEditar.Visible = false;
            BtnExcluir.Visible = false;
            BtnCancelar.Visible = false;
            BtnNovo.Visible = true;
        }

        private void Preenchimento(string comando)
        {
            string query = comando != null ? comando : "SELECT f.id_filme, f.titulo, c.categoria," +
                "f.classificacao, f.sinopse, f.data_lancamento FROM tbl_filme AS f INNER JOIN " +
                "tbl_categoria AS c ON f.categoria = c.id_categoria ORDER BY id_filme;";
            try
            {
                conexao.Open();
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        DtgFilme.DataSource = dt;
                    }
                }
                conexao.Close();
            }catch(NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslFilme.Text = ex.Message;
                conexao.Close();
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNome.Text) &&
                !string.IsNullOrEmpty(TxtClassificacao.Text) &&
                !string.IsNullOrEmpty(CblGenero.Text) &&
                !string.IsNullOrEmpty(RtxtSinopse.Text))
            {
                try
                {
                    string filme = this.TxtNome.Text;
                    int genero = Id_categoria;
                    string classificacao = this.TxtClassificacao.Text;
                    string sinopse = this.RtxtSinopse.Text;
                    var day = DtpEstreia.Value.Day;
                    var month = DtpEstreia.Value.Month;
                    var year = DtpEstreia.Value.Year;
                    string dataEstreia = year + "/" + month + "/" + day;
                    string query = "INSERT INTO tbl_filme(titulo, categoria, classificacao, sinopse, data_lancamento)" +
                                      $"VALUES('{filme}',{genero},'{classificacao}','{sinopse}','{dataEstreia}');";
                    conexao.Query(sql: query);
                    MessageBox.Show("Novo filme adicionado com sucesso!");
                    LimpaCampos();
                    Preenchimento(null);
                    CarregarComboBox();
                }
                catch(NpgsqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    TslFilme.Text = ex.Message;
                }
            }
            else
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!!");
                if (string.IsNullOrEmpty(TxtNome.Text))
                    LblNome.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(CblGenero.Text))
                    LblGenero.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(TxtClassificacao.Text))
                    LblClassificacao.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(RtxtSinopse.Text))
                    LblSinopse.Font = new Font(this.Font, FontStyle.Bold);
            }
        }

        private void LimpaCampos()
        {
            TxtNome.ResetText();
            CblGenero.Items.Clear();
            CblGenero.ResetText();
            TxtClassificacao.ResetText();
            RtxtSinopse.ResetText();
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
                string nome = TxtNome.Text;
                int genero = Id_categoria;
                string classificacao = TxtClassificacao.Text;
                string sinopse = RtxtSinopse.Text;
                var day = DtpEstreia.Value.Day;
                var month = DtpEstreia.Value.Month;
                var year = DtpEstreia.Value.Year;
                string dataEstreia = year + "/" + month + "/" + day;

                var update = $"UPDATE tbl_filme SET titulo = '{nome}', categoria = {genero}, classificacao = '{classificacao}'," +
                    $"sinopse = '{sinopse}', data_lancamento='{dataEstreia}'" +
                    $"WHERE id_filme = {this.Id_filme}";
                conexao.Query(sql: update);
                MessageBox.Show("Dados atualizados com sucesso!!!");
                LimpaCampos();
                Limpar();
                Preenchimento(null);
                CarregarComboBox();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslFilme.Text = ex.Message;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var delete = $"DELETE FROM tbl_filme WHERE id_filme = {this.Id_filme}";
                conexao.Query(sql: delete);
                MessageBox.Show("Filme deletado com sucesso!");
                LimpaCampos();
                Limpar();
                Preenchimento(null);
                CarregarComboBox();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslFilme.Text = ex.Message;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            Limpar();
            Preenchimento(null);
            CarregarComboBox();
        }
        private void CarregarComboBox()
        {
            try
            {
                var query = "SELECT categoria FROM tbl_categoria;";
                var listCategoria = conexao.Query<Tbl_categoria>(sql: query);
                foreach (var categoria in listCategoria) CblGenero.Items.Add(categoria.Categoria);
            }catch(NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslFilme.Text = ex.Message;
            }
        }



        private void TsmiIngresso_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmprincipal = new FrmPrincipal();
            frmprincipal.ShowDialog();
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

        private void CblGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var query = $"SELECT id_categoria FROM tbl_categoria WHERE categoria = '{CblGenero.Text}';";
                dynamic resultado = conexao.Query<Tbl_categoria>(sql: query);

                this.Id_categoria = resultado[0].Id_categoria;

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslFilme.Text = ex.Message;
            }
        }

        private void DtgFilme_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.Id_filme = (int)DtgFilme.SelectedRows[0].Cells[0].Value;

                var nomeFilme = DtgFilme.SelectedRows[0].Cells[1].Value;
                var generoFilme = DtgFilme.SelectedRows[0].Cells[2].Value;
                var classificacaoFilme = DtgFilme.SelectedRows[0].Cells[3].Value;
                var sinopseFilme = DtgFilme.SelectedRows[0].Cells[4].Value;
                var dataFilme = DtgFilme.SelectedRows[0].Cells[5].Value;

                var data = dataFilme.ToString().Split('/');
                int d = int.Parse(data[0]);
                int m = int.Parse(data[1]);
                int Y = int.Parse(data[2].Split(' ')[0]);

                DtpEstreia.Value = new DateTime(Y, m, d);

                TxtNome.Text = nomeFilme.ToString();
                CblGenero.Text = generoFilme.ToString();

                TxtClassificacao.Text = classificacaoFilme.ToString();
                RtxtSinopse.Text = sinopseFilme.ToString();

                BtnEditar.Visible = true;
                BtnExcluir.Visible = true;
                BtnCancelar.Visible = true;
                BtnNovo.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslFilme.Text = ex.Message;
            }
        }

        private void TsmiCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria frmcategoria = new FrmCategoria();
            frmcategoria.ShowDialog();
        }

        private void TxtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                string query = $"SELECT f.id_filme, f.titulo, c.categoria, " +
                    $"f.classificacao, f.sinopse, f.data_lancamento FROM tbl_filme AS f INNER JOIN " +
                    $"tbl_categoria AS c ON f.categoria = c.id_categoria " +
                    $"WHERE titulo LIKE '%{TxtBusca.Text}%' ORDER BY id_filme";
                Preenchimento(query);
            }
        }
    }
}
