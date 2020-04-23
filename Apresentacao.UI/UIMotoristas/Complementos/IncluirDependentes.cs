using ProjetoLogin.Modelo.ClassesDoProjeto;
using ProjetoLogin.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin.Apresentacao.Complementos
{
    public partial class IncluirDependentes : Form
    {
        public IncluirDependentes()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home _home = new Home();
            _home.Close();

            this.Close(); 
        }
        SqlConnection sqlCon = null;
        private string strCon = @"Data Source=Douglas;Initial Catalog = Banco_Pim; Integrated Security = True";
        private string strSql = string.Empty;

        private void btnSalvarDependentes_Click(object sender, EventArgs e)
        {
            strSql = "insert into Dependentes(Nome_Completo, Data_Nascimento, CPF, Nome_Mae, Grau_Parentesco) values (@Nome_Completo, @Data_Nascimento, @CPF, @Nome_Mae, @Grau_Parentesco)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome_Completo", SqlDbType.VarChar).Value = txbNome.Text;
            comando.Parameters.Add("@Data_Nascimento", SqlDbType.VarChar).Value = mskDataNascimento.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txbCpf.Text;
            comando.Parameters.Add("@Nome_Mae", SqlDbType.VarChar).Value = txbNomeMae.Text;
            comando.Parameters.Add("@Grau_Parentesco", SqlDbType.VarChar).Value = cmbGrauParentesco.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso!!", "Cadastrado!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBtn.ClearControls(this);
                txbNome.Focus();
                txbNome.Text = "";
                mskDataNascimento.Text = "";
                txbCpf.Text = "";
                txbNomeMae.Text = "";
                cmbGrauParentesco.Text = ""; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlCon.Close();
            }


            
        }
    }
}
