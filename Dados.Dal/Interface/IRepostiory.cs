using ProjetoLogin.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Dao.Interface
{
    public interface IRepository<T> where T : class
    {
        bool getByUser(string user);
        UsuarioEntity getuser();
        List<UsuarioEntity> GetUsuarios();
        bool InserirUsuario(string usuario, string senha, string email);
    }
}
