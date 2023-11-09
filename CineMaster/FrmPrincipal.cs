using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Npgsql;

namespace CineMaster
{
    public partial class FrmPrincipal : Form
    {
        NpgsqlConnection conexao;
        int Id_ingresso = 0;
        int Id_sessao = 0;
        int Id_cliente = 0;
        int Id_filme = 0;
        public FrmPrincipal()
        {
            InitializeComponent();
            conexao = new NpgsqlConnection(connectionString:"Server=localhost;" +
                "Port=5432; " +
                "User ID=postgres; " +
                "Password=postgres; " +
                "Database=postgres; " +
                "Pooling=true;");
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Preenchimento(null);
            CarregarComboBox();
            BtnEditar.Visible = false;
            BtnExcluir.Visible = false;
            BtnCancelar.Visible = false;
            BtnNovo.Visible = true;
        }

        private void Preenchimento(string comando)
        {
            string query = comando != null ? comando : "SELECT i.id_ingresso, f.id_filme, s.id_sessao, cl.id_cliente, f.titulo, " +
                "cl.nome_cliente, cl.tipo_cliente, s.num_sala, s.horario_sessao, i.preco FROM tbl_ingresso AS i INNER JOIN " +
                "tbl_filme AS f ON i.filme = f.id_filme INNER JOIN tbl_sessao AS s ON i.fk_sessao=s.id_sessao " +
                "INNER JOIN tbl_cliente as cl ON i.fk_id_cliente=cl.id_cliente ORDER BY i.id_ingresso;";
            try
            {
                conexao.Open();
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        DtgPrincipal.DataSource = dt;
                    }
                }
                conexao.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslPrincipal.Text = ex.Message;
                conexao.Close();
            }
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

