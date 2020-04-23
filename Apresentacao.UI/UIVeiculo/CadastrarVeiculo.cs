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

namespace ProjetoLogin.Apresentacao.TelasVeiculo
{
    public partial class CadastrarVeiculo : Form
    {
        public CadastrarVeiculo()
        {
            InitializeComponent();
        }

        private void CadastrarVeiculo_Load(object sender, EventArgs e)
        {

        }
        SqlConnection sqlCon = null;
        private string strCon = @"Data Source=Douglas;Initial Catalog = Banco_Pim; Integrated Security = True";
        private string strSql = string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            strSql = "insert into Veiculo(Ano, Placa, Modelo, Chassi, Renavam, Combustivel, Categoria, KM) values (@Ano, @Placa, @Modelo, @Chassi, @Renavam, @Combustivel, @Categoria, @KM)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

           
            comando.Parameters.Add("@Ano", SqlDbType.VarChar).Value = txbAnoVeiculo.Text;
            comando.Parameters.Add("@Placa", SqlDbType.VarChar).Value = txbPlacaVeiculo.Text;
            comando.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = txbModeloVeiculo.Text;
            comando.Parameters.Add("@Chassi", SqlDbType.VarChar).Value = txbChassiVeiculo.Text;
            comando.Parameters.Add("@Renavam", SqlDbType.VarChar).Value = txbCodigoRenavam.Text;
            comando.Parameters.Add("@Combustivel", SqlDbType.VarChar).Value = cmbTipoCombustivel.Text;
            comando.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = txbCategoriaVeiculo.Text;
            comando.Parameters.Add("@KM", SqlDbType.Float).Value = txbKM.Text;


            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso!!", "Cadastrado!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBtn.ClearControls(this);
                txbPlacaVeiculo.Text = string.Empty; 
                cmbTipoCombustivel.Text = string.Empty; 
                txbAnoVeiculo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlCon.Close();
            }


            #region Classes veiculo
            //IncluirVeiculo _IncluirVeiculo = new IncluirVeiculo();

            //_IncluirVeiculo.AnoVeiculo = txbAnoVeiculo.Text;
            //_IncluirVeiculo.PlacaVeiculo = txbPlacaVeiculo.Text;
            //_IncluirVeiculo.ModeloVeiculo = txbModeloVeiculo.Text;
            //_IncluirVeiculo.Chassi = txbChassiVeiculo.Text;
            //_IncluirVeiculo.CodigoRenavam = txbCodigoRenavam.Text;
            //_IncluirVeiculo.TipoCombustivel = cmbTipoCombustivel.Text;
            //_IncluirVeiculo.Categoria = txbCategoriaVeiculo.Text;
            //_IncluirVeiculo.KM = float.Parse(txbKM.Text);

            //MessageBox.Show("Veículo cadastrado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            #endregion
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home _home = new Home();
            _home.Close();

            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //Fechar o home 
            Home _home = new Home();
            _home.Close();

            //Fechar o CadastrarMotorista
            this.Close();
        }
    }
}
