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

namespace ProjetoLogin.Apresentacao.TelasEstoquePeças
{
    public partial class CadastrarPeca : Form
    {
        public CadastrarPeca()
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
            strSql = "insert into Estoque_Pecas(Nome, Codigo, Fornecedor, Modelo, Quantidade, Disponibilidade, Demanda) values (@Nome, @Codigo, @Fornecedor, @Modelo, @Quantidade, @Disponibilidade, @Demanda)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txbNomePeca.Text;
            comando.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = txbCodigoPeca.Text;
            comando.Parameters.Add("@Fornecedor", SqlDbType.VarChar).Value = txbFornecedor.Text;
            comando.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = txbModelo.Text;
            comando.Parameters.Add("@Quantidade", SqlDbType.Int).Value = txbQuantidade.Text;
            comando.Parameters.Add("@Disponibilidade", SqlDbType.VarChar).Value = cmbDisponibilidade.Text;
            comando.Parameters.Add("@Demanda", SqlDbType.Float).Value = txbDemandaMedia.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso!!", "Cadastrado!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBtn.ClearControls(this);
                txbNomePeca.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlCon.Close();
            }
            #region CLASSE PEÇAS 
            //incluirPecas incluir = new incluirPecas();

            //incluir.NomePeca = txbNomePeca.Text;
            //incluir.CodigoPeca = txbCodigoPeca.Text;
            //incluir.Fornecedor = txbFornecedor.Text;
            //incluir.Modelo = txbModelo.Text;
            //incluir.Quantidade = int.Parse(txbQuantidade.Text);
            //incluir.Disponibilidade = cmbDisponibilidade.Text;
            //incluir.DemandaMedia = float.Parse(txbDemandaMedia.Text);

            //MessageBox.Show("Peça incluida com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            #endregion



        }
    }
    
}
