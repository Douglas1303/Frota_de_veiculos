using ProjetoLogin.Apresentacao.Complementos;
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
using System.Data.SqlClient; 

namespace ProjetoLogin.Apresentacao
{
    public partial class CadastrarMotorista : Form
    {
        public CadastrarMotorista()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluirDependentes_Click(object sender, EventArgs e)
        {
            new IncluirDependentes().Show();
            //Essa operação acima substitui essa:
            //IncluirDependentes dependentes = new IncluirDependentes();
            //dependentes.Show(); 


        }

        private void btnseguroVida_Click(object sender, EventArgs e)
        {
            new SeguroVida().Show();
            //Essa operação acima substitui essa:
            //SeguroVida seguro = new SeguroVida();
            //seguro.Show(); 
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //Fechar o home 
            Home _home = new Home();
            _home.Close();

            //Fechar o CadastrarMotorista
            this.Close(); 

           
        }
        SqlConnection sqlCon = null;
        private string strCon = @"Data Source=Douglas;Initial Catalog = Banco_Pim; Integrated Security = True";
        private string strSql = string.Empty; 

        private void btnSalvarDados_Click(object sender, EventArgs e)

        {
            strSql = "insert into Motoristas(Matricula, Nome, Cargo, Data_nascimento, RG, CPF, CNH, Categoria, CEP, Endereco, UF, Cidade, Bairro, Data_admissao, Data_exame, Antecedentes_Criminais) values (@Matricula, @Nome, @Cargo, @Data_nascimento, @RG, @CPF, @CNH, @Categoria, @CEP, @Endereco, @UF, @Cidade, @Bairro, @Data_admissao, @Data_exame, @Antecedentes_Criminais)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Matricula", SqlDbType.VarChar).Value = txbMatricula.Text;
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txbNome.Text;
            comando.Parameters.Add("@Cargo", SqlDbType.VarChar).Value = txbCargo.Text;
            comando.Parameters.Add("@Data_nascimento", SqlDbType.DateTime).Value = Convert.ToDateTime(mskDataNascimento.Text);
            comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txbRg.Text;          
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txbCpf.Text;
            comando.Parameters.Add("@CNH", SqlDbType.VarChar).Value = txbCnh.Text;
            comando.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = txbCategoria.Text;
            comando.Parameters.Add("@CEP", SqlDbType.VarChar).Value = maskCep.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txbEndereco.Text;
            comando.Parameters.Add("@UF", SqlDbType.VarChar).Value = txbUf.Text;
            comando.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = txbCidade.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txbBairro.Text;
            comando.Parameters.Add("@Data_admissao", SqlDbType.DateTime).Value = Convert.ToDateTime(maskDataAdmissao.Text);
            comando.Parameters.Add("@Data_exame", SqlDbType.DateTime).Value = Convert.ToDateTime(mskDataExame.Text);
            comando.Parameters.Add("@Antecedentes_Criminais", SqlDbType.VarChar).Value = txbAntCriminais.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso!!", "Cadastrado!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBtn.ClearControls(this);
                txbMatricula.Focus();

                mskDataNascimento.Text = "";
                txbRg.Text = "";
                txbCpf.Text = "";
                maskCep.Text = "";
                maskDataAdmissao.Text = "";
                mskDataExame.Text = "";
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlCon.Close();
            }





            #region Inclusão com classes
            //incluirMotorista incluir = new incluirMotorista();

            //incluir.Matricula = txbMatricula.Text;
            //incluir.Nome = txbNome.Text;
            //incluir.Cargo = txbCargo.Text; 
            //incluir.DataNascimento = DateTime.Parse(mskDataNascimento.Text);
            //incluir.Rg = txbRg.Text;
            //incluir.Cpf = txbCpf.Text;
            //incluir.Cnh = txbCnh.Text;
            //incluir.Categoria = txbCategoria.Text;
            //incluir.Cep = maskCep.Text;
            //incluir.Endereco = txbEndereco.Text;
            //incluir.Uf = txbUf.Text;
            //incluir.Cidade = txbCidade.Text;
            //incluir.Bairro = txbBairro.Text; 
            //incluir.DataAdmissao = DateTime.Parse(maskDataAdmissao.Text);
            //incluir.DataExame = DateTime.Parse(mskDataExame.Text);
            //incluir.AntCriminais = txbAntCriminais.Text;



            //MessageBox.Show("Cadastro efetuado com sucesso!!", "Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //ClearTextBtn.ClearControls(this);
            //txbMatricula.Focus();

            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpar_campos(); 
        }
        private void limpar_campos()
        {
            txbMatricula.Text = "";
            txbNome.Text = "";
            txbCargo.Text = "";
            mskDataNascimento.Text = "";
            txbRg.Text = "";
            txbCpf.Text = "";
            txbCnh.Text = "";
            txbCategoria.Text = "";
            maskCep.Text = "";
            txbEndereco.Text = "";
            txbUf.Text = "";
            txbCidade.Text = "";
            txbBairro.Text = "";
            chkApto.Text = "";
            chkInapto.Text = "";
            maskDataAdmissao.Text = ""; 
            mskDataExame.Text = "";           
            txbAntCriminais.Text = ""; 


        }

        
    }
}
