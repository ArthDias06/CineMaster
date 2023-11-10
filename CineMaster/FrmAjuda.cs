using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineMaster
{
    public partial class FrmAjuda : Form
    {
        public FrmAjuda()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            LblExibicao.Text = "Sistema de Gerenciamento de Ingressos de Cinema\r\n\r\nProjeto semestral desenvolvido pela turma B do 2° ano de informática no Colégio Técnico Industrial. A equipe desenvolveu um projeto em C# e SQL,\n o qual ilustra o processo de navegação e compra de ingressos em um sistema online de cinemas.\r\n\r\nIntegrantes:\r\n\r\nArthur de Castro Dias\r\nArthur Pupolin Magalhães\r\nCarol Xavier Mazon\r\nDaniel Giraldi França Gonsales\r\nDiogo Henrique da Silva Harada\r\n\r\nDescrição do Projeto:\r\n\r\nA aplicação de C# desenvolvida é um conjunto de formulários do Windows que oferece funcionalidades para um sistema de cinema. A seguir,\n serão destacadas as principais características do projeto:\r\n\r\nCompra de Ingressos: Os usuários serão atendidos por um administrador que fará a reserva de um ingresso para eles, podendo esse dministrador\n,navegar entre diversos filmes disponíeis.\r\n\r\n";
            LblExibicao2.Text = "Análise de Opções de Filmes: O sistema fornece informações detalhadas sobre os filmes em cartaz, incluindo sinopse, horários de exibição,\n categorias às quais pertencem, entre outros. Isso permite aos usuários terem maior noção sobre os filmes os quais procuram assistir.\r\n\r\nGerenciamento de Sessões: O sistema mantém um registro das sessões de filmes disponíveis, permitindo aos usuários escolher horários que se adequem \nàs suas agendas.\r\n\r\nFeedback:\r\n\r\nEncontrou algum problema ou possui alguma dúvida? Entre em contato com daniel.gf.gonsales@unesp.br. Adoraríamos ouvir suas sugestões e feedbacks!!\nFique à vontade para navegar pelo projeto e criar uma experiência única com nossa aplicação!!";
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
    }
}
