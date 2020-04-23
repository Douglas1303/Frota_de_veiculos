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
    public partial class ConsultarSinistro : Form
    {
        public ConsultarSinistro()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home _home = new Home();
            _home.Close();

            this.Close();
        }

        private void btnConsultarTodos_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.CST;

            try
            {
                con.Open();  //Abriu a conexão 

                //Criando o SqlCommand e selecionando os dados da tabela Usuario
                SqlCommand Cmm = new SqlCommand();
                Cmm.CommandText = "SELECT * FROM Sinistro";
                Cmm.CommandType = CommandType.Text;
                Cmm.Connection = con;
                SqlDataReader DR;
                DR = Cmm.ExecuteReader();

                //Carregar dadps dp DataGrid 
                DataTable dt = new DataTable();
                dt.Load(DR);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();


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
    }
}
