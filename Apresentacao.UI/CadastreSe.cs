using ProjetoLogin.Dao.Repositorio;
using ProjetoLogin.Modelo;
using ProjetoLogin.Utils;
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
    public partial class CadastreSe : Form
    {
        private readonly UsuarioRepository getUserForLogin;

        public CadastreSe(UsuarioRepository getUserForLogin)
        {
            InitializeComponent();
            this.getUserForLogin = new UsuarioRepository();
        }

        private void CadastreSe_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(this.getUserForLogin);
            bool inseridoComSucesso = controle.CadastrarUsuario(txbLogin.Text, txbSenha.Text, txbEmail.Text);
            if (inseridoComSucesso == true)//Mensagem de sucesso
            {
                MessageBox.Show("Usuario cadastrado", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBtn.ClearControls(this);
                txbLogin.Focus();
            }
            else
            {
                MessageBox.Show(controle.mensagem);//Mensagem de erro 
            }



        }


    }
}
