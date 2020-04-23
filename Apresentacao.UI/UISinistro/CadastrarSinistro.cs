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

namespace ProjetoLogin.Apresentacao.UI.UISinistro
{
    public partial class CadastrarSinistro : Form
    {
        public CadastrarSinistro()
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

        private void btnSalvarSinistro_Click(object sender, EventArgs e)
        {
            strSql = "insert into Sinistro(Placa, Matricula_Motorista, Data, Valor_Orcamento, Tipo_Sinistro, Contato_Terceiro, Descricao) values (@Placa, @Matricula_Motorista, @Data, @Valor_Orcamento, @Tipo_Sinistro, @Contato_Terceiro, @Descricao)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);


            comando.Parameters.Add("@Placa", SqlDbType.VarChar).Value = txbPlacaVeiculo.Text;
            comando.Parameters.Add("@Matricula_Motorista", SqlDbType.VarChar).Value = txbMatriculaMotorista.Text;
            comando.Parameters.Add("@Data", SqlDbType.DateTime).Value = mskDataAcontecido.Text;
            comando.Parameters.Add("@Valor_Orcamento", SqlDbType.Float).Value = txbOrcamento.Text;
            comando.Parameters.Add("@Tipo_Sinistro", SqlDbType.VarChar).Value = cmbTipoSinistro.Text;
            comando.Parameters.Add("@Contato_Terceiro", SqlDbType.VarChar).Value = mskContatoTerceiro.Text;
            comando.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = txbDescricaoSinistro.Text;

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


            #region
            //incluirSinistro incluir = new incluirSinistro();

            //incluir.NumeroSinistro = int.Parse(txbNumeroSinistro.Text);
            //incluir.PlacaVeiculo = txbPlacaVeiculo.Text;
            //incluir.MatriculaMotorista = txbMatriculaMotorista.Text;
            //incluir.DataOcorrido = DateTime.Parse(mskDataAcontecido.Text);
            //incluir.ValorOrçamento = float.Parse(txbOrcamento.Text);
            //incluir.TipoSinistro = cmbTipoSinistro.Text;
            //incluir.ContatoTerceiro = mskContatoTerceiro.Text;
            //incluir.DescricaoSinistro = txbDescricaoSinistro.Text;

            //MessageBox.Show("Sinistro incluido com sucesso!!", "Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            #endregion
        }
    }
}
