using ProjetoLogin.Apresentacao;
using ProjetoLogin.Modelo;
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

namespace ProjetoLogin
{
    public partial class AlterarMotorista : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = @"Data Source=Douglas;Initial Catalog = Banco_Pim; Integrated Security = True";
        
        private string strSql = string.Empty;
       


        public AlterarMotorista()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home _home = new Home();
            _home.Close();

            this.Close();
        }

        private void btnVoltarMotorista_Click(object sender, EventArgs e)
        {
            Home _home = new Home();
            _home.Close();

            this.Close();
        }

        

        private void btnBuscarMotorista_Click(object sender, EventArgs e)
        {
            incluirMotorista _model = new incluirMotorista();
            string strSql = "SELECT * FROM[dbo].[Motoristas] with(nolock) where Matricula = @MatriculaConsulta";
            SqlConnection sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@MatriculaConsulta", SqlDbType.VarChar).Value = txbBuscarMotorista.Text;

            try
            {
                if (txbBuscarMotorista.Text == string.Empty)
                {
                    throw new Exception("Você precisa digitar uma Matricula!");
                }


                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == false)
                {
                    throw new Exception("Matricula não encontrada!");
                }
                else
                {
                    while (dr.Read())
                    {
                        txbMatricula.Text = Convert.ToString(dr["Matricula"]);
                        txbNome.Text = Convert.ToString(dr["Nome"]);
                        txbCargo.Text = Convert.ToString(dr["Cargo"]);
                        mskDataNascimento.Text = dr["Data_nascimento"] != DBNull.Value ? Convert.ToString(dr["Data_nascimento"]) : DateTime.MinValue.ToString();
                        txbRg.Text = Convert.ToString(dr["RG"]);
                        txbCpf.Text = Convert.ToString(dr["CPF"]);
                        txbCnh.Text= Convert.ToString(dr["CNH"]);
                        txbCategoria.Text = Convert.ToString(dr["Categoria"]);
                        maskCep.Text = Convert.ToString(dr["CEP"]);
                        txbEndereco.Text = Convert.ToString(dr["Endereco"]);
                        txbUf.Text = Convert.ToString(dr["UF"]);
                        txbCidade.Text = Convert.ToString(dr["Cidade"]);
                        txbBairro.Text = Convert.ToString(dr["Bairro"]);
                        maskDataAdmissao.Text = dr["Data_admissao"] != DBNull.Value ? Convert.ToString(dr["Data_admissao"]) : DateTime.MinValue.ToString();
                        mskDataExame.Text = dr["Data_exame"] != DBNull.Value ? Convert.ToString(dr["Data_exame"]) : DateTime.MinValue.ToString();
                        txbAntCriminais.Text = Convert.ToString(dr["Antecedentes_Criminais"]);
                    }
                }
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

        private void btnAlterarMotorista_Click(object sender, EventArgs e)
        {

            strSql = "Update [dbo]. Motoristas set Nome=@Nome, Cargo=@Cargo, Data_nascimento=@Data_nascimento, RG=@RG, CPF=@CPF, CNH=@CNH, Categoria=@Categoria, CEP=@CEP, Endereco=@Endereco, UF=@UF, Cidade=@Cidade, Bairro=@Bairro, Data_admissao=@Data_admissao, Data_exame=@Data_exame, Antecedentes_Criminais=@Antecedentes_Criminais Where Matricula = @Matricula"; 
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);


            
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

            //o erro estava aqui
            comando.Parameters.Add("@Matricula", SqlDbType.VarChar).Value = txbBuscarMotorista.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery(); 
                MessageBox.Show("Cadastro atualizado com sucesso!");

                txbMatricula.Text = string.Empty;
                txbNome.Text = string.Empty;
                txbCargo.Text = string.Empty;
                mskDataNascimento.Text = string.Empty;
                txbRg.Text = string.Empty;
                txbCpf.Text = string.Empty;
                txbCnh.Text = string.Empty;
                txbCategoria.Text = string.Empty;
                maskCep.Text = string.Empty;
                txbEndereco.Text = string.Empty;
                txbUf.Text = string.Empty;
                txbCidade.Text = string.Empty;
                txbBairro.Text = string.Empty;
                maskDataAdmissao.Text = string.Empty;
                mskDataExame.Text = string.Empty;
                txbAntCriminais.Text = string.Empty;
                txbBuscarMotorista.Text = string.Empty;
                txbBuscarMotorista.Focus();
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
