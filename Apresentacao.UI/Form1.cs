using ProjetoLogin.Apresentacao;
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

namespace ProjetoLogin
{
    public partial class Form1 : Form
    {
        private readonly UsuarioRepository getUserForLogin;
        public Form1()
        {
            InitializeComponent();
            this.getUserForLogin = new UsuarioRepository();
        }

       

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastreSe cad = new CadastreSe(this.getUserForLogin);
            cad.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
                Controle controle = new Controle(getUserForLogin);
            var existe = controle.existeUsuario(txbLogin.Text);

            UsuarioEntity usuarioEntity = controle.retornaUsuarios();

            if (existe == true)
            {
                MessageBox.Show("Logado com sucesso!!", "ENTRANDO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    this.Hide();
                    new Home().ShowDialog();
                }
                finally
                {
                    this.Show(); 
                }
                ClearTextBtn.ClearControls(this);
                txbLogin.Focus();             
            }

            else
            {
                MessageBox.Show("Login não encontrado. Verifique login ou senha!!", "ERRO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

       
    }
}
