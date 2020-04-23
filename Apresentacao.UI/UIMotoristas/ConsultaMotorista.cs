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
using ProjetoLogin.Apresentacao;
using ProjetoLogin.Dal;
using ProjetoLogin.Modelo;


namespace ProjetoLogin
{
    public partial class ConsultaMotorista : Form
    {
        private string strCon = @"Data Source=Douglas;Initial Catalog = Banco_Pim; Integrated Security = True";

        public ConsultaMotorista()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        #region Metodo para consultar todos os motoristas
        public void ConsultarTodosMotoristas()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.CST;

            try
            {
                con.Open();  //Abriu a conexão 
                
                //Criando o SqlCommand e selecionando os dados da tabela Usuario
                SqlCommand Cmm = new SqlCommand();
                Cmm.CommandText = "SELECT * FROM Motoristas";
                Cmm.CommandType = CommandType.Text;
                Cmm.Connection = con;
                SqlDataReader DR;
                DR = Cmm.ExecuteReader();

                //Carregar dadps dp DataGrid 
                DataTable dt = new DataTable();
                dt.Load(DR);
                dgvConsultarMotorista.DataSource = dt;
                dgvConsultarMotorista.Refresh();


                con.Close(); //Fechou a conexão 

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(String.Format("Falha na conexão:{0}", ex.Message));


                // Exibir mensagem se a conexão foi realizada com sucesso 
                // Caso de algum erro ele irá direto para p cath e exibirá
                // a mensagem de falha

            }
        }
        #endregion

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home _home = new Home();
            _home.Close();

            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultarMotorista_Click(object sender, EventArgs e)
        {
            // Conexao objMotorista = new Conexao();
            incluirMotorista _model = new incluirMotorista();
            List<incluirMotorista> _lstMotorista = new List<incluirMotorista>();
            string strSql = "SELECT * FROM[dbo].[Motoristas] with(nolock) where Matricula = @Matricula";
            SqlConnection sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Matricula", SqlDbType.VarChar).Value = txbConsultarMotorista.Text;

            try
            {
                if (txbConsultarMotorista.Text == string.Empty)
                {
                    throw new Exception("Você precisa digitar uma matricula!");
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
                        _lstMotorista.Add(new incluirMotorista(

                            _model.Matricula = Convert.ToString(dr["Matricula"]),
                            _model.Nome = Convert.ToString(dr["Nome"]),
                            _model.Cargo = Convert.ToString(dr["Cargo"]),
                            _model.DataNascimento = dr["Data_nascimento"] != DBNull.Value ? Convert.ToDateTime(dr["Data_nascimento"]) : DateTime.MinValue,
                            _model.Rg = Convert.ToString(dr["RG"]),
                            _model.Cpf = Convert.ToString(dr["CPF"]),
                            _model.Cnh = Convert.ToString(dr["CNH"]),
                            _model.Categoria = Convert.ToString(dr["Categoria"]),
                            _model.Cep = Convert.ToString(dr["CEP"]),
                            _model.Endereco = Convert.ToString(dr["Endereco"]),
                            _model.Uf = Convert.ToString(dr["UF"]),
                            _model.Cidade = Convert.ToString(dr["Cidade"]),
                            _model.Bairro = Convert.ToString(dr["Bairro"]),
                            _model.DataAdmissao = dr["Data_admissao"] != DBNull.Value ? Convert.ToDateTime(dr["Data_admissao"]) : DateTime.MinValue,
                            _model.DataExame = dr["Data_exame"] != DBNull.Value ? Convert.ToDateTime(dr["Data_exame"]) : DateTime.MinValue,
                            _model.AntCriminais = Convert.ToString(dr["Antecedentes_Criminais"])
                        ));
                    }
                }

                if (_lstMotorista.Count > 0)
                {
                    dgvConsultarMotorista.DataSource = _lstMotorista;
                    txbConsultarMotorista.Text = string.Empty; 
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

        private void ConsultaMotorista_Load(object sender, EventArgs e)
        {
            ConsultarTodosMotoristas(); 
        }
    }
}
