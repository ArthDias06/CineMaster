using Npgsql;
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

namespace CineMaster
{
    public partial class FrmSessao : Form
    {
        NpgsqlConnection conexao;
        int Id_sessao = 0;
        int Id_filme = 0;
        public FrmSessao()
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
            DtpHorario.CustomFormat = "HH:mm:ss";
            Preenchimento(null);
            CarregarComboBox();
            BtnEditar.Visible = false;
            BtnExcluir.Visible = false;
            BtnCancelar.Visible = false;
            BtnNovo.Visible = true;
        }

        private void Preenchimento(string comando)
        {
            string query = comando != null ? comando : "SELECT s.id_sessao, f.titulo, " +
                "s.horario_sessao, s.num_sala FROM tbl_sessao AS s INNER JOIN " +
                "tbl_filme AS f ON s.filme = f.id_filme ORDER BY id_sessao;";
            try
            {
                conexao.Open();
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        DtgSessao.DataSource = dt;
                    }
                }
                conexao.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslSessao.Text = ex.Message;
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

        private void TsmiCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria frmcategoria = new FrmCategoria();
            frmcategoria.ShowDialog();
        }

        private void TsmiAjuda_Click(object sender, EventArgs e)
        {
            FrmAjuda frmajuda = new FrmAjuda();
            frmajuda.ShowDialog();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CblFilme.Text) &&
                !string.IsNullOrEmpty(TxtSala.Text))
            {
                try
                {
                    int filme = Id_filme;
                    string sala = this.TxtSala.Text;
                    var hour = DtpHorario.Value.Hour;
                    var minute = DtpHorario.Value.Minute;
                    var second = DtpHorario.Value.Second;
                    string Horario = hour + ":" + minute + ":" + second;
                    string query = "INSERT INTO tbl_sessao(filme, horario_sessao, num_sala)" +
                                      $"VALUES({filme},'{Horario}',{sala});";
                    conexao.Query(sql: query);
                    MessageBox.Show("Nova sessão adicionado com sucesso!");
                    LimpaCampos();
                    Preenchimento(null);
                    CarregarComboBox();
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    TslSessao.Text = ex.Message;
                }
            }
            else
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!!");
                if (string.IsNullOrEmpty(CblFilme.Text))
                    LblNomeFilme.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(TxtSala.Text))
                    LblSala.Font = new Font(this.Font, FontStyle.Bold);
            }
        }
        private void LimpaCampos()
        {
            CblFilme.Items.Clear();
            CblFilme.ResetText();
            TxtSala.ResetText();
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
                int filme = Id_filme;
                string sala = TxtSala.Text;
                var hour = DtpHorario.Value.Hour;
                var minute = DtpHorario.Value.Minute;
                var second = DtpHorario.Value.Second;
                string Horario = hour + ":" + minute + ":" + second;

                var update = $"UPDATE tbl_sessao SET filme = {filme}, horario_sessao='{Horario}', num_sala={sala} " +
                    $"WHERE id_sessao = {this.Id_sessao}";
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
                TslSessao.Text = ex.Message;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var delete = $"DELETE FROM tbl_sessao WHERE id_sessao = {this.Id_sessao}";
                conexao.Query(sql: delete);
                MessageBox.Show("Sessão deletada com sucesso!");
                LimpaCampos();
                Limpar();
                Preenchimento(null);
                CarregarComboBox();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslSessao.Text = ex.Message;
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
                var query = "SELECT titulo FROM tbl_filme;";
                var listFilme = conexao.Query<Tbl_filme>(sql: query);
                foreach (var titulo in listFilme) CblFilme.Items.Add(titulo.Titulo);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslSessao.Text = ex.Message;
            }
        }

        private void CblFilme_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var query = $"SELECT id_filme FROM tbl_filme WHERE titulo = '{CblFilme.Text}';";
                dynamic resultado = conexao.Query<Tbl_filme>(sql: query);

                this.Id_filme = resultado[0].Id_filme;

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslSessao.Text = ex.Message;
            }
        }

        private void TxtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string query = $"SELECT s.id_sessao, f.titulo, s.horario_sessao, " +
                    $"s.num_sala FROM tbl_sessao AS s INNER JOIN " +
                    $"tbl_filme AS f ON s.filme = f.id_filme " +
                    $"WHERE f.titulo LIKE '%{TxtBusca.Text}%' ORDER BY id_sessao";
                Preenchimento(query);
                CarregarComboBox();
            }
        }

        private void DtgSessao_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.Id_sessao = (int)DtgSessao.SelectedRows[0].Cells[0].Value;

                var nomeFilme = DtgSessao.SelectedRows[0].Cells[1].Value;
                var horarioSessao = DtgSessao.SelectedRows[0].Cells[2].Value;
                var salaSessao = DtgSessao.SelectedRows[0].Cells[3].Value;

                var horario = horarioSessao.ToString().Split(':');

                int h = int.Parse(horario[0]);
                int m = int.Parse(horario[1]);
                int s = int.Parse(horario[2]);
                

                DtpHorario.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, h, m, s);


                CblFilme.Text = nomeFilme.ToString();
                TxtSala.Text = salaSessao.ToString();

                BtnEditar.Visible = true;
                BtnExcluir.Visible = true;
                BtnCancelar.Visible = true;
                BtnNovo.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslSessao.Text = ex.Message;
            }
        }

    }
}
