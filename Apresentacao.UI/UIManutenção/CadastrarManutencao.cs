using ProjetoLogin.Modelo.ClassesDoProjeto;
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
using ProjetoLogin.Utils;

namespace ProjetoLogin.Apresentacao.TelasManutenção
{
    public partial class CadastrarManutencao : Form
    {
        public CadastrarManutencao()
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

        private void btnSalvarManutencao_Click(object sender, EventArgs e)
        {

            strSql = "insert into manutencao(Placa, dataManutencao, Resultado, Motivo, servicoRealizado, Valor, Revisao) values (@Placa, @dataManutencao, @Resultado, @Motivo, @servicoRealizado, @Valor, @Revisao)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Placa", SqlDbType.VarChar).Value = txbPlaca.Text;
            comando.Parameters.Add("@dataManutencao", SqlDbType.DateTime).Value = mskDataManutencao.Text;
            comando.Parameters.Add("@Resultado", SqlDbType.VarChar).Value = txbResultado.Text;
            comando.Parameters.Add("@Motivo", SqlDbType.VarChar).Value = txbMotivo.Text;
            comando.Parameters.Add("@servicoRealizado", SqlDbType.VarChar).Value = txbServicoRealizado.Text;
            comando.Parameters.Add("@Valor", SqlDbType.Float).Value = txbValor.Text;
            comando.Parameters.Add("@Revisao", SqlDbType.Float).Value = txbRevisao.Text;


            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso!!", "Cadastrado!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBtn.ClearControls(this);
                mskDataManutencao.Text = ""; 
                txbPlaca.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlCon.Close();
            }


            #region Classe manutenção

            //incluirManutencao incluir = new incluirManutencao();

            //incluir.Placa = txbPlaca.Text;
            //incluir.dataManutencao = DateTime.Parse(mskDataManutencao.Text);
            //incluir.Resultado = txbResultado.Text;
            //incluir.Motivo = txbMotivo.Text;
            //incluir.ServicoRealizado = txbServicoRealizado.Text;
            //incluir.Valor = float.Parse(txbValor.Text);
            //incluir.Revisao = float.Parse(txbRevisao.Text);

            //MessageBox.Show("Manutenção incluida com sucesso!!", "Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            #endregion
        }
    }
}