        private void TsmiCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria frmcategoria = new FrmCategoria();
            frmcategoria.ShowDialog();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CblCliente.Text) &&
                !string.IsNullOrEmpty(CblFilme.Text) &&
                !string.IsNullOrEmpty(CblHorario.Text) &&
                !string.IsNullOrEmpty(CblSala.Text))
            {
                    try
                    {
                        int filme = this.Id_filme;
                        int cliente = this.Id_cliente;
                        int sessao = this.Id_sessao;
                        double preco = Convert.ToDouble(this.TxtPreco.Text, CultureInfo.InvariantCulture);
                        string query = "INSERT INTO tbl_ingresso(fk_id_cliente, fk_sessao, filme, preco) " +
               "VALUES(@cliente, @sessao, @filme, @preco);";

                        var parameters = new
                        {
                            cliente = cliente,
                            sessao = sessao,
                            filme = filme,
                            preco = preco
                        };

                        conexao.Query(sql: query, param: parameters);
                        MessageBox.Show("Nova compra adicionada com sucesso!");
                        LimpaCampos();
                        Preenchimento(null);
                        CarregarComboBox();
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                        TslPrincipal.Text = ex.Message;
                    }
                }
            else
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!!");
                if (string.IsNullOrEmpty(CblCliente.Text))
                    LblCliente.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(CblFilme.Text))
                    LblFilme.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(CblHorario.Text))
                    LblSessao.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(CblSala.Text))
                    LblSala.Font = new Font(this.Font, FontStyle.Bold);
            }
        }
        private void LimpaCampos()
        {
            CblCliente.Items.Clear();
            CblCliente.ResetText();
            TxtPreco.ResetText();
            CblFilme.Items.Clear();
            CblFilme.ResetText();
            CblSala.Items.Clear();
            CblSala.ResetText();
            CblHorario.Items.Clear();
            CblHorario.ResetText();
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
                int cliente = Id_cliente;
                int sessao = Id_sessao;
                int filme = Id_filme;
                double preco = Convert.ToDouble(TxtPreco.Text);

                var update = $"UPDATE tbl_ingresso SET fk_id_cliente = {cliente}, fk_sessao = {sessao}, filme = {filme}," +
                    $"preco = {preco} " +
                    $"WHERE id_ingresso={this.Id_ingresso}";
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
                TslPrincipal.Text = ex.Message;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var delete = $"DELETE FROM tbl_ingresso WHERE id_ingresso={this.Id_ingresso};";
                conexao.Query(sql: delete);
                MessageBox.Show("Compra deletada com sucesso!");
                LimpaCampos();
                Limpar();
                Preenchimento(null);
                CarregarComboBox();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslPrincipal.Text = ex.Message;
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
                var query = "SELECT nome_cliente FROM tbl_cliente;";
                var query2 = "SELECT titulo FROM tbl_filme;";
                var listCliente = conexao.Query<Tbl_cliente>(sql: query);
                var listFilme = conexao.Query<Tbl_filme>(sql: query2);
                foreach (var cliente in listCliente) CblCliente.Items.Add(cliente.Nome_cliente);
                foreach (var filme in listFilme) CblFilme.Items.Add(filme.Titulo);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslPrincipal.Text = ex.Message;
            }
        }

        private void CblCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var query = $"SELECT id_cliente FROM tbl_cliente WHERE nome_cliente = '{CblCliente.Text}';";
                dynamic resultado = conexao.Query<Tbl_cliente>(sql: query);

                this.Id_cliente = resultado[0].Id_cliente;
                PrecoCliente();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslPrincipal.Text = ex.Message;
            }
        }
        private void PrecoCliente()
        {
            var query = $"SELECT tipo_cliente FROM tbl_cliente WHERE id_cliente={this.Id_cliente};";
            dynamic tipo2 = conexao.Query<Tbl_cliente>(sql: query);
            if (tipo2[0].Tipo_cliente == "Comum")
            {
                TxtPreco.Text = "18.50";
            }
            else
            {
                TxtPreco.Text = "9.25";
            }
        }

        private void CblFilme_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var query = $"SELECT id_filme FROM tbl_filme WHERE titulo = '{CblFilme.Text}';";
                dynamic resultado = conexao.Query<Tbl_filme>(sql: query);

                this.Id_filme = resultado[0].Id_filme;
                CarregarComboBoxSessao();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslPrincipal.Text = ex.Message;
            }
        }
        private void CarregarComboBoxSessao()
        {
            try
            {
                CblHorario.ResetText();
                CblHorario.Items.Clear();
                CblSala.ResetText();
                CblSala.Items.Clear();
                var query = "SELECT s.horario_sessao FROM tbl_sessao AS s INNER JOIN tbl_filme AS f ON" +
                    $" s.filme=f.id_filme WHERE s.filme='{this.Id_filme}';";
                var query2 = "SELECT num_sala FROM tbl_sessao AS s INNER JOIN tbl_filme AS f ON " +
                    $"s.filme=f.id_filme WHERE s.filme='{this.Id_filme}';";
                var listHorario = conexao.Query<Tbl_sessao>(sql: query);
                var listSala = conexao.Query<Tbl_sessao>(sql: query2);
                foreach (var hora in listHorario) CblHorario.Items.Add(hora.Horario_sessao.ToString());
                foreach (var sala in listSala) CblSala.Items.Add(sala.Num_sala);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslPrincipal.Text = ex.Message;
            }
        }

        private void CblHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var query = $"SELECT id_sessao FROM tbl_sessao WHERE horario_sessao = '{CblHorario.Text}';";
                dynamic resultado = conexao.Query<Tbl_sessao>(sql: query);

                this.Id_sessao = resultado[0].Id_sessao;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslPrincipal.Text = ex.Message;
            }
        }

        private void CblSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var query = $"SELECT id_sessao FROM tbl_sessao WHERE num_sala = '{CblSala.Text}';";
                dynamic resultado = conexao.Query<Tbl_sessao>(sql: query);

                this.Id_sessao = resultado[0].Id_sessao;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslPrincipal.Text = ex.Message;
            }
        }

        private void TxtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string query = $"SELECT i.id_ingresso, f.id_filme, s.id_sessao, cl.id_cliente, f.titulo, " +
                "cl.nome_cliente, s.num_sala, s.horario_sessao, cl.tipo_cliente, i.preco FROM tbl_ingresso AS i INNER JOIN " +
                "tbl_filme AS f ON i.filme = f.id_filme INNER JOIN tbl_sessao AS s ON i.fk_sessao=s.id_sessao " +
                "INNER JOIN tbl_cliente as cl ON i.fk_id_cliente=cl.id_cliente " +
                $"WHERE cl.nome_cliente LIKE '%{TxtBusca.Text}%' or f.titulo LIKE '%{TxtBusca.Text}%' ORDER BY i.id_ingresso;";
                Preenchimento(query);
                CarregarComboBox();
            }
        }

        private void DtgPrincipal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.Id_filme = (int)DtgPrincipal.SelectedRows[0].Cells[0].Value;

                this.Id_sessao = (int)DtgPrincipal.SelectedRows[0].Cells[1].Value;
                this.Id_cliente = (int)DtgPrincipal.SelectedRows[0].Cells[2].Value;
                var tituloFilme = DtgPrincipal.SelectedRows[0].Cells[3].Value;
                var nomeCliente = DtgPrincipal.SelectedRows[0].Cells[4].Value;
                var tipoCliente = DtgPrincipal.SelectedRows[0].Cells[5].Value;
                var numSala = DtgPrincipal.SelectedRows[0].Cells[6].Value;
                var horario = DtgPrincipal.SelectedRows[0].Cells[7].Value;
                var Preco = DtgPrincipal.SelectedRows[0].Cells[8].Value;

                CblFilme.Text = tituloFilme.ToString();
                CblCliente.Text = nomeCliente.ToString();

                CblHorario.Text = horario.ToString();
                CblSala.Text = numSala.ToString();
                var query = $"SELECT tipo_cliente FROM tbl_cliente WHERE id_cliente={this.Id_cliente};";
                dynamic tipo2 = conexao.Query<Tbl_cliente>(sql: query);
                if (tipo2[0].Tipo_cliente == "Comum")
                {
                    TxtPreco.Text = "18.50";
                }
                else
                {
                    TxtPreco.Text = "9.25";
                }

                BtnEditar.Visible = true;
                BtnExcluir.Visible = true;
                BtnCancelar.Visible = true;
                BtnNovo.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslPrincipal.Text = ex.Message;
            }
        }
    }
}
