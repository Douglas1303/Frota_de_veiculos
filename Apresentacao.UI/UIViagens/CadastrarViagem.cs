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

namespace ProjetoLogin.Apresentacao.UI.UIServico
{
    public partial class CadastrarServico : Form
    {
        public CadastrarServico()
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

        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            strSql = "insert into Viagem(Placa, Matricula_Motorista, Entrada, Saida, Abastecimento, Valor_Abastecimento, Quilometragem) values (@Placa, @Matricula_Motorista, @Entrada, @Saida, @Abastecimento, @Valor_Abastecimento, @Quilometragem)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);


            comando.Parameters.Add("@Placa", SqlDbType.VarChar).Value = txbPlacaVeiculo.Text;
            comando.Parameters.Add("@Matricula_Motorista", SqlDbType.VarChar).Value = txbMatriculaMotorista.Text;
            comando.Parameters.Add("@Entrada", SqlDbType.DateTime).Value = mskEntrada.Text;
            comando.Parameters.Add("@Saida", SqlDbType.DateTime).Value = mskSaida.Text;
            comando.Parameters.Add("@Abastecimento", SqlDbType.VarChar).Value = cmbAbastecimento.Text;
            comando.Parameters.Add("@Valor_Abastecimento", SqlDbType.Float).Value = txbValor.Text;
            comando.Parameters.Add("@Quilometragem", SqlDbType.Float).Value = txbKM.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso!!", "Cadastrado!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBtn.ClearControls(this);
                txbPlacaVeiculo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlCon.Close();
            }

            #region CLASSE VIAGENS

            //    incluirViagens _incluirViagens = new incluirViagens();

            //    _incluirViagens.PlacaVeiculo = txbPlacaVeiculo.Text;
            //    _incluirViagens.MatriculaMotorista = txbMatriculaMotorista.Text;
            //    _incluirViagens.Entrada = DateTime.Parse(mskEntrada.Text);
            //    _incluirViagens.Saida = DateTime.Parse(mskSaida.Text);
            //    _incluirViagens.Abastecimento = cmbAbastecimento.Text;
            //    _incluirViagens.ValorAbastecimento = float.Parse(txbValor.Text);
            //    _incluirViagens.Quilometragem = float.Parse(txbKM.Text);

            //    MessageBox.Show("Viagem incluida com sucesso!!", "Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            #endregion
        }
    }
    
}
