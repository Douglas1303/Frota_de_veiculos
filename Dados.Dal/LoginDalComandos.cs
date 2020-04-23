using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Dal
{
    class LoginDalComandos
    {
        #region variaveis
        public bool tem = false;
        public string mensagem = "";//Tudo ok
        #endregion

        #region objetos
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        #endregion

        #region metodos
        #region verificarLogin
        public bool verificarLogin(string login, string senha)

        {
            //Nesse metodo vamos colocar os comando sql para verificar se tem no banco.
            
            cmd.CommandText = $"select * from Usuario where usuario='{login}' and Senha='{senha}'";
            


            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//Se foi encontrado
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close(); 
            }
            catch (SqlException capturar)
            {

                this.mensagem = $"Erro com o banco de Dados:  {capturar}";
                Console.WriteLine(capturar);
            }

            if (tem == false)
                mensagem = "Usuario nao encontrado!";

            return tem;
        }
        #endregion
        #region cadastrar
        public String cadastrar(String usuario, String senha, String confSenha)
        {
           tem = false; 
            //comando para inserir
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "INSERT INTO [dbo].[Usuario]([Usuario],[Senha],[Email],[Ativo]) VALUES (@Usuario, @Senha,@Email,@Ativo);";
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Senha", senha);
                cmd.Parameters.AddWithValue("@Email", string.Empty);
                cmd.Parameters.AddWithValue("@Ativo", true);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso!!";
                  tem  = true; 
                }
                catch (SqlException)
                {

                    this.mensagem = "Erro com o banco de Dados!!";
                }
            }else
            {
                this.mensagem = "Senhas não correspondem";

            }
            return mensagem; 
        }
        #endregion
        #endregion

    }
}
