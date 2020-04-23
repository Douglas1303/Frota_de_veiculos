using ProjetoLogin.Apresentacao.Complementos;
using ProjetoLogin.Apresentacao.TelasEstoquePeças;
using ProjetoLogin.Apresentacao.TelasManutenção;
using ProjetoLogin.Apresentacao.TelasSeguroVeiculo;
using ProjetoLogin.Apresentacao.TelasSeguroVida;
using ProjetoLogin.Apresentacao.TelasVeiculo;
using ProjetoLogin.Apresentacao.UI;
using ProjetoLogin.Apresentacao.UI.UIRelatorios;
using ProjetoLogin.Apresentacao.UI.UIServico;
using ProjetoLogin.Apresentacao.UI.UISinistro;
using ProjetoLogin.Apresentacao.UI.UISuporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoLogin.Apresentacao
{
    
    public partial class Home : Form
    {

        

        public Home()
        {
            InitializeComponent();
        }

        private void alteraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AlterarMotorista().Show();
            //Essa operação acima substitui essa:
            //AlterarMotorista altMotorista = new AlterarMotorista();
            //altMotorista.Show(); 
        }

        private void exclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ExcluirMotorista().Show(); 
            // ExcluirMotorista exMotorista = new ExcluirMotorista();
           // exMotorista.Show(); 
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultaMotorista().Show(); 
           // ConsultaMotorista conMotorista = new ConsultaMotorista();
            //conMotorista.Show(); 
        }

        private void inclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {             
            new CadastrarMotorista().Show();

            /*Codigo em mdi: 
              Form _cadastrarMotorista = new CadastrarMotorista();
            _cadastrarMotorista.MdiParent = this;
            _cadastrarMotorista.Show(); */ 

            //CadastrarMotorista cadMotorista = new CadastrarMotorista();
            //cadMotorista.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja realmente sair? ", "Sair do Home ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
                      

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeguroDeVida vida = new SeguroDeVida();
            vida.Show(); 
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarSeguroVeiculo veiculo = new ConsultarSeguroVeiculo();
            veiculo.Show(); 
        }

        private void inclusãoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CadastrarPeca _CadastrarPeca = new CadastrarPeca();
            _CadastrarPeca.Show(); 
        }

        private void alteraçãoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AlterarPecas _AlterarPecas = new AlterarPecas();
            _AlterarPecas.Show(); 
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultarPeca _ConsultarPeca = new ConsultarPeca();
            _ConsultarPeca.Show(); 
        }

        private void exclusãoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ExcluirPeca _ExcluirPeca = new ExcluirPeca();
            _ExcluirPeca.Show(); 
        }

        private void inclusãoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CadastrarSinistro _CadastrarSinistro = new CadastrarSinistro();
            _CadastrarSinistro.Show(); 
        }

        private void alteraçãoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AlterarSinistro _AlterarSinistro = new AlterarSinistro();
            _AlterarSinistro.Show();
        }

        private void consultaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ConsultarSinistro _ConsultarSinistro = new ConsultarSinistro();
            _ConsultarSinistro.Show(); 

        }

        private void exclusãoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ExcluirSinistro _ExcluirSinistro = new ExcluirSinistro();
            _ExcluirSinistro.Show(); 
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarVeiculo _CadastrarVeiculo = new CadastrarVeiculo();
            _CadastrarVeiculo.Show(); 

        }

        private void alteraçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlterarVeiculo _AlterarVeiculo = new AlterarVeiculo();
            _AlterarVeiculo.Show(); 
        }

        private void exclusãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarVeiculo _ConsultarVeiculo = new ConsultarVeiculo();
            _ConsultarVeiculo.Show(); 
        }

        private void exclusãoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ExcluirVeiculo _ExcluirVeiculo = new ExcluirVeiculo();
            _ExcluirVeiculo.Show(); 
        }

        private void inclusãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarManutencao _CadastrarManutencao = new CadastrarManutencao();
            _CadastrarManutencao.Show(); 
        }

        private void alteraçãoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AlterarManutencao _AlterarManutencao = new AlterarManutencao();
            _AlterarManutencao.Show(); 
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarManutencao _ConsultarManutencao = new ConsultarManutencao();
            _ConsultarManutencao.Show(); 
        }

        private void exclusãoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ExcluirManutencao _ExcluirManutencao = new ExcluirManutencao();
            _ExcluirManutencao.Show(); 
        }

        private void inclusãoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CadastrarServico _CadastrarServico = new CadastrarServico();
            _CadastrarServico.Show(); 
        }

        private void alteraçãoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            AlterarServico _AlterarServico = new AlterarServico();
            _AlterarServico.Show(); 
        }

        private void consultaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ConsultarServico _ConsultarServico = new ConsultarServico();
            _ConsultarServico.Show(); 
        }

        private void exclusãoToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ExcluirServico _ExcluirServico = new ExcluirServico();
            _ExcluirServico.Show(); 
        }

        private void inclusãoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            CadastrarRelatorio _CadastrarRelatorio = new CadastrarRelatorio();
            _CadastrarRelatorio.Show(); 
        }

        private void alteraçãoToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            
        }

        private void consultaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
        }

        

        private void contatoEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contato _Contato = new Contato();
            _Contato.Show(); 
        }

        private void exclusãoToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
