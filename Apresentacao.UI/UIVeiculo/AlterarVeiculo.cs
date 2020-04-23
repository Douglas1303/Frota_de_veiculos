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
using ProjetoLogin.Modelo.ClassesDoProjeto; 

namespace ProjetoLogin.Apresentacao.TelasVeiculo
{
    public partial class AlterarVeiculo : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = @"Data Source=Douglas;Initial Catalog = Banco_Pim; Integrated Security = True";
        private string strSql = string.Empty;

        public AlterarVeiculo()
        {
            InitializeComponent();
        }

        private void AlterarVeiculo_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home _home = new Home();
            _home.Close();

            this.Close();
        }

        private void btnPesquisarVeiculo_Click(object sender, EventArgs e)
        {
            IncluirVeiculo _model = new IncluirVeiculo();
            string strSql = "SELECT * FROM[dbo].[Veiculo] with(nolock) where Placa = @Placa";
            SqlConnection sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Placa", SqlDbType.VarChar).Value = txtAlterarVeiculo.Text;

            try
            {
                if (txtAlterarVeiculo.Text == string.Empty)
                {
                    throw new Exception("Você precisa digitar uma Placa!");
                }


                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == false)
                {
                    throw new Exception("Placa não encontrada!");
                }
                else
                {
                    while (dr.Read())
                    {
                        txtAno.Text = Convert.ToString(dr["Ano"]);
                        txtPlaca.Text = Convert.ToString(dr["Placa"]);
                        txtModelo.Text = Convert.ToString(dr["Modelo"]); 
                       txtChassi.Text = Convert.ToString(dr["Chassi"]);
                       txtRenavam.Text = Convert.ToString(dr["Renavam"]);
                       txtCombustivel.Text = Convert.ToString(dr["Combustivel"]);
                       txtCategoria.Text = Convert.ToString(dr["Categoria"]);
                       txtKM.Text = Convert.ToString(dr["KM"]);
                        txtAlterarVeiculo.Text = string.Empty;
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

        private void btnAlterarVeiculo_Click(object sender, EventArgs e)
        {

            strSql = "update Veiculo set Ano=@Ano, Placa=@Placa, Modelo=@Modelo, Chassi=@Chassi, Renavam=@Renavam, Combustivel=@Combustivel, Categoria=@Categoria, KM=@KM Where Placa = @PlacaBusca";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);


            comando.Parameters.Add("@PlacaBusca", SqlDbType.VarChar).Value = txtAlterarVeiculo.Text;

            comando.Parameters.Add("@Ano", SqlDbType.VarChar).Value = txtAno.Text;
            comando.Parameters.Add("@Placa", SqlDbType.VarChar).Value = txtPlaca.Text;
            comando.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = txtModelo.Text;
            comando.Parameters.Add("@Chassi", SqlDbType.VarChar).Value = txtChassi.Text;
            comando.Parameters.Add("@Renavam", SqlDbType.VarChar).Value = txtRenavam.Text;
            comando.Parameters.Add("@Combustivel", SqlDbType.VarChar).Value = txtCombustivel.Text;
            comando.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = txtCategoria.Text;
            comando.Parameters.Add("@KM", SqlDbType.VarChar).Value = txtKM.Text;
            
            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro atualizado com sucesso!");

                txtAno.Text = string.Empty;
                txtPlaca.Text = string.Empty;
                txtModelo.Text = string.Empty;
                txtChassi.Text= string.Empty;
                txtRenavam.Text = string.Empty;
                txtCombustivel.Text = string.Empty;
                txtCategoria.Text = string.Empty;
                txtKM.Text = string.Empty;
                
                txtAlterarVeiculo.Text = string.Empty;
                txtAlterarVeiculo.Focus();
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
