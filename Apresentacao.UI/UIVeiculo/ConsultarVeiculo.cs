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
    public partial class ConsultarVeiculo : Form
    {
       #region Metodo que seleciona todos os dados da tabela Veiculo

        public void ConsultarOsVeiculos()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.CST;

            try
            {
                con.Open();  //Abriu a conexão 

                //Criando o SqlCommand e selecionando os dados da tabela Usuario
                SqlCommand Cmm = new SqlCommand();
                Cmm.CommandText = "SELECT * FROM Veiculo";
                Cmm.CommandType = CommandType.Text;
                Cmm.Connection = con;
                SqlDataReader DR;
                DR = Cmm.ExecuteReader();

                // Carregar dadps dp DataGrid
                DataTable dt = new DataTable();
                dt.Load(DR);
                dgvConsultarVeiculo.DataSource = dt;
                dgvConsultarVeiculo.Refresh();


                con.Close(); //Fechou a conexão 

            }

            catch (Exception ex)
            {

                MessageBox.Show(String.Format("Falha na conexão:{0}", ex.Message));


                //Exibir mensagem se a conexão foi realizada com sucesso
                //Caso de algum erro ele irá direto para p cath e exibirá
                //a mensagem de falha

            }
        }
        #endregion
        private void ConsultarVeiculo_Load(object sender, EventArgs e)
        {
            ConsultarOsVeiculos();
        }


        private void ConsultarTodosVeiculos()
        {

        }

        public ConsultarVeiculo()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home _home = new Home();
            _home.Close();

            this.Close();
        }
        private string strCon = @"Data Source=Douglas;Initial Catalog = Banco_Pim; Integrated Security = True";

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          List<IncluirVeiculo> _lstVeiculo = new List<IncluirVeiculo>();

            IncluirVeiculo _model = new IncluirVeiculo();
            string strSql = "SELECT * FROM[dbo].[Veiculo] with(nolock) where Placa = @Placa";
            SqlConnection sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Placa", SqlDbType.VarChar).Value = txtPlaca.Text;

            try
            {
                if (txtPlaca.Text == string.Empty)
                {
                    throw new Exception("Você precisa digitar uma Placa!");
                }


                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == false)
                {
                    throw new Exception("Placa não encontrado!");
                }
                else
                {
                    while (dr.Read())
                    {
                        _lstVeiculo.Add(new IncluirVeiculo(
                            _model.CodVeiculo = Convert.ToInt32(dr["codVeiculo"]),
                            _model.Ano = Convert.ToString(dr["Ano"]),
                            _model.Placa = Convert.ToString(dr["Placa"]),
                            _model.Modelo = Convert.ToString(dr["Modelo"]),
                            _model.Chassi = Convert.ToString(dr["Chassi"]),
                            _model.Renavam = Convert.ToString(dr["Renavam"]),
                            _model.Combustivel = Convert.ToString(dr["Combustivel"]),
                            _model.Categoria = Convert.ToString(dr["Categoria"]),
                            _model.KM = Convert.ToString(dr["KM"])


                        //exemplo de dateTime   
                        // _model.DataAdmissao = dr["Data_admissao"] != DBNull.Value ? Convert.ToDateTime(dr["Data_admissao"]) : DateTime.MinValue,
                        //_model.DataExame = dr["Data_exame"] != DBNull.Value ? Convert.ToDateTime(dr["Data_exame"]) : DateTime.MinValue,

                        ));
                    }
                }

                if (_lstVeiculo.Count > 0)
                {
                    dgvConsultarVeiculo.DataSource = _lstVeiculo;
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado!");
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
    } 

        
    
}
