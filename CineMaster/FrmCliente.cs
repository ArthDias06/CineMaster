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
    public partial class FrmCliente : Form
    {
        NpgsqlConnection conexao;
        int Id_cliente=0;
        public FrmCliente()
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
            string query = comando != null ? comando : "SELECT * FROM tbl_cliente ORDER BY id_cliente;";
            try
            {
                conexao.Open();
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        DtgCliente.DataSource = dt;
                    }
                }
                conexao.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslCliente.Text = ex.Message;
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

        private void TsmiAjuda_Click(object sender, EventArgs e)
        {
            FrmAjuda frmajuda = new FrmAjuda();
            frmajuda.ShowDialog();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtClienteNome.Text) &&
                !string.IsNullOrEmpty(TxtEmail.Text) &&
                !string.IsNullOrEmpty(TxtSenha.Text) &&
                !string.IsNullOrEmpty(TxtTelefone.Text) &&
                !string.IsNullOrEmpty(TxtCpf.Text))
            {
                try
                {
                    string nome = this.TxtClienteNome.Text;
                    string email = this.TxtEmail.Text;
                    string senha = this.TxtSenha.Text;
                    string telefone = this.TxtTelefone.Text;
                    string cpf = this.TxtCpf.Text;
                    var day = DtpNascimento.Value.Day;
                    var month = DtpNascimento.Value.Month;
                    var year = DtpNascimento.Value.Year;
                    string dataNascimento = year + "/" + month + "/" + day;
                    string query = "INSERT INTO tbl_cliente(nome_cliente, email, senha, telefone, cpf, data_nascimento)" +
                                      $"VALUES('{nome}','{email}','{senha}','{telefone}','{cpf}','{dataNascimento}');";
                    conexao.Query(sql: query);
                    MessageBox.Show("Obrigado por adentrar na maior rede de cinemas do cti!");
                    LimpaCampos();
                    Preenchimento(null);
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    TslCliente.Text = ex.Message;
                }
            }
            else
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!!");
                if (string.IsNullOrEmpty(TxtClienteNome.Text))
                    LblClienteNome.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(TxtEmail.Text))
                    LblEmail.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(TxtSenha.Text))
                    LblSenha.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(TxtTelefone.Text))
                    LblTelefone.Font = new Font(this.Font, FontStyle.Bold);
                if (string.IsNullOrEmpty(TxtCpf.Text))
                    LblCpf.Font = new Font(this.Font, FontStyle.Bold);
            }
        }

        private void LimpaCampos()
        {
            TxtClienteNome.ResetText();
            TxtEmail.ResetText();
            TxtSenha.ResetText();
            TxtTelefone.ResetText();
            TxtCpf.ResetText();
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
                string nome = TxtClienteNome.Text;
                string email = TxtEmail.Text;
                string senha = TxtSenha.Text;
                string telefone = TxtTelefone.Text;
                string cpf = TxtCpf.Text;
                var day = DtpNascimento.Value.Day;
                var month = DtpNascimento.Value.Month;
                var year = DtpNascimento.Value.Year;
                string dataNascimento = year + "/" + month + "/" + day;

                var update = $"UPDATE tbl_cliente SET nome_cliente = '{nome}', email = '{email}', senha = '{senha}'," +
                    $"telefone = '{telefone}', cpf = '{cpf}',  data_nascimento='{dataNascimento}'" +
                    $"WHERE id_cliente = {this.Id_cliente}";
                conexao.Query(sql: update);
                MessageBox.Show("Dados atualizados com sucesso!!!");
                LimpaCampos();
                Limpar();
                Preenchimento(null  );
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslCliente.Text = ex.Message;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var delete = $"DELETE FROM tbl_cliente WHERE id_cliente = {this.Id_cliente}";
                conexao.Query(sql: delete);
                MessageBox.Show("Sentiremos saudade do seu dinheiro!");
                LimpaCampos();
                Limpar();
                Preenchimento(null);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslCliente.Text = ex.Message;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            Limpar();
            Preenchimento(null);
        }

        private void DtgCliente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.Id_cliente = (int)DtgCliente.SelectedRows[0].Cells[0].Value;

                var nomeCliente = DtgCliente.SelectedRows[0].Cells[1].Value;
                var nascimentoCliente = DtgCliente.SelectedRows[0].Cells[2].Value;
                var emailCliente = DtgCliente.SelectedRows[0].Cells[3].Value;
                var senhaCliente = DtgCliente.SelectedRows[0].Cells[4].Value;
                var telefoneCliente = DtgCliente.SelectedRows[0].Cells[5].Value;
                var cpfCliente = DtgCliente.SelectedRows[0].Cells[6].Value;

                var data = nascimentoCliente.ToString().Split('/');
                int d = int.Parse(data[0]);
                int m = int.Parse(data[1]);
                int Y = int.Parse(data[2].Split(' ')[0]);

                DtpNascimento.Value = new DateTime(Y, m, d);

                TxtClienteNome.Text = nomeCliente.ToString();
                TxtEmail.Text = emailCliente.ToString();

                TxtSenha.Text = senhaCliente.ToString();
                TxtTelefone.Text = telefoneCliente.ToString();
                TxtCpf.Text = cpfCliente.ToString();

                BtnEditar.Visible = true;
                BtnExcluir.Visible = true;
                BtnCancelar.Visible = true;
                BtnNovo.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                TslCliente.Text = ex.Message;
            }
        }

        private void TsmiCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria frmcategoris = new FrmCategoria();
            frmcategoris.ShowDialog();
        }

        private void TxtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                string query = $"SELECT * FROM tbl_cliente WHERE nome_cliente LIKE '%{TxtBusca.Text}%'";
                Preenchimento(query);
            }
        }
    }
}
