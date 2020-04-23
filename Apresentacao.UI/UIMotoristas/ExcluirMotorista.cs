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
    public partial class ExcluirMotorista : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = @"Data Source=Douglas;Initial Catalog = Banco_Pim; Integrated Security = True";
        private string strSql = string.Empty;
        int id = 0;
        string motorista = string.Empty;


        #region String de conexão co codigo 1 
        //string connectionString = @"Data Source=Douglas;Initial Catalog = Banco_Pim; Integrated Security = True";
        //bool novo;

        #endregion
        public ExcluirMotorista()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home _home = new Home();
            _home.Close();

            this.Close();
        }

        public void consultarMotoristaTodos()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.CST;

            try
            {
                con.Open();  //Abriu a conexão 

                //Criando o SqlCommand e selecionando os dados da tabela Usuario
                SqlCommand Cmm = new SqlCommand();
                Cmm.CommandText = "SELECT * FROM Motoristas with(nolock)";
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
        

        private void ExcluirMotorista_Load(object sender, EventArgs e)
        {
            consultarMotoristaTodos();

        }

        private void BtnExcluirMotorista_Click(object sender, EventArgs e)
        {
                if (id == 0)
                {
                    MessageBox.Show("Favor selecionar uma linha para a efetivar a exclusão!");
                }
                else
                {
                    if (MessageBox.Show("Deseja realmente excluir o motorista " + motorista + " ?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        MessageBox.Show("Operação cancelada!");
                    }
                    else
                    {
                        strSql = "DELETE FROM [dbo].[Motoristas] where Id = @ID";
                        sqlCon = new SqlConnection(strCon);
                        SqlCommand comando = new SqlCommand(strSql, sqlCon);

                        comando.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                        try
                        {
                            sqlCon.Open();
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Exclusão realizada com sucesso!");
                            consultarMotoristaTodos();
                            txbExcluirMotorista.Text = string.Empty;
                            txbExcluirMotorista.Focus();

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


        private void btnBuscarMotorista_Click_1(object sender, EventArgs e)
        {
            List<incluirMotorista> _lstMotorista = new List<incluirMotorista>();
            incluirMotorista _model = new incluirMotorista();
            string strSql = "SELECT * FROM[dbo].[Motoristas] with(nolock) where Matricula = @Matricula";
            SqlConnection sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Matricula", SqlDbType.VarChar).Value = txbExcluirMotorista.Text;

            try
            {
                if (txbExcluirMotorista.Text == string.Empty)
                {
                    throw new Exception("Você precisa digitar um nome!");
                }


                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == false)
                {
                    throw new Exception("Nome não encontrado!");
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

        private void dgvConsultarMotorista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvConsultarMotorista.CurrentRow.Cells[0].Value);
            motorista = dgvConsultarMotorista.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
