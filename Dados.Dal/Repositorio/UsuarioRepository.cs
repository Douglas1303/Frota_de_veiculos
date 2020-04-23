using ProjetoLogin.Dao.Interface;
using ProjetoLogin.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Dao.Repositorio
{
    public class UsuarioRepository : AbstractRepository<UsuarioEntity>
    {
        public override bool getByUser(string user)
        {
            using (var command = CriarConexao())
            {
                command.CommandText = "dbo.GetUserForLogin";
                command.CommandType = CommandType.StoredProcedure;


                command.Connection.Open();
                command.Parameters.Add(new SqlParameter("@USERNAME", SqlDbType.VarChar) { Value = user });

                using (var reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    if (reader.HasRows == true)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override UsuarioEntity getuser()
        {
            UsuarioEntity usuarioEntities = new UsuarioEntity();

            using (var cmd = CriarConexao())
            {
                cmd.CommandText = $"select * from Usuario";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        usuarioEntities.Usuario = (String)reader["usuario"];
                        usuarioEntities.email = (String)reader["email"];
                        usuarioEntities.Ativo = (bool)reader["ativo"];
                    }

                    return usuarioEntities;
                }
            }
        }

        public override List<UsuarioEntity> GetUsuarios()
        {
            UsuarioEntity user = new UsuarioEntity();
            List<UsuarioEntity> usuarioEntities = new List<UsuarioEntity>();

            using (var cmd = CriarConexao())
            {
                cmd.CommandText = $"select * from Usuario";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();

                using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        user.Usuario = (string)reader["usuario"];
                        user.email = (string)reader["email"];
                        user.Ativo = (bool)reader["ativo"];

                        usuarioEntities.Add(user);
                    }

                    return usuarioEntities;
                }
            }
        }

        public override bool InserirUsuario(string usuario, string senha, string email)
        {

            using (var cmd = CriarConexao())
            {

                cmd.CommandText = "INSERT INTO [dbo].[Usuario]([Usuario],[Senha],[Email],[Ativo]) VALUES (@Usuario, @Senha,@Email,@Ativo);";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();

                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Senha", senha);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Ativo", true);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }
    }
}
