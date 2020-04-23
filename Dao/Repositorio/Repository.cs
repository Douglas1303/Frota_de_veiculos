using ProjetoLogin.Dao.Interface;
using ProjetoLogin.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Dao.Repositorio
{
    public abstract class AbstractRepository<T> : IRepository<T> where T : class
    {

        public static SqlCommand CriarConexao()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString;
            var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");

            var connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;

            return (SqlCommand)connection.CreateCommand();

        }

        public abstract bool getByUser(string user);
        public abstract UsuarioEntity getuser();
        public abstract List<UsuarioEntity> GetUsuarios();
        public abstract bool InserirUsuario(string usuario, string senha, string email);
    }
}

